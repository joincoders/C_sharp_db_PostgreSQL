namespace PRO_QR.Controls
{
    partial class Button_small
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Button_small));
            this.PanBox = new System.Windows.Forms.Panel();
            this._Pic = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // PanBox
            // 
            this.PanBox.BackColor = System.Drawing.Color.Transparent;
            this.PanBox.Controls.Add(this._Pic);
            this.PanBox.Location = new System.Drawing.Point(3, 8);
            this.PanBox.Name = "PanBox";
            this.PanBox.Size = new System.Drawing.Size(35, 35);
            this.PanBox.TabIndex = 7;
            this.PanBox.Click += new System.EventHandler(this.Items_Click);
            // 
            // _Pic
            // 
            this._Pic.Image = ((System.Drawing.Image)(resources.GetObject("_Pic.Image")));
            this._Pic.Location = new System.Drawing.Point(3, 3);
            this._Pic.Name = "_Pic";
            this._Pic.Size = new System.Drawing.Size(28, 28);
            this._Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._Pic.TabIndex = 1;
            this._Pic.TabStop = false;
            this._Pic.Click += new System.EventHandler(this.Items_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Khmer OS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(42, 25);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(57, 27);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Content";
            this.lblMessage.Click += new System.EventHandler(this.Items_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Khmer OS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(39, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(68, 27);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Full Name";
            this.lblTitle.Click += new System.EventHandler(this.Items_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Button_small
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.PanBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Button_small";
            this.Size = new System.Drawing.Size(170, 52);
            this.Load += new System.EventHandler(this.Lastiteam_Load);
            this.Click += new System.EventHandler(this.Items_Click);
            this.PanBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox _Pic;
        public System.Windows.Forms.Panel PanBox;
        public System.Windows.Forms.Label lblMessage;
        public System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
