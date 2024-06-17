namespace Csharp_TinhLaiSuatNganHang
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSotien = new System.Windows.Forms.TextBox();
            this.txtLaisuat = new System.Windows.Forms.TextBox();
            this.txtSonamgui = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.lsbKetqua = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lãi suất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số năm gửi";
            // 
            // txtSotien
            // 
            this.txtSotien.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSotien.Location = new System.Drawing.Point(237, 66);
            this.txtSotien.Name = "txtSotien";
            this.txtSotien.Size = new System.Drawing.Size(276, 36);
            this.txtSotien.TabIndex = 1;
            this.txtSotien.TextChanged += new System.EventHandler(this.txtSotien_TextChanged);
            // 
            // txtLaisuat
            // 
            this.txtLaisuat.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLaisuat.Location = new System.Drawing.Point(237, 125);
            this.txtLaisuat.Name = "txtLaisuat";
            this.txtLaisuat.Size = new System.Drawing.Size(276, 36);
            this.txtLaisuat.TabIndex = 1;
            // 
            // txtSonamgui
            // 
            this.txtSonamgui.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSonamgui.Location = new System.Drawing.Point(237, 187);
            this.txtSonamgui.Name = "txtSonamgui";
            this.txtSonamgui.Size = new System.Drawing.Size(276, 36);
            this.txtSonamgui.TabIndex = 1;
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(186, 259);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(166, 70);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lsbKetqua
            // 
            this.lsbKetqua.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbKetqua.FormattingEnabled = true;
            this.lsbKetqua.ItemHeight = 29;
            this.lsbKetqua.Location = new System.Drawing.Point(61, 364);
            this.lsbKetqua.Name = "lsbKetqua";
            this.lsbKetqua.Size = new System.Drawing.Size(521, 178);
            this.lsbKetqua.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 649);
            this.Controls.Add(this.lsbKetqua);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtSonamgui);
            this.Controls.Add(this.txtLaisuat);
            this.Controls.Add(this.txtSotien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSotien;
        private System.Windows.Forms.TextBox txtLaisuat;
        private System.Windows.Forms.TextBox txtSonamgui;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.ListBox lsbKetqua;
    }
}

