namespace Dogecoin_API
{
    partial class ConvertToDoge
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
            this.lbl_DOGE = new System.Windows.Forms.Label();
            this.lbl_USD = new System.Windows.Forms.Label();
            this.tmr_Update = new System.Windows.Forms.Timer(this.components);
            this.txt_DogeAmount = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_DOGE
            // 
            this.lbl_DOGE.AutoSize = true;
            this.lbl_DOGE.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_DOGE.Location = new System.Drawing.Point(12, 18);
            this.lbl_DOGE.Name = "lbl_DOGE";
            this.lbl_DOGE.Size = new System.Drawing.Size(101, 34);
            this.lbl_DOGE.TabIndex = 0;
            this.lbl_DOGE.Text = "DOGE: ";
            // 
            // lbl_USD
            // 
            this.lbl_USD.AutoSize = true;
            this.lbl_USD.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_USD.Location = new System.Drawing.Point(12, 52);
            this.lbl_USD.Name = "lbl_USD";
            this.lbl_USD.Size = new System.Drawing.Size(83, 34);
            this.lbl_USD.TabIndex = 1;
            this.lbl_USD.Text = "USD: ";
            // 
            // tmr_Update
            // 
            this.tmr_Update.Interval = 5000;
            // 
            // txt_DogeAmount
            // 
            this.txt_DogeAmount.Location = new System.Drawing.Point(18, 90);
            this.txt_DogeAmount.Name = "txt_DogeAmount";
            this.txt_DogeAmount.Size = new System.Drawing.Size(400, 20);
            this.txt_DogeAmount.TabIndex = 2;
            this.txt_DogeAmount.Text = "Enter Doge Amount";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(424, 88);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(182, 23);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            // 
            // ConvertToDoge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 122);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txt_DogeAmount);
            this.Controls.Add(this.lbl_USD);
            this.Controls.Add(this.lbl_DOGE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConvertToDoge";
            this.ShowIcon = false;
            this.Text = "Convert";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DOGE;
        private System.Windows.Forms.Label lbl_USD;
        private System.Windows.Forms.Timer tmr_Update;
        private System.Windows.Forms.TextBox txt_DogeAmount;
        private System.Windows.Forms.Button btn_Submit;
    }
}