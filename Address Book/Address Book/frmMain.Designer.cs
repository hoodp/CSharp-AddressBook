namespace Address_Book
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lsvNames = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(123, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(229, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Address Book";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(380, 310);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(93, 310);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(18, 310);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(168, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lsvNames
            // 
            this.lsvNames.BackColor = System.Drawing.SystemColors.Window;
            this.lsvNames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmAddress});
            this.lsvNames.FullRowSelect = true;
            this.lsvNames.Location = new System.Drawing.Point(18, 61);
            this.lsvNames.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.lsvNames.Name = "lsvNames";
            this.lsvNames.Size = new System.Drawing.Size(437, 226);
            this.lsvNames.TabIndex = 6;
            this.lsvNames.UseCompatibleStateImageBehavior = false;
            this.lsvNames.View = System.Windows.Forms.View.Details;
            this.lsvNames.DoubleClick += new System.EventHandler(this.btnEdit_Click);
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            this.clmName.Width = 147;
            // 
            // clmAddress
            // 
            this.clmAddress.Text = "Address";
            this.clmAddress.Width = 286;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(390, 290);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(65, 13);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "00/00/0000";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(15, 290);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 13);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "00:00 PM";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 345);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lsvNames);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(491, 383);
            this.MinimumSize = new System.Drawing.Size(489, 382);
            this.Name = "frmMain";
            this.Text = "Address Book";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView lsvNames;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmAddress;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
    }
}

