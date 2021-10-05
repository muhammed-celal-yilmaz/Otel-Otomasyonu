
namespace Grand_Uludağ_Otel
{
    partial class FrmOnay
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
            this.TxtOnay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOnay = new System.Windows.Forms.Button();
            this.BtnKod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtOnay
            // 
            this.TxtOnay.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TxtOnay.BackColor = System.Drawing.Color.Silver;
            this.TxtOnay.Location = new System.Drawing.Point(179, 72);
            this.TxtOnay.Name = "TxtOnay";
            this.TxtOnay.Size = new System.Drawing.Size(253, 22);
            this.TxtOnay.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Onay Kodu :";
            // 
            // BtnOnay
            // 
            this.BtnOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOnay.Location = new System.Drawing.Point(241, 145);
            this.BtnOnay.Name = "BtnOnay";
            this.BtnOnay.Size = new System.Drawing.Size(127, 55);
            this.BtnOnay.TabIndex = 10;
            this.BtnOnay.Text = "Onayla";
            this.BtnOnay.UseVisualStyleBackColor = true;
            this.BtnOnay.Click += new System.EventHandler(this.BtnOnay_Click);
            // 
            // BtnKod
            // 
            this.BtnKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKod.Location = new System.Drawing.Point(509, 54);
            this.BtnKod.Name = "BtnKod";
            this.BtnKod.Size = new System.Drawing.Size(208, 40);
            this.BtnKod.TabIndex = 11;
            this.BtnKod.Text = "Kodu Gönder";
            this.BtnKod.UseVisualStyleBackColor = true;
            this.BtnKod.Click += new System.EventHandler(this.BtnKod_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sisteme kayıtlı mail adresinize gelen onay kodunu girin :";
            // 
            // FrmOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 242);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnKod);
            this.Controls.Add(this.BtnOnay);
            this.Controls.Add(this.TxtOnay);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOnay";
            this.Text = "Mail Onayı";
            this.Load += new System.EventHandler(this.FrmOnay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtOnay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOnay;
        private System.Windows.Forms.Button BtnKod;
        private System.Windows.Forms.Label label2;
    }
}