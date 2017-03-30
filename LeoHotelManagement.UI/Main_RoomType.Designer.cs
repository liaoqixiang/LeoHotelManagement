namespace LeoHotelManagement.UI
{
    partial class Main_RoomType
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtroomtype = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.groupboxremark = new System.Windows.Forms.GroupBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.txtcancel = new System.Windows.Forms.Button();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Roomprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txteditremark = new System.Windows.Forms.TextBox();
            this.txteditprice = new System.Windows.Forms.TextBox();
            this.txtedittype = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstripadd = new System.Windows.Forms.ToolStripButton();
            this.toolStripEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupboxremark.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(915, 72);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 72);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 72);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 72);
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
            this.Roomprice,
            this.RoomRemark});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(915, 507);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtcancel);
            this.panel1.Controls.Add(this.btnsubmit);
            this.panel1.Controls.Add(this.groupboxremark);
            this.panel1.Controls.Add(this.txtprice);
            this.panel1.Controls.Add(this.txtroomtype);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(60, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 444);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Room Price";
            // 
            // txtroomtype
            // 
            this.txtroomtype.Location = new System.Drawing.Point(160, 54);
            this.txtroomtype.Name = "txtroomtype";
            this.txtroomtype.Size = new System.Drawing.Size(100, 22);
            this.txtroomtype.TabIndex = 1;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(160, 85);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 22);
            this.txtprice.TabIndex = 1;
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
            // groupboxremark
            // 
            this.groupboxremark.Controls.Add(this.txtRemark);
            this.groupboxremark.Location = new System.Drawing.Point(58, 122);
            this.groupboxremark.Name = "groupboxremark";
            this.groupboxremark.Size = new System.Drawing.Size(202, 181);
            this.groupboxremark.TabIndex = 2;
            this.groupboxremark.TabStop = false;
            this.groupboxremark.Text = "Remark";
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
            // RoomID
            // 
            this.RoomID.DataPropertyName = "rTypeId";
            this.RoomID.HeaderText = "RoomID";
            this.RoomID.Name = "RoomID";
            this.RoomID.ReadOnly = true;
            this.RoomID.Visible = false;
            // 
            // RoomType
            // 
            this.RoomType.DataPropertyName = "rTypeName";
            this.RoomType.HeaderText = "Room Type";
            this.RoomType.Name = "RoomType";
            this.RoomType.ReadOnly = true;
            // 
            // Roomprice
            // 
            this.Roomprice.DataPropertyName = "rTypePrice";
            this.Roomprice.HeaderText = "Room Price";
            this.Roomprice.Name = "Roomprice";
            this.Roomprice.ReadOnly = true;
            // 
            // RoomRemark
            // 
            this.RoomRemark.DataPropertyName = "rTypeRemark";
            this.RoomRemark.HeaderText = "Room Remark";
            this.RoomRemark.Name = "RoomRemark";
            this.RoomRemark.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btncancel);
            this.panel2.Controls.Add(this.btnedit);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.txteditprice);
            this.panel2.Controls.Add(this.txtedittype);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(516, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 444);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(185, 346);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.txteditcancel_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(58, 346);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 3;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txteditremark);
            this.groupBox1.Location = new System.Drawing.Point(58, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 181);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remark";
            // 
            // txteditremark
            // 
            this.txteditremark.AllowDrop = true;
            this.txteditremark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txteditremark.Location = new System.Drawing.Point(3, 18);
            this.txteditremark.Multiline = true;
            this.txteditremark.Name = "txteditremark";
            this.txteditremark.Size = new System.Drawing.Size(196, 160);
            this.txteditremark.TabIndex = 1;
            // 
            // txteditprice
            // 
            this.txteditprice.Location = new System.Drawing.Point(160, 85);
            this.txteditprice.Name = "txteditprice";
            this.txteditprice.Size = new System.Drawing.Size(100, 22);
            this.txteditprice.TabIndex = 1;
            // 
            // txtedittype
            // 
            this.txtedittype.Location = new System.Drawing.Point(160, 54);
            this.txtedittype.Name = "txtedittype";
            this.txtedittype.Size = new System.Drawing.Size(100, 22);
            this.txtedittype.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Room Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Room Type";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 72);
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
            // toolStripEdit
            // 
            this.toolStripEdit.Image = global::LeoHotelManagement.UI.Properties.Resources.updateHouse;
            this.toolStripEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEdit.Name = "toolStripEdit";
            this.toolStripEdit.Size = new System.Drawing.Size(59, 69);
            this.toolStripEdit.Text = "Edit";
            this.toolStripEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripEdit.Click += new System.EventHandler(this.toolStripEdit_Click);
            // 
            // toolStripDelete
            // 
            this.toolStripDelete.Image = global::LeoHotelManagement.UI.Properties.Resources.deleteHouse;
            this.toolStripDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDelete.Name = "toolStripDelete";
            this.toolStripDelete.Size = new System.Drawing.Size(61, 69);
            this.toolStripDelete.Text = "Delete";
            this.toolStripDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripDelete.Click += new System.EventHandler(this.toolStripDelete_Click);
            // 
            // toolStripExit
            // 
            this.toolStripExit.Image = global::LeoHotelManagement.UI.Properties.Resources.JiaoBan;
            this.toolStripExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(59, 69);
            this.toolStripExit.Text = "Exit";
            this.toolStripExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripExit.Click += new System.EventHandler(this.toolStripExit_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::LeoHotelManagement.UI.Properties.Resources.Trash_Recyclebin_Empty_Closed;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(59, 69);
            this.toolStripButton1.Text = "Bin";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Main_RoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Main_RoomType";
            this.Text = "Main_RoomType";
            this.Load += new System.EventHandler(this.Main_RoomType_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupboxremark.ResumeLayout(false);
            this.groupboxremark.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button txtcancel;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.GroupBox groupboxremark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtroomtype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Roomprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomRemark;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txteditremark;
        private System.Windows.Forms.TextBox txteditprice;
        private System.Windows.Forms.TextBox txtedittype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}