namespace Google_play_store_Data_View
{
    using Microsoft.Data.SqlClient;
    using Microsoft.VisualBasic.FileIO;
    using ScottPlot;
    using ScottPlot.Colormaps;
    using ScottPlot.WinForms;
    using System.Data;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
                using (TextFieldParser parser = new TextFieldParser(archive_ruta))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    // Leer encabezados
                    if (!parser.EndOfData)
                    {
                        string[] headers = parser.ReadFields();
                        foreach (string header in headers)
                        {
                            dataGrid.Columns.Add(header, header);
                        }
                    }

                    // Leer filas
                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        dataGrid.Rows.Add(fields);
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

        private async void BtnSendData_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                await connection.OpenAsync();
                foreach (DataGridViewRow row in DataGrideViewData.Rows)
                {
                    if (row.IsNewRow) continue;

                    string query = @"INSERT INTO apps 
            (App, Category, Rating, Reviews, Size, Installs, Type, Price, Content_Rating, Genres, Last_Updated, Current_Ver, Android_Ver) 
            VALUES 
            (@App, @Category, @Rating, @Reviews, @Size, @Installs, @Type, @Price, @Content_Rating, @Genres, @Last_Updated, @Current_Ver, @Android_Ver)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", 1);
                        command.Parameters.AddWithValue("@App", row.Cells["App"].Value?.ToString() ?? "");
                        command.Parameters.AddWithValue("@Category", row.Cells["Category"].Value?.ToString() ?? "");
                        command.Parameters.AddWithValue("@Rating", Convert.ToDouble(row.Cells["Rating"].Value));
                        command.Parameters.AddWithValue("@Reviews", row.Cells["Reviews"].Value?.ToString() ??"");
                        command.Parameters.AddWithValue("@Size", row.Cells["Size"].Value?.ToString() ?? "");
                        command.Parameters.AddWithValue("@Installs", row.Cells["Installs"].Value?.ToString() ?? "");
                        command.Parameters.AddWithValue("@Type", row.Cells["Type"].Value?.ToString() ?? "");
                        command.Parameters.AddWithValue("@Price", row.Cells["Price"].Value?.ToString() ?? "");
                        command.Parameters.AddWithValue("@Content_Rating", row.Cells["Content Rating"].Value?.ToString() ?? "");
                        command.Parameters.AddWithValue("@Genres", row.Cells["Genres"].Value?.ToString() ?? "");
                        command.Parameters.AddWithValue("@Last_Updated", row.Cells["Last Updated"].Value ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Current_Ver", row.Cells["Current Ver"].Value?.ToString() ?? "");
                        command.Parameters.AddWithValue("@Android_Ver", row.Cells["Android Ver"].Value?.ToString() ?? "");

                        double rating;
                        if (double.TryParse(row.Cells["Rating"].Value?.ToString(), out rating))
                        {
                            command.Parameters.AddWithValue("@Rating", rating);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Rating", DBNull.Value);
                        }
                    }
                }
                
            }

            MessageBox.Show("Datos enviados a la base de datos correctamente.");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
