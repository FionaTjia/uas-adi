
namespace TA_KelompokFiona.Admin
{
    partial class AdminStudent
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
            this.lblNamaStu = new System.Windows.Forms.Label();
            this.txtbNamaStu = new System.Windows.Forms.TextBox();
            this.txtbHPStu = new System.Windows.Forms.TextBox();
            this.lblHpStu = new System.Windows.Forms.Label();
            this.txtbEmailStu = new System.Windows.Forms.TextBox();
            this.lblEmailStu = new System.Windows.Forms.Label();
            this.lblTopikStu = new System.Windows.Forms.Label();
            this.txtbPassStu = new System.Windows.Forms.TextBox();
            this.lblPassStu = new System.Windows.Forms.Label();
            this.adminSaveBtn = new System.Windows.Forms.Button();
            this.adminStudentPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joindateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tA_KelompokFionaDataSet1 = new TA_KelompokFiona.TA_KelompokFionaDataSet1();
            this.studentsTableAdapter = new TA_KelompokFiona.TA_KelompokFionaDataSet1TableAdapters.studentsTableAdapter();
            this.ctmStudentAdmin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCTIVEDEACTIVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editingLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.adminStudentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tA_KelompokFionaDataSet1)).BeginInit();
            this.ctmStudentAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNamaStu
            // 
            this.lblNamaStu.AutoSize = true;
            this.lblNamaStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaStu.Location = new System.Drawing.Point(13, 16);
            this.lblNamaStu.Name = "lblNamaStu";
            this.lblNamaStu.Size = new System.Drawing.Size(53, 20);
            this.lblNamaStu.TabIndex = 0;
            this.lblNamaStu.Text = "Nama";
            // 
            // txtbNamaStu
            // 
            this.txtbNamaStu.Location = new System.Drawing.Point(124, 16);
            this.txtbNamaStu.Name = "txtbNamaStu";
            this.txtbNamaStu.Size = new System.Drawing.Size(219, 22);
            this.txtbNamaStu.TabIndex = 2;
            // 
            // txtbHPStu
            // 
            this.txtbHPStu.Location = new System.Drawing.Point(124, 71);
            this.txtbHPStu.Name = "txtbHPStu";
            this.txtbHPStu.Size = new System.Drawing.Size(219, 22);
            this.txtbHPStu.TabIndex = 4;
            // 
            // lblHpStu
            // 
            this.lblHpStu.AutoSize = true;
            this.lblHpStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHpStu.Location = new System.Drawing.Point(13, 71);
            this.lblHpStu.Name = "lblHpStu";
            this.lblHpStu.Size = new System.Drawing.Size(92, 20);
            this.lblHpStu.TabIndex = 3;
            this.lblHpStu.Text = "Nomor HP.";
            // 
            // txtbEmailStu
            // 
            this.txtbEmailStu.Location = new System.Drawing.Point(124, 124);
            this.txtbEmailStu.Name = "txtbEmailStu";
            this.txtbEmailStu.Size = new System.Drawing.Size(219, 22);
            this.txtbEmailStu.TabIndex = 6;
            // 
            // lblEmailStu
            // 
            this.lblEmailStu.AutoSize = true;
            this.lblEmailStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailStu.Location = new System.Drawing.Point(13, 124);
            this.lblEmailStu.Name = "lblEmailStu";
            this.lblEmailStu.Size = new System.Drawing.Size(51, 20);
            this.lblEmailStu.TabIndex = 5;
            this.lblEmailStu.Text = "Email";
            // 
            // lblTopikStu
            // 
            this.lblTopikStu.AutoSize = true;
            this.lblTopikStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopikStu.Location = new System.Drawing.Point(400, 16);
            this.lblTopikStu.Name = "lblTopikStu";
            this.lblTopikStu.Size = new System.Drawing.Size(49, 20);
            this.lblTopikStu.TabIndex = 7;
            this.lblTopikStu.Text = "Topik";
            // 
            // txtbPassStu
            // 
            this.txtbPassStu.Location = new System.Drawing.Point(511, 69);
            this.txtbPassStu.Name = "txtbPassStu";
            this.txtbPassStu.Size = new System.Drawing.Size(219, 22);
            this.txtbPassStu.TabIndex = 10;
            // 
            // lblPassStu
            // 
            this.lblPassStu.AutoSize = true;
            this.lblPassStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassStu.Location = new System.Drawing.Point(400, 69);
            this.lblPassStu.Name = "lblPassStu";
            this.lblPassStu.Size = new System.Drawing.Size(83, 20);
            this.lblPassStu.TabIndex = 9;
            this.lblPassStu.Text = "Password";
            // 
            // adminSaveBtn
            // 
            this.adminSaveBtn.Location = new System.Drawing.Point(408, 124);
            this.adminSaveBtn.Name = "adminSaveBtn";
            this.adminSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.adminSaveBtn.TabIndex = 11;
            this.adminSaveBtn.Text = "SAVE";
            this.adminSaveBtn.UseVisualStyleBackColor = true;
            this.adminSaveBtn.Click += new System.EventHandler(this.adminSaveBtn_Click);
            // 
            // adminStudentPanel
            // 
            this.adminStudentPanel.Controls.Add(this.comboBox1);
            this.adminStudentPanel.Controls.Add(this.lblNamaStu);
            this.adminStudentPanel.Controls.Add(this.adminSaveBtn);
            this.adminStudentPanel.Controls.Add(this.txtbNamaStu);
            this.adminStudentPanel.Controls.Add(this.txtbPassStu);
            this.adminStudentPanel.Controls.Add(this.lblHpStu);
            this.adminStudentPanel.Controls.Add(this.lblPassStu);
            this.adminStudentPanel.Controls.Add(this.txtbHPStu);
            this.adminStudentPanel.Controls.Add(this.lblEmailStu);
            this.adminStudentPanel.Controls.Add(this.lblTopikStu);
            this.adminStudentPanel.Controls.Add(this.txtbEmailStu);
            this.adminStudentPanel.Location = new System.Drawing.Point(12, 271);
            this.adminStudentPanel.Name = "adminStudentPanel";
            this.adminStudentPanel.Size = new System.Drawing.Size(764, 167);
            this.adminStudentPanel.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentidDataGridViewTextBoxColumn,
            this.studentnameDataGridViewTextBoxColumn,
            this.studentemailDataGridViewTextBoxColumn,
            this.studentpasswordDataGridViewTextBoxColumn,
            this.studentphoneDataGridViewTextBoxColumn,
            this.topikDataGridViewTextBoxColumn,
            this.joindateDataGridViewTextBoxColumn,
            this.activeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 230);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "student_id";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "student_id";
            this.studentidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            this.studentidDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentidDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentnameDataGridViewTextBoxColumn
            // 
            this.studentnameDataGridViewTextBoxColumn.DataPropertyName = "student_name";
            this.studentnameDataGridViewTextBoxColumn.HeaderText = "student_name";
            this.studentnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentnameDataGridViewTextBoxColumn.Name = "studentnameDataGridViewTextBoxColumn";
            this.studentnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentemailDataGridViewTextBoxColumn
            // 
            this.studentemailDataGridViewTextBoxColumn.DataPropertyName = "student_email";
            this.studentemailDataGridViewTextBoxColumn.HeaderText = "student_email";
            this.studentemailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentemailDataGridViewTextBoxColumn.Name = "studentemailDataGridViewTextBoxColumn";
            this.studentemailDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentemailDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentpasswordDataGridViewTextBoxColumn
            // 
            this.studentpasswordDataGridViewTextBoxColumn.DataPropertyName = "student_password";
            this.studentpasswordDataGridViewTextBoxColumn.HeaderText = "student_password";
            this.studentpasswordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentpasswordDataGridViewTextBoxColumn.Name = "studentpasswordDataGridViewTextBoxColumn";
            this.studentpasswordDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentpasswordDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentphoneDataGridViewTextBoxColumn
            // 
            this.studentphoneDataGridViewTextBoxColumn.DataPropertyName = "student_phone";
            this.studentphoneDataGridViewTextBoxColumn.HeaderText = "student_phone";
            this.studentphoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentphoneDataGridViewTextBoxColumn.Name = "studentphoneDataGridViewTextBoxColumn";
            this.studentphoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentphoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // topikDataGridViewTextBoxColumn
            // 
            this.topikDataGridViewTextBoxColumn.DataPropertyName = "topik";
            this.topikDataGridViewTextBoxColumn.HeaderText = "topik";
            this.topikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.topikDataGridViewTextBoxColumn.Name = "topikDataGridViewTextBoxColumn";
            this.topikDataGridViewTextBoxColumn.ReadOnly = true;
            this.topikDataGridViewTextBoxColumn.Width = 125;
            // 
            // joindateDataGridViewTextBoxColumn
            // 
            this.joindateDataGridViewTextBoxColumn.DataPropertyName = "join_date";
            this.joindateDataGridViewTextBoxColumn.HeaderText = "join_date";
            this.joindateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.joindateDataGridViewTextBoxColumn.Name = "joindateDataGridViewTextBoxColumn";
            this.joindateDataGridViewTextBoxColumn.ReadOnly = true;
            this.joindateDataGridViewTextBoxColumn.Width = 125;
            // 
            // activeDataGridViewTextBoxColumn
            // 
            this.activeDataGridViewTextBoxColumn.DataPropertyName = "active";
            this.activeDataGridViewTextBoxColumn.HeaderText = "active";
            this.activeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.activeDataGridViewTextBoxColumn.Name = "activeDataGridViewTextBoxColumn";
            this.activeDataGridViewTextBoxColumn.ReadOnly = true;
            this.activeDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "students";
            this.studentsBindingSource.DataSource = this.tA_KelompokFionaDataSet1;
            // 
            // tA_KelompokFionaDataSet1
            // 
            this.tA_KelompokFionaDataSet1.DataSetName = "TA_KelompokFionaDataSet1";
            this.tA_KelompokFionaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // ctmStudentAdmin
            // 
            this.ctmStudentAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctmStudentAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dELETEToolStripMenuItem,
            this.eDITToolStripMenuItem,
            this.aCTIVEDEACTIVEToolStripMenuItem});
            this.ctmStudentAdmin.Name = "ctmStudentAdmin";
            this.ctmStudentAdmin.Size = new System.Drawing.Size(208, 76);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.eDITToolStripMenuItem.Text = "EDIT";
            this.eDITToolStripMenuItem.Click += new System.EventHandler(this.eDITToolStripMenuItem_Click);
            // 
            // aCTIVEDEACTIVEToolStripMenuItem
            // 
            this.aCTIVEDEACTIVEToolStripMenuItem.Name = "aCTIVEDEACTIVEToolStripMenuItem";
            this.aCTIVEDEACTIVEToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.aCTIVEDEACTIVEToolStripMenuItem.Text = "ACTIVE / DEACTIVE";
            this.aCTIVEDEACTIVEToolStripMenuItem.Click += new System.EventHandler(this.aCTIVEDEACTIVEToolStripMenuItem_Click);
            // 
            // editingLabel
            // 
            this.editingLabel.AutoSize = true;
            this.editingLabel.Location = new System.Drawing.Point(12, 248);
            this.editingLabel.Name = "editingLabel";
            this.editingLabel.Size = new System.Drawing.Size(46, 17);
            this.editingLabel.TabIndex = 14;
            this.editingLabel.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "python",
            "pengetahuan umum"});
            this.comboBox1.Location = new System.Drawing.Point(511, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // AdminStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editingLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.adminStudentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminStudent";
            this.Text = "AdminStudent";
            this.Load += new System.EventHandler(this.AdminStudent_Load);
            this.adminStudentPanel.ResumeLayout(false);
            this.adminStudentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tA_KelompokFionaDataSet1)).EndInit();
            this.ctmStudentAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamaStu;
        private System.Windows.Forms.TextBox txtbNamaStu;
        private System.Windows.Forms.TextBox txtbHPStu;
        private System.Windows.Forms.Label lblHpStu;
        private System.Windows.Forms.TextBox txtbEmailStu;
        private System.Windows.Forms.Label lblEmailStu;
        private System.Windows.Forms.Label lblTopikStu;
        private System.Windows.Forms.TextBox txtbPassStu;
        private System.Windows.Forms.Label lblPassStu;
        private System.Windows.Forms.Button adminSaveBtn;
        private System.Windows.Forms.Panel adminStudentPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TA_KelompokFionaDataSet1 tA_KelompokFionaDataSet1;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private TA_KelompokFionaDataSet1TableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentpasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn topikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joindateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip ctmStudentAdmin;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCTIVEDEACTIVEToolStripMenuItem;
        private System.Windows.Forms.Label editingLabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}