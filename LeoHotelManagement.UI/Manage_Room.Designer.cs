namespace LeoHotelManagement.UI
{
    partial class Manage_Room
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolstripadd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtcancel = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.groupboxremark = new System.Windows.Forms.GroupBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboroomtype = new System.Windows.Forms.ComboBox();
            this.comboroomstatus = new System.Windows.Forms.ComboBox();
            this.combofloor = new System.Windows.Forms.ComboBox();
            this.txtroomnum = new System.Windows.Forms.TextBox();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomfloor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupboxremark.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(55, 45);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripadd,
            this.toolStripSeparator1,
            this.toolStripEdit,
            this.toolStripSeparator2,
            this.toolStripDelete,
            this.toolStripSeparator3,
            this.toolStripExit,
            this.toolStripSeparator4,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1049, 72);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolstripadd
            // 
            this.toolstripadd.Image = global::LeoHotelManagement.UI.Properties.Resources.SetaddHouse;
            this.toolstripadd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripadd.Name = "toolstripadd";
            this.toolstripadd.Size = new System.Drawing.Size(59, 69);
            this.toolstripadd.Text = "Add";
            this.toolstripadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolstripadd.Click += new System.EventHandler(this.toolstripadd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 72);
            // 
            // toolStripEdit
            // 
            this.toolStripEdit.Image = global::LeoHotelManagement.UI.Properties.Resources.updateHouse;
            this.toolStripEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEdit.Name = "toolStripEdit";
            this.toolStripEdit.Size = new System.Drawing.Size(59, 69);
            this.toolStripEdit.Text = "Edit";
            this.toolStripEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 72);
            // 
            // toolStripDelete
            // 
            this.toolStripDelete.Image = global::LeoHotelManagement.UI.Properties.Resources.deleteHouse;
            this.toolStripDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDelete.Name = "toolStripDelete";
            this.toolStripDelete.Size = new System.Drawing.Size(61, 69);
            this.toolStripDelete.Text = "Delete";
            this.toolStripDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 72);
            // 
            // toolStripExit
            // 
            this.toolStripExit.Image = global::LeoHotelManagement.UI.Properties.Resources.JiaoBan;
            this.toolStripExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(59, 69);
            this.toolStripExit.Text = "Exit";
            this.toolStripExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 72);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::LeoHotelManagement.UI.Properties.Resources.Trash_Recyclebin_Empty_Closed;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(59, 69);
            this.toolStripButton1.Text = "Bin";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomID,
            this.RoomType,
            this.RoomStatus,
            this.roomfloor,
            this.RoomRemark});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 566);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.combofloor);
            this.panel1.Controls.Add(this.comboroomstatus);
            this.panel1.Controls.Add(this.comboroomtype);
            this.panel1.Controls.Add(this.txtcancel);
            this.panel1.Controls.Add(this.btnsubmit);
            this.panel1.Controls.Add(this.groupboxremark);
            this.panel1.Controls.Add(this.txtroomnum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(302, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 444);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // txtcancel
            // 
            this.txtcancel.Location = new System.Drawing.Point(185, 346);
            this.txtcancel.Name = "txtcancel";
            this.txtcancel.Size = new System.Drawing.Size(75, 23);
            this.txtcancel.TabIndex = 3;
            this.txtcancel.Text = "Cancel";
            this.txtcancel.UseVisualStyleBackColor = true;
            this.txtcancel.Click += new System.EventHandler(this.txtcancel_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(58, 346);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 3;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // groupboxremark
            // 
            this.groupboxremark.Controls.Add(this.txtRemark);
            this.groupboxremark.Location = new System.Drawing.Point(58, 159);
            this.groupboxremark.Name = "groupboxremark";
            this.groupboxremark.Size = new System.Drawing.Size(202, 181);
            this.groupboxremark.TabIndex = 2;
            this.groupboxremark.TabStop = false;
            this.groupboxremark.Text = "Remark";
            // 
            // txtRemark
            // 
            this.txtRemark.AllowDrop = true;
            this.txtRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRemark.Location = new System.Drawing.Point(3, 18);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(196, 160);
            this.txtRemark.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Room Floor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Room Num";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Room Status";
            // 
            // comboroomtype
            // 
            this.comboroomtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboroomtype.FormattingEnabled = true;
            this.comboroomtype.Location = new System.Drawing.Point(160, 46);
            this.comboroomtype.Name = "comboroomtype";
            this.comboroomtype.Size = new System.Drawing.Size(121, 24);
            this.comboroomtype.TabIndex = 4;
            // 
            // comboroomstatus
            // 
            this.comboroomstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboroomstatus.FormattingEnabled = true;
            this.comboroomstatus.Items.AddRange(new object[] {
            "Vancancy",
            "Occuplied",
            "cleaning"});
            this.comboroomstatus.Location = new System.Drawing.Point(160, 87);
            this.comboroomstatus.Name = "comboroomstatus";
            this.comboroomstatus.Size = new System.Drawing.Size(121, 24);
            this.comboroomstatus.TabIndex = 4;
            // 
            // combofloor
            // 
            this.combofloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combofloor.FormattingEnabled = true;
            this.combofloor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.combofloor.Location = new System.Drawing.Point(160, 128);
            this.combofloor.Name = "combofloor";
            this.combofloor.Size = new System.Drawing.Size(121, 24);
            this.combofloor.TabIndex = 5;
            // 
            // txtroomnum
            // 
            this.txtroomnum.Location = new System.Drawing.Point(160, 12);
            this.txtroomnum.Name = "txtroomnum";
            this.txtroomnum.Size = new System.Drawing.Size(121, 22);
            this.txtroomnum.TabIndex = 1;
            // 
            // RoomID
            // 
            this.RoomID.DataPropertyName = "roomId";
            this.RoomID.HeaderText = "Room Num";
            this.RoomID.Name = "RoomID";
            this.RoomID.ReadOnly = true;
            // 
            // RoomType
            // 
            this.RoomType.HeaderText = "Room Type";
            this.RoomType.Name = "RoomType";
            this.RoomType.ReadOnly = true;
            // 
            // RoomStatus
            // 
            this.RoomStatus.HeaderText = "Room Status";
            this.RoomStatus.Name = "RoomStatus";
            this.RoomStatus.ReadOnly = true;
            // 
            // roomfloor
            // 
            this.roomfloor.DataPropertyName = "roomFloor";
            this.roomfloor.HeaderText = "Room Floor";
            this.roomfloor.Name = "roomfloor";
            this.roomfloor.ReadOnly = true;
            // 
            // RoomRemark
            // 
            this.RoomRemark.DataPropertyName = "roomRemark";
            this.RoomRemark.HeaderText = "Room Remark";
            this.RoomRemark.Name = "RoomRemark";
            this.RoomRemark.ReadOnly = true;
            // 
            // Manage_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 638);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Manage_Room";
            this.Text = "Manage_Room";
            this.Load += new System.EventHandler(this.Manage_Room_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupboxremark.ResumeLayout(false);
            this.groupboxremark.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolstripadd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboroomstatus;
        private System.Windows.Forms.ComboBox comboroomtype;
        private System.Windows.Forms.Button txtcancel;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.GroupBox groupboxremark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combofloor;
        private System.Windows.Forms.TextBox txtroomnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomfloor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomRemark;
    }
}