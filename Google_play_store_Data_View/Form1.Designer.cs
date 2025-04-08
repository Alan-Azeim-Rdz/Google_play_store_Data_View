namespace Google_play_store_Data_View
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGrideViewData = new DataGridView();
            formsPlot4 = new ScottPlot.WinForms.FormsPlot();
            formsPlot3 = new ScottPlot.WinForms.FormsPlot();
            formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            FromPlotPiePercent = new ScottPlot.WinForms.FormsPlot();
            BtnExit = new Button();
            BtnTableReviewsApp = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGrideViewData).BeginInit();
            SuspendLayout();
            // 
            // DataGrideViewData
            // 
            DataGrideViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrideViewData.Location = new Point(224, 23);
            DataGrideViewData.Name = "DataGrideViewData";
            DataGrideViewData.Size = new Size(563, 536);
            DataGrideViewData.TabIndex = 0;
            // 
            // formsPlot4
            // 
            formsPlot4.DisplayScale = 1F;
            formsPlot4.Location = new Point(1147, 318);
            formsPlot4.Name = "formsPlot4";
            formsPlot4.Size = new Size(223, 219);
            formsPlot4.TabIndex = 13;
            // 
            // formsPlot3
            // 
            formsPlot3.DisplayScale = 1F;
            formsPlot3.Location = new Point(838, 318);
            formsPlot3.Name = "formsPlot3";
            formsPlot3.Size = new Size(223, 219);
            formsPlot3.TabIndex = 12;
            // 
            // formsPlot2
            // 
            formsPlot2.DisplayScale = 1F;
            formsPlot2.Location = new Point(1147, 39);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(223, 219);
            formsPlot2.TabIndex = 11;
            // 
            // FromPlotPiePercent
            // 
            FromPlotPiePercent.DisplayScale = 1F;
            FromPlotPiePercent.Location = new Point(838, 39);
            FromPlotPiePercent.Name = "FromPlotPiePercent";
            FromPlotPiePercent.Size = new Size(223, 219);
            FromPlotPiePercent.TabIndex = 10;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(37, 515);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(142, 44);
            BtnExit.TabIndex = 15;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnTableReviewsApp
            // 
            BtnTableReviewsApp.Location = new Point(37, 23);
            BtnTableReviewsApp.Name = "BtnTableReviewsApp";
            BtnTableReviewsApp.Size = new Size(142, 44);
            BtnTableReviewsApp.TabIndex = 14;
            BtnTableReviewsApp.Text = "Table Review Google Play";
            BtnTableReviewsApp.UseVisualStyleBackColor = true;
            BtnTableReviewsApp.Click += BtnTableReviewsApp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 596);
            Controls.Add(BtnExit);
            Controls.Add(BtnTableReviewsApp);
            Controls.Add(formsPlot4);
            Controls.Add(formsPlot3);
            Controls.Add(formsPlot2);
            Controls.Add(FromPlotPiePercent);
            Controls.Add(DataGrideViewData);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DataGrideViewData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGrideViewData;
        private ScottPlot.WinForms.FormsPlot formsPlot4;
        private ScottPlot.WinForms.FormsPlot formsPlot3;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
        private ScottPlot.WinForms.FormsPlot FromPlotPiePercent;
        private Button BtnExit;
        private Button BtnTableReviewsApp;
    }
}
