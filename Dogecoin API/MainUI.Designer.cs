namespace Dogecoin_API
{
    partial class MainUI
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Value = new System.Windows.Forms.Label();
            this.tmr_Update = new System.Windows.Forms.Timer(this.components);
            this.lbl_PC1H = new System.Windows.Forms.Label();
            this.lbl_PC24H = new System.Windows.Forms.Label();
            this.lbl_PC7D = new System.Windows.Forms.Label();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Value
            // 
            this.lbl_Value.AutoSize = true;
            this.lbl_Value.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Value.Location = new System.Drawing.Point(202, 9);
            this.lbl_Value.Name = "lbl_Value";
            this.lbl_Value.Size = new System.Drawing.Size(178, 34);
            this.lbl_Value.TabIndex = 0;
            this.lbl_Value.Text = "Value in USD";
            // 
            // tmr_Update
            // 
            this.tmr_Update.Enabled = true;
            this.tmr_Update.Interval = 5000;
            // 
            // lbl_PC1H
            // 
            this.lbl_PC1H.AutoSize = true;
            this.lbl_PC1H.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PC1H.Location = new System.Drawing.Point(164, 43);
            this.lbl_PC1H.Name = "lbl_PC1H";
            this.lbl_PC1H.Size = new System.Drawing.Size(284, 34);
            this.lbl_PC1H.TabIndex = 2;
            this.lbl_PC1H.Text = "Percent Change (1hr)";
            // 
            // lbl_PC24H
            // 
            this.lbl_PC24H.AutoSize = true;
            this.lbl_PC24H.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PC24H.Location = new System.Drawing.Point(164, 77);
            this.lbl_PC24H.Name = "lbl_PC24H";
            this.lbl_PC24H.Size = new System.Drawing.Size(301, 34);
            this.lbl_PC24H.TabIndex = 3;
            this.lbl_PC24H.Text = "Percent Change (24hr)";
            // 
            // lbl_PC7D
            // 
            this.lbl_PC7D.AutoSize = true;
            this.lbl_PC7D.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PC7D.Location = new System.Drawing.Point(174, 111);
            this.lbl_PC7D.Name = "lbl_PC7D";
            this.lbl_PC7D.Size = new System.Drawing.Size(274, 34);
            this.lbl_PC7D.TabIndex = 4;
            this.lbl_PC7D.Text = "Percent Change (7d)";
            // 
            // btn_Convert
            // 
            this.btn_Convert.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Convert.ForeColor = System.Drawing.Color.White;
            this.btn_Convert.Location = new System.Drawing.Point(170, 154);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(295, 23);
            this.btn_Convert.TabIndex = 5;
            this.btn_Convert.Text = "Convert DOGE to USD";
            this.btn_Convert.UseVisualStyleBackColor = false;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 189);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.lbl_PC7D);
            this.Controls.Add(this.lbl_PC24H);
            this.Controls.Add(this.lbl_PC1H);
            this.Controls.Add(this.lbl_Value);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainUI";
            this.ShowIcon = false;
            this.Text = "Dogecoin";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Value;
        private System.Windows.Forms.Timer tmr_Update;
        private System.Windows.Forms.Label lbl_PC1H;
        private System.Windows.Forms.Label lbl_PC24H;
        private System.Windows.Forms.Label lbl_PC7D;
        private System.Windows.Forms.Button btn_Convert;
    }
}

