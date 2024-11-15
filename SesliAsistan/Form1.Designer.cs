namespace SesliAsistan
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
            this.components = new System.ComponentModel.Container();
            this.Mic2 = new System.Windows.Forms.PictureBox();
            this.Mic1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.konuşToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçeneklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Komutlartxt = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Mic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mic1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mic2
            // 
            this.Mic2.Image = global::SesliAsistan.Properties.Resources.voice_search;
            this.Mic2.Location = new System.Drawing.Point(12, 31);
            this.Mic2.Name = "Mic2";
            this.Mic2.Size = new System.Drawing.Size(366, 374);
            this.Mic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mic2.TabIndex = 0;
            this.Mic2.TabStop = false;
            this.Mic2.Click += new System.EventHandler(this.Mic2_Click);
            // 
            // Mic1
            // 
            this.Mic1.Image = global::SesliAsistan.Properties.Resources.microphone;
            this.Mic1.Location = new System.Drawing.Point(12, 31);
            this.Mic1.Name = "Mic1";
            this.Mic1.Size = new System.Drawing.Size(366, 374);
            this.Mic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mic1.TabIndex = 0;
            this.Mic1.TabStop = false;
            this.Mic1.Click += new System.EventHandler(this.Mic1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konuşToolStripMenuItem,
            this.seçeneklerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(393, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // konuşToolStripMenuItem
            // 
            this.konuşToolStripMenuItem.Name = "konuşToolStripMenuItem";
            this.konuşToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.konuşToolStripMenuItem.Text = "Konuş";
            this.konuşToolStripMenuItem.Click += new System.EventHandler(this.konuşToolStripMenuItem_Click);
            // 
            // seçeneklerToolStripMenuItem
            // 
            this.seçeneklerToolStripMenuItem.Name = "seçeneklerToolStripMenuItem";
            this.seçeneklerToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.seçeneklerToolStripMenuItem.Text = "Seçenekler";
            this.seçeneklerToolStripMenuItem.Click += new System.EventHandler(this.seçeneklerToolStripMenuItem_Click);
            // 
            // Komutlartxt
            // 
            this.Komutlartxt.AutoSize = true;
            this.Komutlartxt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Komutlartxt.Location = new System.Drawing.Point(135, 49);
            this.Komutlartxt.Name = "Komutlartxt";
            this.Komutlartxt.Size = new System.Drawing.Size(115, 25);
            this.Komutlartxt.TabIndex = 2;
            this.Komutlartxt.Text = "Komutlar";
            this.Komutlartxt.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(366, 372);
            this.listBox1.TabIndex = 3;
            this.listBox1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 420);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Komutlartxt);
            this.Controls.Add(this.Mic1);
            this.Controls.Add(this.Mic2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sesli Asistan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mic1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Mic1;
        private System.Windows.Forms.PictureBox Mic2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem konuşToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçeneklerToolStripMenuItem;
        private System.Windows.Forms.Label Komutlartxt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

