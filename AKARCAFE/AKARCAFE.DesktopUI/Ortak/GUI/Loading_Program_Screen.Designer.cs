
namespace AKARCAFE.DesktopUI.Ortak.GUI
{
    partial class Loading_Program_Screen
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.Caption = "Yükleniyor";
            this.progressPanel1.Description = "Lütfen Bekleyiniz";
            this.progressPanel1.Location = new System.Drawing.Point(542, 372);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(246, 66);
            this.progressPanel1.TabIndex = 0;
            this.progressPanel1.Text = "progressPanel1";
            this.progressPanel1.Click += new System.EventHandler(this.progressPanel1_Click);
            // 
            // Loading_Program_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressPanel1);
            this.Name = "Loading_Program_Screen";
            this.Text = "Loading_Program_Screen";
            this.Load += new System.EventHandler(this.Loading_Program_Screen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
    }
}