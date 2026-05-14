using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Proje
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=.\\SQLEXPRESS01;Database=Film2026;Integrated Security=True;TrustServerCertificate=True;";
        private int selectedFilmId = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kategoriCmb.Items.Clear();
            kategoriCmb.Items.Add("Aksiyon");
            kategoriCmb.Items.Add("Komedi");
            kategoriCmb.Items.Add("Dram");
            kategoriCmb.Items.Add("Korku");
            kategoriCmb.SelectedIndex = 0;
        }

        //Verileri listeleme
        private void listButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT FilmId, FilmAd, Yonetmen, Sure, Puan, YapimSirketi, Kategori FROM TblFilmler";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataTable.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        //Verleri kaydetme
        private void kaydetButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(filmAdTxt.Text) ||
                string.IsNullOrWhiteSpace(yonetmenTxt.Text) ||
                string.IsNullOrWhiteSpace(this.sureTxt.Text) ||
                string.IsNullOrWhiteSpace(this.puanTxt.Text) ||
                string.IsNullOrWhiteSpace(yapimSirketiTxt.Text) ||
                kategoriCmb.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurunuz.");
                return;
            }

            if (filmAdTxt.Text.Trim().Length > 80)
            {
                MessageBox.Show("Film adý en fazla 80 karakter olabilir.");
                return;
            }
            if (yonetmenTxt.Text.Trim().Length > 50)
            {
                MessageBox.Show("Yönetmen adý en fazla 50 karakter olabilir.");
                return;
            }
            if (yapimSirketiTxt.Text.Trim().Length > 30)
            {
                MessageBox.Show("Yapým þirketi en fazla 30 karakter olabilir.");
                return;
            }

            if (!int.TryParse(sureTxt.Text, out int sure) || sure <= 0)
            {
                MessageBox.Show("Süre pozitif tam sayý olmalýdýr.");
                return;
            }
            if (!int.TryParse(puanTxt.Text, out int puan) || puan < 1 || puan > 10)
            {
                MessageBox.Show("Puan 1 ile 10 arasýnda tam sayý olmalýdýr.");
                return;
            }

            try
            {
                int kategoriId = KategoriAdToId(kategoriCmb.SelectedItem.ToString());

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO TblFilmler (FilmAd, Yonetmen, Sure, Puan, YapimSirketi, Kategori)
                                     VALUES (@FilmAd, @Yonetmen, @Sure, @Puan, @YapimSirketi, @Kategori)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FilmAd", filmAdTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@Yonetmen", yonetmenTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@Sure", Convert.ToInt32(this.sureTxt.Text));
                    cmd.Parameters.AddWithValue("@Puan", Convert.ToInt32(this.puanTxt.Text));
                    cmd.Parameters.AddWithValue("@YapimSirketi", yapimSirketiTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@Kategori", kategoriId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Kayýt baþarýyla eklendi.");
                listButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        //verileri güncelleme
        private void guncelleButton_Click(object sender, EventArgs e)
        {
            if (selectedFilmId == -1)
            {
                MessageBox.Show("Lütfen güncellemek istediðiniz kaydý listeden seçiniz.");
                return;
            }

            try
            {
                int kategoriId = KategoriAdToId(kategoriCmb.SelectedItem.ToString());

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE TblFilmler SET
                                        FilmAd       = @FilmAd,
                                        Yonetmen     = @Yonetmen,
                                        Sure         = @Sure,
                                        Puan         = @Puan,
                                        YapimSirketi = @YapimSirketi,
                                        Kategori     = @Kategori
                                     WHERE FilmId = @FilmId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FilmAd", filmAdTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@Yonetmen", yonetmenTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@Sure", Convert.ToInt32(sureTxt.Text));
                    cmd.Parameters.AddWithValue("@Puan", Convert.ToInt32(puanTxt.Text));
                    cmd.Parameters.AddWithValue("@YapimSirketi", yapimSirketiTxt.Text.Trim());
                    cmd.Parameters.AddWithValue("@Kategori", kategoriId);
                    cmd.Parameters.AddWithValue("@FilmId", selectedFilmId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Kayýt baþarýyla güncellendi.");
                listButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        //verileri silme
        private void silButton_Click(object sender, EventArgs e)
        {
            if (selectedFilmId == -1)
            {
                MessageBox.Show("Lütfen silmek istediðiniz kaydý listeden seçiniz.");
                return;
            }

            DialogResult dr = MessageBox.Show(
                $"FilmId={selectedFilmId} olan kayýt silinecek. Emin misiniz?",
                "Silme Onayý",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM TblFilmler WHERE FilmId = @FilmId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FilmId", selectedFilmId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Kayýt baþarýyla silindi.");
                selectedFilmId = -1;
                filmIdTxt.Text = "";
                filmAdTxt.Text = "";
                yonetmenTxt.Text = "";
                sureTxt.Text = "";
                puanTxt.Text = "";
                yapimSirketiTxt.Text = "";
                kategoriCmb.SelectedIndex = 0;
                listButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        //Verileri göreceðimiz tablo
        private void dataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dataTable.Rows[e.RowIndex];

                selectedFilmId = Convert.ToInt32(row.Cells["FilmId"].Value);
                filmIdTxt.Text = selectedFilmId.ToString();
                filmAdTxt.Text = row.Cells["FilmAd"].Value.ToString();
                yonetmenTxt.Text = row.Cells["Yonetmen"].Value.ToString();
                sureTxt.Text = row.Cells["Sure"].Value.ToString();
                puanTxt.Text = row.Cells["Puan"].Value.ToString();
                yapimSirketiTxt.Text = row.Cells["YapimSirketi"].Value.ToString();

                int kategoriId = Convert.ToInt32(row.Cells["Kategori"].Value);
                switch (kategoriId)
                {
                    case 1: kategoriCmb.SelectedItem = "Aksiyon"; break;
                    case 2: kategoriCmb.SelectedItem = "Komedi"; break;
                    case 3: kategoriCmb.SelectedItem = "Dram"; break;
                    case 4: kategoriCmb.SelectedItem = "Korku"; break;
                    default: kategoriCmb.SelectedIndex = 0; break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private int KategoriAdToId(string kategoriAd)
        {
            switch (kategoriAd)
            {
                case "Aksiyon": return 1;
                case "Komedi": return 2;
                case "Dram": return 3;
                case "Korku": return 4;
                default: return 1;
            }
        }
    }
}