namespace Hastaneotomasyon
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Randevu kayıt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Doktor kayıt ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(126, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Hasta dosyası ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "BIR ISLEM SECINIZ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(126, 353);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 43);
            this.button4.TabIndex = 4;
            this.button4.Text = "Hasta dosyası listesi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(126, 439);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 31);
            this.button5.TabIndex = 5;
            this.button5.Text = "Hasta arama";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(126, 199);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 32);
            this.button7.TabIndex = 7;
            this.button7.Text = "Poliklinikler";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(117, 170);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(123, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "Poliklinik hasta Lİstesi";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(126, 476);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(105, 38);
            this.button11.TabIndex = 11;
            this.button11.Text = "Biyomedikal Mühendis ekle";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(126, 237);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(105, 34);
            this.button9.TabIndex = 12;
            this.button9.Text = "Giriş loglarını görüntüle";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(370, 545);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Bilgi İşem Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
    }
}