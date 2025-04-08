using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;
using ScottPlot;

namespace Google_play_store_Data_View
{
    public partial class User_review : Form
    {
        string stringConnection = @"Server=ALAN_LUX_ASUS\SQLEXPRESS08;Database=Google_Play_Store;Trusted_Connection=True;TrustServerCertificate=true;";
        public User_review()
        {
            InitializeComponent();
            Loading_Data_Review(DataGrideViewUserData);
        }

        private void Loading_Data_Review(DataGridView dataGrid)
        {
            string archive_ruta = @"Archivos\googleplaystore_user_reviews.CSV";

            // lee el archivo CSV y dependiendo del renglon 0 genera las columnas del DataGridView
            try
            {
                using (StreamReader sr = new StreamReader(archive_ruta))
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
                MessageBox.Show($"Ocurrió un error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //obtiene los datos de la columna 0, estos valores dependiendo de la cantidad los cuenta y los agrega en un arreglo de double
            double[] data = new double[dataGrid.Rows.Count];
            for (int i = 11; i < dataGrid.Rows.Count; i++)
            {
                data[i] = Convert.ToDouble(dataGrid.Rows[i].Cells[0].Value);
            }
            //llama a la funcion Pie_valor para graficar el arreglo de double
            Pie_valor(data);

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

        private void Pie_valor(double[] data)
        {
            // Asume que tienes un control FormsPlot en tu formulario llamado formsPlot1
            var myPlot =  FromPlotPiePercent.Plot;
            myPlot.Clear(); // Limpiar cualquier gráfico anterior

            var pie = myPlot.Add.Pie(data);
            pie.ExplodeFraction = .1;

            // Ocultar componentes innecesarios del gráfico
            myPlot.Axes.Frameless();

            // Refrescar el control para mostrar el nuevo gráfico
            FromPlotPiePercent.Refresh();

            ScottPlot.Plot myPlot = new();

            var pie = myPlot.Add.Pie(data);
            var pie = myPlot.Add.Pie(values);
            pie.ExplodeFraction = .1;

            // hide unnecessary plot components
            myPlot.Axes.Frameless();
            myPlot.HideGrid();

            myPlot.SavePng("demo.png", 400, 300);
        }
    }
}