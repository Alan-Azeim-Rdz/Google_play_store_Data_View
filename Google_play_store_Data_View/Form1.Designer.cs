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
            BtnCarry = new Button();
            BtnNext = new Button();
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
            // BtnCarry
            // 
            BtnCarry.Location = new Point(36, 23);
            BtnCarry.Name = "BtnCarry";
            BtnCarry.Size = new Size(142, 44);
            BtnCarry.TabIndex = 1;
            BtnCarry.Text = "Cargar Informacion";
            BtnCarry.UseVisualStyleBackColor = true;
            BtnCarry.Click += BtnCarry_Click;
            // 
            // BtnNext
            // 
            BtnNext.Location = new Point(36, 515);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(142, 44);
            BtnNext.TabIndex = 2;
            BtnNext.Text = "Next";
            BtnNext.UseVisualStyleBackColor = true;
            BtnNext.Click += BtnNext_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 596);
            Controls.Add(BtnNext);
            Controls.Add(BtnCarry);
            Controls.Add(DataGrideViewData);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DataGrideViewData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGrideViewData;
        private Button BtnCarry;
        private Button BtnNext;
    }
}
