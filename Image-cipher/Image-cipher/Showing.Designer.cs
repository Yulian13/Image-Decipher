namespace Image_cipher
{
    partial class Showing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Showing));
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.Console = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOriginalDeshifrovka = new System.Windows.Forms.ToolStripButton();
            this.ButtonZoomNormal = new System.Windows.Forms.ToolStripButton();
            this.LabelProgress = new System.Windows.Forms.ToolStripLabel();
            this.ProgressBarProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.LabelTest = new System.Windows.Forms.ToolStripLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LabelView = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBarView = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            ((System.ComponentModel.ISupportInitialize)(this.Console)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBack.Location = new System.Drawing.Point(0, 0);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(30, 550);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "<--";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonForward.Location = new System.Drawing.Point(890, 0);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(30, 550);
            this.buttonForward.TabIndex = 1;
            this.buttonForward.Text = "-->";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // Console
            // 
            this.Console.Location = new System.Drawing.Point(3, 3);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(859, 486);
            this.Console.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Console.TabIndex = 2;
            this.Console.TabStop = false;
            this.Console.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Watching_MouseClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOriginalDeshifrovka,
            this.ButtonZoomNormal,
            this.LabelProgress,
            this.ProgressBarProgress,
            this.LabelTest,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(30, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(860, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonOriginalDeshifrovka
            // 
            this.toolStripButtonOriginalDeshifrovka.AutoSize = false;
            this.toolStripButtonOriginalDeshifrovka.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonOriginalDeshifrovka.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOriginalDeshifrovka.Name = "toolStripButtonOriginalDeshifrovka";
            this.toolStripButtonOriginalDeshifrovka.Size = new System.Drawing.Size(73, 22);
            this.toolStripButtonOriginalDeshifrovka.Text = "Original";
            this.toolStripButtonOriginalDeshifrovka.Click += new System.EventHandler(this.toolStripButtonOriginalDeshifrovka_Click);
            // 
            // ButtonZoomNormal
            // 
            this.ButtonZoomNormal.AutoSize = false;
            this.ButtonZoomNormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ButtonZoomNormal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonZoomNormal.Name = "ButtonZoomNormal";
            this.ButtonZoomNormal.Size = new System.Drawing.Size(51, 22);
            this.ButtonZoomNormal.Text = "Zoom";
            this.ButtonZoomNormal.Click += new System.EventHandler(this.ButtonZoomNormal_Click);
            // 
            // LabelProgress
            // 
            this.LabelProgress.Name = "LabelProgress";
            this.LabelProgress.Size = new System.Drawing.Size(41, 22);
            this.LabelProgress.Text = "Label2";
            // 
            // ProgressBarProgress
            // 
            this.ProgressBarProgress.Name = "ProgressBarProgress";
            this.ProgressBarProgress.Size = new System.Drawing.Size(200, 22);
            // 
            // LabelTest
            // 
            this.LabelTest.Name = "LabelTest";
            this.LabelTest.Size = new System.Drawing.Size(41, 22);
            this.LabelTest.Text = "Label1";
            this.LabelTest.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.Console);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(30, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 525);
            this.panel1.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelView,
            this.ProgressBarView});
            this.statusStrip1.Location = new System.Drawing.Point(30, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(860, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LabelView
            // 
            this.LabelView.Margin = new System.Windows.Forms.Padding(350, 3, 0, 2);
            this.LabelView.Name = "LabelView";
            this.LabelView.Size = new System.Drawing.Size(86, 17);
            this.LabelView.Text = "LabelProgress1";
            // 
            // ProgressBarView
            // 
            this.ProgressBarView.Name = "ProgressBarView";
            this.ProgressBarView.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(66, 22);
            this.toolStripSplitButton1.Text = "Console";
            // 
            // Showing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 550);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonBack);
            this.Name = "Showing";
            this.Text = "Watching";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Watching_FormClosing);
            this.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Console)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.PictureBox Console;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonOriginalDeshifrovka;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripLabel LabelProgress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripProgressBar ProgressBarProgress;
        private System.Windows.Forms.ToolStripButton ButtonZoomNormal;
        private System.Windows.Forms.ToolStripLabel LabelTest;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LabelView;
        private System.Windows.Forms.ToolStripProgressBar ProgressBarView;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
    }
}