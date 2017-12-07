using System;

namespace GoruntuIsleme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Dosya = new System.Windows.Forms.ToolStripSplitButton();
            this.acMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.griYapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NegatifMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DondurMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.olceklendirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aynalamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkKanallariMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(488, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 320);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Dosya,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(820, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Dosya
            // 
            this.Dosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acMenuItem,
            this.kaydetMenuItem});
            this.Dosya.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Dosya.Name = "Dosya";
            this.Dosya.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.Dosya.Size = new System.Drawing.Size(55, 22);
            this.Dosya.Text = "Dosya";
            this.Dosya.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // acMenuItem
            // 
            this.acMenuItem.Name = "acMenuItem";
            this.acMenuItem.Size = new System.Drawing.Size(152, 22);
            this.acMenuItem.Text = "Aç";
            this.acMenuItem.Click += new System.EventHandler(this.acMenuItem_Click);
            // 
            // kaydetMenuItem
            // 
            this.kaydetMenuItem.Name = "kaydetMenuItem";
            this.kaydetMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kaydetMenuItem.Text = "Kaydet";
            this.kaydetMenuItem.Click += new System.EventHandler(this.kaydetMenuItem_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.griYapMenuItem,
            this.histogramMenuItem,
            this.NegatifMenuItem,
            this.DondurMenuItem,
            this.olceklendirMenuItem,
            this.aynalamaToolStripMenuItem,
            this.renkKanallariMenuItem});
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(65, 22);
            this.toolStripSplitButton1.Text = "Düzenle";
            // 
            // griYapMenuItem
            // 
            this.griYapMenuItem.Name = "griYapMenuItem";
            this.griYapMenuItem.Size = new System.Drawing.Size(152, 22);
            this.griYapMenuItem.Text = "Gri yap";
            this.griYapMenuItem.Click += new System.EventHandler(this.griYapMenuItem_Click);
            // 
            // histogramMenuItem
            // 
            this.histogramMenuItem.Name = "histogramMenuItem";
            this.histogramMenuItem.Size = new System.Drawing.Size(152, 22);
            this.histogramMenuItem.Text = "Histogram";
            this.histogramMenuItem.Click += new System.EventHandler(this.histogramMenuItem_Click);
            // 
            // NegatifMenuItem
            // 
            this.NegatifMenuItem.Name = "NegatifMenuItem";
            this.NegatifMenuItem.Size = new System.Drawing.Size(152, 22);
            this.NegatifMenuItem.Text = "NegatifYap";
            this.NegatifMenuItem.Click += new System.EventHandler(this.NegatifMenuItem_Click);
            // 
            // DondurMenuItem
            // 
            this.DondurMenuItem.Name = "DondurMenuItem";
            this.DondurMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DondurMenuItem.Text = "Döndür";
            this.DondurMenuItem.Click += new System.EventHandler(this.DondurMenuItem_Click);
            // 
            // olceklendirMenuItem
            // 
            this.olceklendirMenuItem.Name = "olceklendirMenuItem";
            this.olceklendirMenuItem.Size = new System.Drawing.Size(152, 22);
            this.olceklendirMenuItem.Text = "Ölçeklendir";
            this.olceklendirMenuItem.Click += new System.EventHandler(this.olceklendirMenuItem_Click);
            // 
            // aynalamaToolStripMenuItem
            // 
            this.aynalamaToolStripMenuItem.Name = "aynalamaToolStripMenuItem";
            this.aynalamaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aynalamaToolStripMenuItem.Text = "Aynalama";
            this.aynalamaToolStripMenuItem.Click += new System.EventHandler(this.aynalamaToolStripMenuItem_Click);
            // 
            // renkKanallariMenuItem
            // 
            this.renkKanallariMenuItem.Name = "renkKanallariMenuItem";
            this.renkKanallariMenuItem.Size = new System.Drawing.Size(152, 22);
            this.renkKanallariMenuItem.Text = "Renk Kanalları";
            this.renkKanallariMenuItem.Click += new System.EventHandler(this.renkKanallariMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 417);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private EventHandler pictureBox1_Click;
        private EventHandler pictureBox2_Click;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton Dosya;
        private System.Windows.Forms.ToolStripMenuItem acMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem griYapMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NegatifMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DondurMenuItem;
        private System.Windows.Forms.ToolStripMenuItem olceklendirMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aynalamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkKanallariMenuItem;
    }
}

