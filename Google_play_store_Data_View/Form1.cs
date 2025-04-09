namespace Google_play_store_Data_View
{
    using Microsoft.Data.SqlClient;
    using ScottPlot;
    using ScottPlot.WinForms;
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
                MessageBox.Show($"Ocurrió un error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ProcessData(DataGrideViewData, "Content Rating", FromPlotPiePercent);
            ProcessData(DataGrideViewData, "Category", formsPlot3);

        }
        private void ProcessData(DataGridView dataGrid, string columnName, FormsPlot plot)
        {
            Dictionary<string, double> countData = new Dictionary<string, double>();

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.IsNewRow) continue; // Saltar fila vacía

                object cellValue = row.Cells[columnName].Value;
                if (cellValue != null)
                {
                    string value = cellValue.ToString().Trim().ToLower();

                    if (!string.IsNullOrEmpty(value))
                    {
                        if (countData.ContainsKey(value))
                            countData[value]++;
                        else
                            countData[value] = 1;
                    }
                }
            }

            // Convertir a arreglos
            double[] values = countData.Values.ToArray();
            string[] labels = countData.Keys.ToArray();

            // Llamar a la función para graficar

            if (columnName == "Content Rating")
            {
                Create_Pie_Table(values, labels, plot, columnName);
            }
            else if (columnName == "Category")
            {
                Create_table_barr(values, labels, plot, columnName);
            }


        }

        private void Create_Pie_Table(double[] values, string[] labels, FormsPlot plot, string title)
        {
            plot.Plot.Clear(); // Limpiar gráfico previo
            var pie = plot.Plot.Add.Pie(values);
            pie.ExplodeFraction = .1;
            pie.SliceLabelDistance = 0.5;

            // Calcular porcentajes
            double total = values.Sum();
            double[] percentages = values.Select(x => x / total * 100).ToArray();

            // Etiquetas de los segmentos
            for (int i = 0; i < values.Length; i++)
            {
                pie.Slices[i].Label = $"{labels[i]} ({percentages[i]:0.0}%)";
                pie.Slices[i].LabelFontSize = 14;
                pie.Slices[i].LabelBold = true;
                pie.Slices[i].LabelFontColor = Colors.Black.WithAlpha(.7);
            }

            // Ajustar apariencia del gráfico
            plot.Plot.Title($"Distribución de {title}");
            plot.Plot.Axes.Frameless();
            plot.Plot.HideGrid();
            plot.Plot.Axes.AutoScale();
            plot.Refresh();
        }

        private void Create_table_barr(double[] values, string[] labels, FormsPlot plot, string title)
        {
            plot.Plot.Clear();
            var barPlot = plot.Plot.Add.Bars(values);

            // define the content of labels
            foreach (var bar in barPlot.Bars)
            {
                bar.Label = bar.Value.ToString();
            }

            // customize label style
            barPlot.ValueLabelStyle.Bold = true;
            barPlot.ValueLabelStyle.FontSize = 18;

            plot.Plot.Axes.Margins(bottom: 0, top: .2);

            plot.Plot.SavePng("demo.png", 400, 300);
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
            User_review user_Review = new User_review();
            user_Review.Show();
            this.Hide();
        }
    }
}
