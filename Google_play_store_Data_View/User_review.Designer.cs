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
            BtnCarry = new Button();
            BtnNext = new Button();
            FromPlotPiePercent = new ScottPlot.WinForms.FormsPlot();
            formsPlot2 = new ScottPlot.WinForms.FormsPlot();
            formsPlot3 = new ScottPlot.WinForms.FormsPlot();
            formsPlot4 = new ScottPlot.WinForms.FormsPlot();
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
            // BtnCarry
            // 
            BtnCarry.Location = new Point(25, 12);
            BtnCarry.Name = "BtnCarry";
            BtnCarry.Size = new Size(142, 44);
            BtnCarry.TabIndex = 4;
            BtnCarry.Text = "Cargar Informacion";
            BtnCarry.UseVisualStyleBackColor = true;
            BtnCarry.Click += BtnCarry_Click;
            // 
            // BtnNext
            // 
            BtnNext.Location = new Point(25, 493);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(142, 44);
            BtnNext.TabIndex = 5;
            BtnNext.Text = "Before";
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
            // formsPlot2
            // 
            formsPlot2.DisplayScale = 1F;
            formsPlot2.Location = new Point(1214, 39);
            formsPlot2.Name = "formsPlot2";
            formsPlot2.Size = new Size(223, 219);
            formsPlot2.TabIndex = 7;
            // 
            // formsPlot3
            // 
            formsPlot3.DisplayScale = 1F;
            formsPlot3.Location = new Point(905, 318);
            formsPlot3.Name = "formsPlot3";
            formsPlot3.Size = new Size(223, 219);
            formsPlot3.TabIndex = 8;
            // 
            // formsPlot4
            // 
            formsPlot4.DisplayScale = 1F;
            formsPlot4.Location = new Point(1214, 318);
            formsPlot4.Name = "formsPlot4";
            formsPlot4.Size = new Size(223, 219);
            formsPlot4.TabIndex = 9;
            // 
            // User_review
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1497, 582);
            Controls.Add(formsPlot4);
            Controls.Add(formsPlot3);
            Controls.Add(formsPlot2);
            Controls.Add(FromPlotPiePercent);
            Controls.Add(BtnNext);
            Controls.Add(BtnCarry);
            Controls.Add(DataGrideViewUserData);
            Name = "User_review";
            Text = "User_review";
            ((System.ComponentModel.ISupportInitialize)DataGrideViewUserData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGrideViewUserData;
        private Button BtnCarry;
        private Button BtnNext;
        private ScottPlot.WinForms.FormsPlot FromPlotPiePercent;
        private ScottPlot.WinForms.FormsPlot formsPlot2;
        private ScottPlot.WinForms.FormsPlot formsPlot3;
        private ScottPlot.WinForms.FormsPlot formsPlot4;
    }
}