
namespace AKARCAFE.DesktopUI.Ortak.GUI
{
    partial class frmgiris
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(314, 203);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "AKAR YAZILIM";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::AKARCAFE.DesktopUI.Properties.Resources.hide_16x16;
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(232, 83);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(25, 24);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(52, 81);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Size = new System.Drawing.Size(174, 26);
            this.textEdit2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(52, 53);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(205, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // frmgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 285);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmgiris";
            this.Text = "frmgiris";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}