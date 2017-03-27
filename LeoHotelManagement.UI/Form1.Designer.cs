namespace LeoHotelManagement.UI
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
            this.showroom = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFemale = new System.Windows.Forms.RadioButton();
            this.txtMale = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtremark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phonelabel = new System.Windows.Forms.Label();
            this.txtcustomerid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtfemaleedit = new System.Windows.Forms.RadioButton();
            this.txtmaleedit = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.txtremarkedit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtphoneedit = new System.Windows.Forms.TextBox();
            this.txtnameedit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDnumedit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showroom)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // showroom
            // 
            this.showroom.AllowUserToAddRows = false;
            this.showroom.AllowUserToDeleteRows = false;
            this.showroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showroom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cName,
            this.cGender,
            this.cIdType,
            this.cPhone,
            this.cRemark,
            this.cId});
            this.showroom.Location = new System.Drawing.Point(28, 55);
            this.showroom.Name = "showroom";
            this.showroom.ReadOnly = true;
            this.showroom.RowHeadersVisible = false;
            this.showroom.RowTemplate.Height = 24;
            this.showroom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showroom.Size = new System.Drawing.Size(822, 287);
            this.showroom.TabIndex = 0;
            this.showroom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showroom_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFemale);
            this.groupBox1.Controls.Add(this.txtMale);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtremark);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtphone);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.phonelabel);
            this.groupBox1.Controls.Add(this.txtcustomerid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Location = new System.Drawing.Point(21, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // txtFemale
            // 
            this.txtFemale.AutoSize = true;
            this.txtFemale.Location = new System.Drawing.Point(308, 28);
            this.txtFemale.Name = "txtFemale";
            this.txtFemale.Size = new System.Drawing.Size(75, 21);
            this.txtFemale.TabIndex = 5;
            this.txtFemale.TabStop = true;
            this.txtFemale.Text = "Female";
            this.txtFemale.UseVisualStyleBackColor = true;
            // 
            // txtMale
            // 
            this.txtMale.AutoSize = true;
            this.txtMale.Location = new System.Drawing.Point(243, 28);
            this.txtMale.Name = "txtMale";
            this.txtMale.Size = new System.Drawing.Size(59, 21);
            this.txtMale.TabIndex = 5;
            this.txtMale.TabStop = true;
            this.txtMale.Text = "Male";
            this.txtMale.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtremark
            // 
            this.txtremark.Location = new System.Drawing.Point(840, 32);
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(100, 22);
            this.txtremark.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(635, 29);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(100, 22);
            this.txtphone.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(58, 27);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(788, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Remark";
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.Location = new System.Drawing.Point(580, 30);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(49, 17);
            this.phonelabel.TabIndex = 2;
            this.phonelabel.Text = "Phone";
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.Location = new System.Drawing.Point(430, 28);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.Size = new System.Drawing.Size(100, 22);
            this.txtcustomerid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gender";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(403, 32);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(21, 17);
            this.id.TabIndex = 2;
            this.id.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtfemaleedit);
            this.groupBox2.Controls.Add(this.txtmaleedit);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtremarkedit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtphoneedit);
            this.groupBox2.Controls.Add(this.txtnameedit);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtIDnumedit);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(21, 499);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(946, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit";
            // 
            // txtfemaleedit
            // 
            this.txtfemaleedit.AutoSize = true;
            this.txtfemaleedit.Location = new System.Drawing.Point(308, 28);
            this.txtfemaleedit.Name = "txtfemaleedit";
            this.txtfemaleedit.Size = new System.Drawing.Size(75, 21);
            this.txtfemaleedit.TabIndex = 5;
            this.txtfemaleedit.TabStop = true;
            this.txtfemaleedit.Text = "Female";
            this.txtfemaleedit.UseVisualStyleBackColor = true;
            // 
            // txtmaleedit
            // 
            this.txtmaleedit.AutoSize = true;
            this.txtmaleedit.Location = new System.Drawing.Point(243, 28);
            this.txtmaleedit.Name = "txtmaleedit";
            this.txtmaleedit.Size = new System.Drawing.Size(59, 21);
            this.txtmaleedit.TabIndex = 5;
            this.txtmaleedit.TabStop = true;
            this.txtmaleedit.Text = "Male";
            this.txtmaleedit.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtremarkedit
            // 
            this.txtremarkedit.Location = new System.Drawing.Point(840, 32);
            this.txtremarkedit.Name = "txtremarkedit";
            this.txtremarkedit.Size = new System.Drawing.Size(100, 22);
            this.txtremarkedit.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // txtphoneedit
            // 
            this.txtphoneedit.Location = new System.Drawing.Point(635, 29);
            this.txtphoneedit.Name = "txtphoneedit";
            this.txtphoneedit.Size = new System.Drawing.Size(100, 22);
            this.txtphoneedit.TabIndex = 3;
            // 
            // txtnameedit
            // 
            this.txtnameedit.Location = new System.Drawing.Point(58, 27);
            this.txtnameedit.Name = "txtnameedit";
            this.txtnameedit.Size = new System.Drawing.Size(100, 22);
            this.txtnameedit.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(788, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Remark";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(580, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Phone";
            // 
            // txtIDnumedit
            // 
            this.txtIDnumedit.Location = new System.Drawing.Point(430, 28);
            this.txtIDnumedit.Name = "txtIDnumedit";
            this.txtIDnumedit.Size = new System.Drawing.Size(100, 22);
            this.txtIDnumedit.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "ID";
            // 
            // cName
            // 
            this.cName.DataPropertyName = "cName";
            this.cName.HeaderText = "Name";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cGender
            // 
            this.cGender.HeaderText = "Gender";
            this.cGender.Name = "cGender";
            this.cGender.ReadOnly = true;
            // 
            // cIdType
            // 
            this.cIdType.DataPropertyName = "cIdNo";
            this.cIdType.HeaderText = "Customer ID";
            this.cIdType.Name = "cIdType";
            this.cIdType.ReadOnly = true;
            this.cIdType.Width = 125;
            // 
            // cPhone
            // 
            this.cPhone.DataPropertyName = "cPhone";
            this.cPhone.HeaderText = "Phone";
            this.cPhone.Name = "cPhone";
            this.cPhone.ReadOnly = true;
            // 
            // cRemark
            // 
            this.cRemark.DataPropertyName = "cRemark";
            this.cRemark.HeaderText = "Remark";
            this.cRemark.Name = "cRemark";
            this.cRemark.ReadOnly = true;
            // 
            // cId
            // 
            this.cId.DataPropertyName = "CustomerId";
            this.cId.HeaderText = "cID";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Visible = false;
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(906, 111);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 2;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 670);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showroom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showroom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView showroom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtremark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.TextBox txtcustomerid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton txtFemale;
        private System.Windows.Forms.RadioButton txtMale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton txtfemaleedit;
        private System.Windows.Forms.RadioButton txtmaleedit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtremarkedit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtphoneedit;
        private System.Windows.Forms.TextBox txtnameedit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDnumedit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.Button deletebtn;
    }
}

