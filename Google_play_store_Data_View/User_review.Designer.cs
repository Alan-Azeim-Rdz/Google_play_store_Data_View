namespace Google_play_store_Data_View
{
    partial class User_review
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGrideViewUserData = new DataGridView();
            BtnNext = new Button();
            FromPlotPiePercent = new ScottPlot.WinForms.FormsPlot();
            FromPlotBar = new ScottPlot.WinForms.FormsPlot();
            BtnExit = new Button();
            BtnSendData = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGrideViewUserData).BeginInit();
            SuspendLayout();
            // 
            // DataGrideViewUserData
            // 
            DataGrideViewUserData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrideViewUserData.Location = new Point(210, 12);
            DataGrideViewUserData.Name = "DataGrideViewUserData";
            DataGrideViewUserData.Size = new Size(593, 536);
            DataGrideViewUserData.TabIndex = 3;
            // 
            // BtnNext
            // 
            BtnNext.Location = new Point(25, 29);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(142, 44);
            BtnNext.TabIndex = 5;
            BtnNext.Text = "Table Apps Google play";
            BtnNext.UseVisualStyleBackColor = true;
            BtnNext.Click += BtnNext_Click;
            // 
            // FromPlotPiePercent
            // 
            FromPlotPiePercent.DisplayScale = 1F;
            FromPlotPiePercent.Location = new Point(905, 39);
            FromPlotPiePercent.Name = "FromPlotPiePercent";
            FromPlotPiePercent.Size = new Size(223, 219);
            FromPlotPiePercent.TabIndex = 6;
            // 
            // FromPlotBar
            // 
            FromPlotBar.DisplayScale = 1F;
            FromPlotBar.Location = new Point(905, 318);
            FromPlotBar.Name = "FromPlotBar";
            FromPlotBar.Size = new Size(223, 219);
            FromPlotBar.TabIndex = 8;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(25, 493);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(142, 44);
            BtnExit.TabIndex = 10;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnSendData
            // 
            BtnSendData.Location = new Point(25, 140);
            BtnSendData.Name = "BtnSendData";
            BtnSendData.Size = new Size(142, 44);
            BtnSendData.TabIndex = 11;
            BtnSendData.Text = "Send SQL";
            BtnSendData.UseVisualStyleBackColor = true;
            BtnSendData.Click += BtnSendData_Click;
            // 
            // User_review
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 582);
            Controls.Add(BtnSendData);
            Controls.Add(BtnExit);
            Controls.Add(FromPlotBar);
            Controls.Add(FromPlotPiePercent);
            Controls.Add(BtnNext);
            Controls.Add(DataGrideViewUserData);
            Name = "User_review";
            Text = "User_review";
            ((System.ComponentModel.ISupportInitialize)DataGrideViewUserData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGrideViewUserData;
        private Button BtnNext;
        private ScottPlot.WinForms.FormsPlot FromPlotPiePercent;
        private ScottPlot.WinForms.FormsPlot FromPlotBar;
        private Button BtnExit;
        private Button BtnSendData;
    }
}