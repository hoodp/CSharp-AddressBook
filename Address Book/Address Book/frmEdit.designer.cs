namespace Address_Book
{
    partial class frmEdit
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
            this.grpIdentity = new System.Windows.Forms.GroupBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grpPhoto = new System.Windows.Forms.GroupBox();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnImage = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.grpIdentity.SuspendLayout();
            this.grpPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // grpIdentity
            // 
            this.grpIdentity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpIdentity.Controls.Add(this.lblCity);
            this.grpIdentity.Controls.Add(this.txtZip);
            this.grpIdentity.Controls.Add(this.txtState);
            this.grpIdentity.Controls.Add(this.txtCity);
            this.grpIdentity.Controls.Add(this.txtStreet);
            this.grpIdentity.Controls.Add(this.lblAddress);
            this.grpIdentity.Controls.Add(this.txtName);
            this.grpIdentity.Controls.Add(this.lblName);
            this.grpIdentity.ForeColor = System.Drawing.Color.Black;
            this.grpIdentity.Location = new System.Drawing.Point(12, 12);
            this.grpIdentity.Name = "grpIdentity";
            this.grpIdentity.Size = new System.Drawing.Size(458, 140);
            this.grpIdentity.TabIndex = 0;
            this.grpIdentity.TabStop = false;
            this.grpIdentity.Text = "Identity";
            // 
            // txtZip
            // 
            this.txtZip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZip.Location = new System.Drawing.Point(354, 100);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(98, 20);
            this.txtZip.TabIndex = 6;
            // 
            // txtState
            // 
            this.txtState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtState.Location = new System.Drawing.Point(313, 100);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(35, 20);
            this.txtState.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCity.Location = new System.Drawing.Point(86, 100);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(221, 20);
            this.txtCity.TabIndex = 4;
            // 
            // txtStreet
            // 
            this.txtStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStreet.Location = new System.Drawing.Point(86, 66);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(366, 20);
            this.txtStreet.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 69);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(86, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(366, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // grpPhoto
            // 
            this.grpPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPhoto.Controls.Add(this.picPhoto);
            this.grpPhoto.ForeColor = System.Drawing.Color.Black;
            this.grpPhoto.Location = new System.Drawing.Point(12, 158);
            this.grpPhoto.Name = "grpPhoto";
            this.grpPhoto.Size = new System.Drawing.Size(458, 244);
            this.grpPhoto.TabIndex = 1;
            this.grpPhoto.TabStop = false;
            this.grpPhoto.Text = "Photograph";
            // 
            // picPhoto
            // 
            this.picPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picPhoto.Location = new System.Drawing.Point(6, 27);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(446, 211);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPhoto.TabIndex = 0;
            this.picPhoto.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(395, 420);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(314, 420);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImage
            // 
            this.btnImage.ForeColor = System.Drawing.Color.Black;
            this.btnImage.Location = new System.Drawing.Point(12, 420);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(75, 23);
            this.btnImage.TabIndex = 7;
            this.btnImage.Text = "&Photo";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 100);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "City:";
            // 
            // frmEdit
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(482, 455);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpPhoto);
            this.Controls.Add(this.grpIdentity);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(499, 494);
            this.MinimumSize = new System.Drawing.Size(497, 492);
            this.Name = "frmEdit";
            this.Text = "Contact Info Editor";
            this.grpIdentity.ResumeLayout(false);
            this.grpIdentity.PerformLayout();
            this.grpPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIdentity;
        private System.Windows.Forms.GroupBox grpPhoto;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Label lblCity;
    }
}

