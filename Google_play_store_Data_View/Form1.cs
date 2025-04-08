namespace Google_play_store_Data_View
{
    using Microsoft.Data.SqlClient;
    using ScottPlot;
    using System.Data;

    public partial class Form1 : Form
    {
        string stringConnection = @"Server=ALAN_LUX_ASUS\SQLEXPRESS08;Database=Google_Play_Store;Trusted_Connection=True;TrustServerCertificate=true;";
        string archive_ruta = @"Archivos\googleplaystore.CSV";
        public Form1()
        {
            InitializeComponent();
            Archive_Carry(archive_ruta, DataGrideViewData);
        }


        private void Archive_Carry(string url, DataGridView dataGrid)
        {
            // lee el archivo CSV y dependiendo del renglon 0 genera las columnas del DataGridView
            try
            {
                using (StreamReader sr = new StreamReader(url))
                {
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dataGrid.Columns.Add(header, header);
                    }
                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        dataGrid.Rows.Add(rows);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"El archivo no fue encontrado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurri� un error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            //abrir el formulario de User_review
            User_review user_Review = new User_review();
            user_Review.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTableReviewsApp_Click(object sender, EventArgs e)
        {
            //abrir el fomulario llamado from1
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
