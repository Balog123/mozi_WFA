namespace mozi_WFA
{
    partial class frmFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.azonositoTextBox = new System.Windows.Forms.TextBox();
            this.cimTextBox = new System.Windows.Forms.TextBox();
            this.hosszTextBox = new System.Windows.Forms.TextBox();
            this.mufajTextBox = new System.Windows.Forms.TextBox();
            this.gyartevTextBox = new System.Windows.Forms.TextBox();
            this.szarmazasTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.rendezo = new System.Windows.Forms.ComboBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosító:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hossz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Müfaj:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rendező:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gyártási év:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Származás:";
            // 
            // azonositoTextBox
            // 
            this.azonositoTextBox.Location = new System.Drawing.Point(117, 33);
            this.azonositoTextBox.Name = "azonositoTextBox";
            this.azonositoTextBox.ReadOnly = true;
            this.azonositoTextBox.Size = new System.Drawing.Size(100, 20);
            this.azonositoTextBox.TabIndex = 7;
            // 
            // cimTextBox
            // 
            this.cimTextBox.Location = new System.Drawing.Point(86, 81);
            this.cimTextBox.Name = "cimTextBox";
            this.cimTextBox.Size = new System.Drawing.Size(100, 20);
            this.cimTextBox.TabIndex = 8;
            // 
            // hosszTextBox
            // 
            this.hosszTextBox.Location = new System.Drawing.Point(98, 119);
            this.hosszTextBox.Name = "hosszTextBox";
            this.hosszTextBox.Size = new System.Drawing.Size(100, 20);
            this.hosszTextBox.TabIndex = 9;
            // 
            // mufajTextBox
            // 
            this.mufajTextBox.Location = new System.Drawing.Point(95, 163);
            this.mufajTextBox.Name = "mufajTextBox";
            this.mufajTextBox.Size = new System.Drawing.Size(100, 20);
            this.mufajTextBox.TabIndex = 10;
            // 
            // gyartevTextBox
            // 
            this.gyartevTextBox.Location = new System.Drawing.Point(122, 248);
            this.gyartevTextBox.MaxLength = 4;
            this.gyartevTextBox.Name = "gyartevTextBox";
            this.gyartevTextBox.Size = new System.Drawing.Size(100, 20);
            this.gyartevTextBox.TabIndex = 11;
            // 
            // szarmazasTextBox
            // 
            this.szarmazasTextBox.Location = new System.Drawing.Point(120, 289);
            this.szarmazasTextBox.Name = "szarmazasTextBox";
            this.szarmazasTextBox.Size = new System.Drawing.Size(100, 20);
            this.szarmazasTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(677, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 76);
            this.button1.TabIndex = 13;
            this.button1.Text = "Keres";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(677, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 76);
            this.button2.TabIndex = 14;
            this.button2.Text = "Ment";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(677, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 88);
            this.button3.TabIndex = 15;
            this.button3.Text = "Töröl";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(677, 315);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 83);
            this.button4.TabIndex = 16;
            this.button4.Text = "Üres űrlap";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // rendezo
            // 
            this.rendezo.FormattingEnabled = true;
            this.rendezo.Location = new System.Drawing.Point(113, 206);
            this.rendezo.Name = "rendezo";
            this.rendezo.Size = new System.Drawing.Size(195, 21);
            this.rendezo.TabIndex = 17;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // frmFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rendezo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.szarmazasTextBox);
            this.Controls.Add(this.gyartevTextBox);
            this.Controls.Add(this.mufajTextBox);
            this.Controls.Add(this.hosszTextBox);
            this.Controls.Add(this.cimTextBox);
            this.Controls.Add(this.azonositoTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFilm";
            this.Text = "Film";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox azonositoTextBox;
        private System.Windows.Forms.TextBox cimTextBox;
        private System.Windows.Forms.TextBox hosszTextBox;
        private System.Windows.Forms.TextBox mufajTextBox;
        private System.Windows.Forms.TextBox gyartevTextBox;
        private System.Windows.Forms.TextBox szarmazasTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox rendezo;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}