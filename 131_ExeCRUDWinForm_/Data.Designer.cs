
namespace _131_ExeCRUDWinForm_
{
    partial class Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.txphonenumber = new System.Windows.Forms.TextBox();
            this.txnamapegawai = new System.Windows.Forms.TextBox();
            this.phonenumber = new System.Windows.Forms.Label();
            this.namapegawai = new System.Windows.Forms.Label();
            this.txidpegawai = new System.Windows.Forms.TextBox();
            this.idpegawai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btadd = new System.Windows.Forms.Button();
            this.txalamat = new System.Windows.Forms.TextBox();
            this.alamat = new System.Windows.Forms.Label();
            this.txjeniskelamin = new System.Windows.Forms.TextBox();
            this.jk = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.caffeDataSet = new _131_ExeCRUDWinForm_.CaffeDataSet();
            this.datapegawaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datapegawaiTableAdapter = new _131_ExeCRUDWinForm_.CaffeDataSetTableAdapters.datapegawaiTableAdapter();
            this.datapegawaiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.datapegawaiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.datapegawaiBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.datapegawaiBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caffeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapegawaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapegawaiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapegawaiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapegawaiBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapegawaiBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.datapegawaiBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(704, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(515, 233);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(90, 40);
            this.btnsave.TabIndex = 85;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave2_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(515, 173);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(90, 40);
            this.btnupdate.TabIndex = 84;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(515, 290);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(90, 40);
            this.btndelete.TabIndex = 83;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txphonenumber
            // 
            this.txphonenumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datapegawaiBindingSource2, "nohp", true));
            this.txphonenumber.Location = new System.Drawing.Point(185, 197);
            this.txphonenumber.Margin = new System.Windows.Forms.Padding(2);
            this.txphonenumber.Name = "txphonenumber";
            this.txphonenumber.Size = new System.Drawing.Size(149, 20);
            this.txphonenumber.TabIndex = 72;
            // 
            // txnamapegawai
            // 
            this.txnamapegawai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datapegawaiBindingSource1, "name", true));
            this.txnamapegawai.Location = new System.Drawing.Point(185, 162);
            this.txnamapegawai.Margin = new System.Windows.Forms.Padding(2);
            this.txnamapegawai.Name = "txnamapegawai";
            this.txnamapegawai.Size = new System.Drawing.Size(149, 20);
            this.txnamapegawai.TabIndex = 70;
            // 
            // phonenumber
            // 
            this.phonenumber.AutoSize = true;
            this.phonenumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumber.ForeColor = System.Drawing.Color.Black;
            this.phonenumber.Location = new System.Drawing.Point(53, 202);
            this.phonenumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(91, 15);
            this.phonenumber.TabIndex = 66;
            this.phonenumber.Text = "Phone Number";
            // 
            // namapegawai
            // 
            this.namapegawai.AutoSize = true;
            this.namapegawai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.namapegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namapegawai.ForeColor = System.Drawing.Color.Black;
            this.namapegawai.Location = new System.Drawing.Point(53, 163);
            this.namapegawai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namapegawai.Name = "namapegawai";
            this.namapegawai.Size = new System.Drawing.Size(92, 15);
            this.namapegawai.TabIndex = 64;
            this.namapegawai.Text = "Nama Pegawai";
            // 
            // txidpegawai
            // 
            this.txidpegawai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datapegawaiBindingSource, "idpegawai", true));
            this.txidpegawai.Location = new System.Drawing.Point(185, 121);
            this.txidpegawai.Margin = new System.Windows.Forms.Padding(2);
            this.txidpegawai.Name = "txidpegawai";
            this.txidpegawai.Size = new System.Drawing.Size(149, 20);
            this.txidpegawai.TabIndex = 63;
            // 
            // idpegawai
            // 
            this.idpegawai.AutoSize = true;
            this.idpegawai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.idpegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idpegawai.ForeColor = System.Drawing.Color.Black;
            this.idpegawai.Location = new System.Drawing.Point(53, 124);
            this.idpegawai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idpegawai.Name = "idpegawai";
            this.idpegawai.Size = new System.Drawing.Size(70, 15);
            this.idpegawai.TabIndex = 62;
            this.idpegawai.Text = "ID Pegawai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 40);
            this.label1.TabIndex = 86;
            this.label1.Text = "INPUT PEGAWAI CAFFE-Q";
            // 
            // btadd
            // 
            this.btadd.BackColor = System.Drawing.Color.White;
            this.btadd.Location = new System.Drawing.Point(515, 112);
            this.btadd.Margin = new System.Windows.Forms.Padding(2);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(90, 40);
            this.btadd.TabIndex = 87;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = false;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // txalamat
            // 
            this.txalamat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datapegawaiBindingSource4, "alamat", true));
            this.txalamat.Location = new System.Drawing.Point(185, 274);
            this.txalamat.Margin = new System.Windows.Forms.Padding(2);
            this.txalamat.Name = "txalamat";
            this.txalamat.Size = new System.Drawing.Size(149, 20);
            this.txalamat.TabIndex = 92;
            // 
            // alamat
            // 
            this.alamat.AutoSize = true;
            this.alamat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.alamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat.ForeColor = System.Drawing.Color.Black;
            this.alamat.Location = new System.Drawing.Point(53, 275);
            this.alamat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(45, 15);
            this.alamat.TabIndex = 90;
            this.alamat.Text = "Alamat";
            // 
            // txjeniskelamin
            // 
            this.txjeniskelamin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.datapegawaiBindingSource3, "jk", true));
            this.txjeniskelamin.Location = new System.Drawing.Point(185, 233);
            this.txjeniskelamin.Margin = new System.Windows.Forms.Padding(2);
            this.txjeniskelamin.Name = "txjeniskelamin";
            this.txjeniskelamin.Size = new System.Drawing.Size(149, 20);
            this.txjeniskelamin.TabIndex = 89;
            // 
            // jk
            // 
            this.jk.AutoSize = true;
            this.jk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.jk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jk.ForeColor = System.Drawing.Color.Black;
            this.jk.Location = new System.Drawing.Point(53, 236);
            this.jk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.jk.Name = "jk";
            this.jk.Size = new System.Drawing.Size(85, 15);
            this.jk.TabIndex = 88;
            this.jk.Text = "Jenis Kelamin";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 341);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 93;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // caffeDataSet
            // 
            this.caffeDataSet.DataSetName = "CaffeDataSet";
            this.caffeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datapegawaiBindingSource
            // 
            this.datapegawaiBindingSource.DataMember = "datapegawai";
            this.datapegawaiBindingSource.DataSource = this.caffeDataSet;
            // 
            // datapegawaiTableAdapter
            // 
            this.datapegawaiTableAdapter.ClearBeforeFill = true;
            // 
            // datapegawaiBindingSource1
            // 
            this.datapegawaiBindingSource1.DataMember = "datapegawai";
            this.datapegawaiBindingSource1.DataSource = this.caffeDataSet;
            // 
            // datapegawaiBindingSource2
            // 
            this.datapegawaiBindingSource2.DataMember = "datapegawai";
            this.datapegawaiBindingSource2.DataSource = this.caffeDataSet;
            // 
            // datapegawaiBindingSource3
            // 
            this.datapegawaiBindingSource3.DataMember = "datapegawai";
            this.datapegawaiBindingSource3.DataSource = this.caffeDataSet;
            // 
            // datapegawaiBindingSource4
            // 
            this.datapegawaiBindingSource4.DataMember = "datapegawai";
            this.datapegawaiBindingSource4.DataSource = this.caffeDataSet;
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(704, 385);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txalamat);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.txjeniskelamin);
            this.Controls.Add(this.jk);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txphonenumber);
            this.Controls.Add(this.txnamapegawai);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.namapegawai);
            this.Controls.Add(this.txidpegawai);
            this.Controls.Add(this.idpegawai);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "Data";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caffeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapegawaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapegawaiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapegawaiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapegawaiBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datapegawaiBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txphonenumber;
        private System.Windows.Forms.TextBox txnamapegawai;
        private System.Windows.Forms.Label phonenumber;
        private System.Windows.Forms.Label namapegawai;
        private System.Windows.Forms.TextBox txidpegawai;
        private System.Windows.Forms.Label idpegawai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.TextBox txalamat;
        private System.Windows.Forms.Label alamat;
        private System.Windows.Forms.TextBox txjeniskelamin;
        private System.Windows.Forms.Label jk;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CaffeDataSet caffeDataSet;
        private System.Windows.Forms.BindingSource datapegawaiBindingSource;
        private CaffeDataSetTableAdapters.datapegawaiTableAdapter datapegawaiTableAdapter;
        private System.Windows.Forms.BindingSource datapegawaiBindingSource2;
        private System.Windows.Forms.BindingSource datapegawaiBindingSource1;
        private System.Windows.Forms.BindingSource datapegawaiBindingSource4;
        private System.Windows.Forms.BindingSource datapegawaiBindingSource3;
    }
}