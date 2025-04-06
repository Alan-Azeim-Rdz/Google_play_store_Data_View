using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
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
        }

        private void BtnCarry_Click(object sender, EventArgs e)
        {
            string archive_ruta = @"Archivos\googleplaystore.CSV";

            // lee el archivo CSV y dependiendo del renglon 0 genera las columnas del DataGridView
            DataGridView dataGrid = new DataGridView();
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

            // Extraer los datos de la columna "App"
            List<string> appNames = new List<string>();
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells["App"].Value != null)
                {
                    appNames.Add(row.Cells["App"].Value.ToString());
                }
            }

            // Crear un gráfico con ScottPlot
            var plt = new ScottPlot.Plot();
            double[] values = appNames.Select(x => (double)x.Length).ToArray();
            var bar = plt.AddBar(values);
            plt.XTicks(appNames.ToArray());

            // Mostrar el gráfico en un formulario
            var form = new Form();
            var formsPlot = new ScottPlot.FormsPlot() { Dock = DockStyle.Fill };
            form.Controls.Add(formsPlot);
            formsPlot.Plot = plt;
            form.ShowDialog();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            //abrir el formulario de User_review
            User_review user_Review = new User_review();
            user_Review.Show();
            this.Hide();
        }

        private void Pie_with_Percent_Labels(double[] values)
        {
            // create a pie chart
            var pie = FromPlotPiePercent.Plot.AddPie(values);
            pie.ExplodeFraction = .1;
            pie.SliceLabelDistance = 0.5;

            // determine percentages for each slice
            double total = pie.Slices.Select(x => x.Value).Sum();
            double[] percentages = pie.Slices.Select(x => x.Value / total * 100).ToArray();

            // set each slice label to its percentage
            for (int i = 0; i < pie.Slices.Count; i++)
            {
                pie.Slices[i].Label = $"{percentages[i]:0.0}%";
                pie.Slices[i].LabelFontSize = 20;
                pie.Slices[i].LabelBold = true;
            }

            // hide unnecessary plot components
            FromPlotPiePercent.Plot.Axes.Frameless();
            FromPlotPiePercent.Plot.HideGrid();
            FromPlotPiePercent.Plot.Axes.AutoScale();
            FromPlotPiePercent.Refresh();
        }
    }
}