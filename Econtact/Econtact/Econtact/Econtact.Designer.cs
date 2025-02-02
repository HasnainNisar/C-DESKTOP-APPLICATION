namespace Econtact
{
    partial class Econtact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Econtact));
            this.pictureBox1logo = new System.Windows.Forms.PictureBox();
            this.lblContactID = new System.Windows.Forms.Label();
            this.txboxContactID = new System.Windows.Forms.TextBox();
            this.txtboxFirstname = new System.Windows.Forms.TextBox();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.txtboxLastname = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txtbocContactNO = new System.Windows.Forms.TextBox();
            this.lblcontactNO = new System.Windows.Forms.Label();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtboxSearch = new System.Windows.Forms.TextBox();
            this.pictboxExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1logo
            // 
            this.pictureBox1logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1logo.Image")));
            this.pictureBox1logo.Location = new System.Drawing.Point(346, 15);
            this.pictureBox1logo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1logo.Name = "pictureBox1logo";
            this.pictureBox1logo.Size = new System.Drawing.Size(231, 73);
            this.pictureBox1logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1logo.TabIndex = 0;
            this.pictureBox1logo.TabStop = false;
            // 
            // lblContactID
            // 
            this.lblContactID.AutoSize = true;
            this.lblContactID.BackColor = System.Drawing.Color.Transparent;
            this.lblContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactID.Location = new System.Drawing.Point(64, 129);
            this.lblContactID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactID.Name = "lblContactID";
            this.lblContactID.Size = new System.Drawing.Size(86, 20);
            this.lblContactID.TabIndex = 1;
            this.lblContactID.Text = "Contact ID";
            this.lblContactID.Click += new System.EventHandler(this.lblContactID_Click);
            // 
            // txboxContactID
            // 
            this.txboxContactID.Location = new System.Drawing.Point(192, 121);
            this.txboxContactID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txboxContactID.Name = "txboxContactID";
            this.txboxContactID.ReadOnly = true;
            this.txboxContactID.Size = new System.Drawing.Size(206, 28);
            this.txboxContactID.TabIndex = 2;
            this.txboxContactID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtboxFirstname
            // 
            this.txtboxFirstname.Location = new System.Drawing.Point(192, 171);
            this.txtboxFirstname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxFirstname.Name = "txtboxFirstname";
            this.txtboxFirstname.Size = new System.Drawing.Size(206, 28);
            this.txtboxFirstname.TabIndex = 4;
            this.txtboxFirstname.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.BackColor = System.Drawing.Color.Transparent;
            this.lblfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(64, 179);
            this.lblfirstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(86, 20);
            this.lblfirstname.TabIndex = 3;
            this.lblfirstname.Text = "First Name";
            this.lblfirstname.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtboxLastname
            // 
            this.txtboxLastname.Location = new System.Drawing.Point(192, 228);
            this.txtboxLastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxLastname.Name = "txtboxLastname";
            this.txtboxLastname.Size = new System.Drawing.Size(206, 28);
            this.txtboxLastname.TabIndex = 6;
            this.txtboxLastname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.BackColor = System.Drawing.Color.Transparent;
            this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(64, 234);
            this.lblLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(86, 20);
            this.lblLastname.TabIndex = 5;
            this.lblLastname.Text = "Last Name";
            this.lblLastname.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtbocContactNO
            // 
            this.txtbocContactNO.Location = new System.Drawing.Point(192, 275);
            this.txtbocContactNO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbocContactNO.Name = "txtbocContactNO";
            this.txtbocContactNO.Size = new System.Drawing.Size(206, 28);
            this.txtbocContactNO.TabIndex = 8;
            this.txtbocContactNO.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblcontactNO
            // 
            this.lblcontactNO.AutoSize = true;
            this.lblcontactNO.BackColor = System.Drawing.Color.Transparent;
            this.lblcontactNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontactNO.Location = new System.Drawing.Point(64, 283);
            this.lblcontactNO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcontactNO.Name = "lblcontactNO";
            this.lblcontactNO.Size = new System.Drawing.Size(89, 20);
            this.lblcontactNO.TabIndex = 7;
            this.lblcontactNO.Text = "Contact No";
            this.lblcontactNO.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Location = new System.Drawing.Point(192, 323);
            this.txtboxAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxAddress.Multiline = true;
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(206, 112);
            this.txtboxAddress.TabIndex = 10;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(64, 331);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(68, 20);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address";
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Sarfarz",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(192, 452);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(206, 28);
            this.cmbGender.TabIndex = 11;
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.comboxGender_SelectedIndexChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(64, 452);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 20);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(260, 494);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 45);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(392, 494);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 45);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(525, 494);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 45);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Orange;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(651, 494);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 45);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(441, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 300);
            this.dataGridView1.TabIndex = 17;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(436, 136);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(60, 20);
            this.lblSearch.TabIndex = 18;
            this.lblSearch.Text = "Search";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtboxSearch
            // 
            this.txtboxSearch.Location = new System.Drawing.Point(507, 132);
            this.txtboxSearch.Name = "txtboxSearch";
            this.txtboxSearch.Size = new System.Drawing.Size(384, 28);
            this.txtboxSearch.TabIndex = 19;
            // 
            // pictboxExit
            // 
            this.pictboxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictboxExit.Image")));
            this.pictboxExit.Location = new System.Drawing.Point(885, 12);
            this.pictboxExit.Name = "pictboxExit";
            this.pictboxExit.Size = new System.Drawing.Size(44, 30);
            this.pictboxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictboxExit.TabIndex = 20;
            this.pictboxExit.TabStop = false;
            // 
            // Econtact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 544);
            this.Controls.Add(this.pictboxExit);
            this.Controls.Add(this.txtboxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtbocContactNO);
            this.Controls.Add(this.lblcontactNO);
            this.Controls.Add(this.txtboxLastname);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.txtboxFirstname);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.txboxContactID);
            this.Controls.Add(this.lblContactID);
            this.Controls.Add(this.pictureBox1logo);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Econtact";
            this.Load += new System.EventHandler(this.Econtact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1logo;
        private System.Windows.Forms.Label lblContactID;
        private System.Windows.Forms.TextBox txboxContactID;
        private System.Windows.Forms.TextBox txtboxFirstname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.TextBox txtboxLastname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox txtbocContactNO;
        private System.Windows.Forms.Label lblcontactNO;
        private System.Windows.Forms.TextBox txtboxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtboxSearch;
        private System.Windows.Forms.PictureBox pictboxExit;
    }
}

