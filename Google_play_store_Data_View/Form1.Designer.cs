﻿namespace Google_play_store_Data_View
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
            formsPlot3 = new ScottPlot.WinForms.FormsPlot();
            FromPlotPiePercent = new ScottPlot.WinForms.FormsPlot();
            BtnExit = new Button();
            BtnTableReviewsApp = new Button();
            BtnSendData = new Button();
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
            // formsPlot3
            // 
            formsPlot3.DisplayScale = 1F;
            formsPlot3.Location = new Point(838, 318);
            formsPlot3.Name = "formsPlot3";
            formsPlot3.Size = new Size(223, 219);
            formsPlot3.TabIndex = 12;
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
            // BtnSendData
            // 
            BtnSendData.Location = new Point(37, 106);
            BtnSendData.Name = "BtnSendData";
            BtnSendData.Size = new Size(142, 44);
            BtnSendData.TabIndex = 16;
            BtnSendData.Text = "Send SQL";
            BtnSendData.UseVisualStyleBackColor = true;
            BtnSendData.Click += BtnSendData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 596);
            Controls.Add(BtnSendData);
            Controls.Add(BtnExit);
            Controls.Add(BtnTableReviewsApp);
            Controls.Add(formsPlot3);
            Controls.Add(FromPlotPiePercent);
            Controls.Add(DataGrideViewData);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataGrideViewData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGrideViewData;
        private ScottPlot.WinForms.FormsPlot formsPlot3;
        private ScottPlot.WinForms.FormsPlot FromPlotPiePercent;
        private Button BtnExit;
        private Button BtnTableReviewsApp;
        private Button BtnSendData;
    }
}
