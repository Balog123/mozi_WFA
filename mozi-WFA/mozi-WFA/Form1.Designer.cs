﻿namespace mozi_WFA
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.moziButton = new System.Windows.Forms.Button();
            this.filmButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.valamiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // moziButton
            // 
            this.moziButton.Image = ((System.Drawing.Image)(resources.GetObject("moziButton.Image")));
            this.moziButton.Location = new System.Drawing.Point(43, 26);
            this.moziButton.Name = "moziButton";
            this.moziButton.Size = new System.Drawing.Size(82, 91);
            this.moziButton.TabIndex = 0;
            this.moziButton.Text = "Mozi";
            this.moziButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.moziButton.UseVisualStyleBackColor = true;
            // 
            // filmButton
            // 
            this.filmButton.ContextMenuStrip = this.contextMenuStrip1;
            this.filmButton.Image = ((System.Drawing.Image)(resources.GetObject("filmButton.Image")));
            this.filmButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filmButton.Location = new System.Drawing.Point(158, 26);
            this.filmButton.Name = "filmButton";
            this.filmButton.Size = new System.Drawing.Size(82, 91);
            this.filmButton.TabIndex = 1;
            this.filmButton.Text = "Film";
            this.filmButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.filmButton.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valamiToolStripMenuItem,
            this.keresToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // valamiToolStripMenuItem
            // 
            this.valamiToolStripMenuItem.Name = "valamiToolStripMenuItem";
            this.valamiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.valamiToolStripMenuItem.Text = "szerkezt";
            this.valamiToolStripMenuItem.Click += new System.EventHandler(this.valamiToolStripMenuItem_Click);
            // 
            // keresToolStripMenuItem
            // 
            this.keresToolStripMenuItem.Name = "keresToolStripMenuItem";
            this.keresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.keresToolStripMenuItem.Text = "keres";
            this.keresToolStripMenuItem.Click += new System.EventHandler(this.keresToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(282, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 91);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ember";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(408, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 91);
            this.button4.TabIndex = 3;
            this.button4.Text = "Kilép";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Típus:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 276);
            this.dataGridView1.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.filmButton);
            this.Controls.Add(this.moziButton);
            this.Name = "frmMain";
            this.Text = "Moziműsor";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button moziButton;
        private System.Windows.Forms.Button filmButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem valamiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keresToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
