namespace MyWinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.UserIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserImageCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.UserNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserEmailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPhoneCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblPAgeNumber = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(686, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 43);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIdCol,
            this.UserImageCol,
            this.UserNameCol,
            this.UserEmailCol,
            this.UserPhoneCol});
            this.dgvUsers.Location = new System.Drawing.Point(12, 67);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowTemplate.Height = 25;
            this.dgvUsers.Size = new System.Drawing.Size(776, 256);
            this.dgvUsers.TabIndex = 1;
            // 
            // UserIdCol
            // 
            this.UserIdCol.HeaderText = "Id";
            this.UserIdCol.Name = "UserIdCol";
            this.UserIdCol.ReadOnly = true;
            this.UserIdCol.Visible = false;
            // 
            // UserImageCol
            // 
            this.UserImageCol.HeaderText = "Фото";
            this.UserImageCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.UserImageCol.MinimumWidth = 25;
            this.UserImageCol.Name = "UserImageCol";
            this.UserImageCol.ReadOnly = true;
            // 
            // UserNameCol
            // 
            this.UserNameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserNameCol.HeaderText = "ПІБ";
            this.UserNameCol.Name = "UserNameCol";
            this.UserNameCol.ReadOnly = true;
            // 
            // UserEmailCol
            // 
            this.UserEmailCol.HeaderText = "Пошта";
            this.UserEmailCol.Name = "UserEmailCol";
            this.UserEmailCol.ReadOnly = true;
            this.UserEmailCol.Width = 150;
            // 
            // UserPhoneCol
            // 
            this.UserPhoneCol.HeaderText = "Телефон";
            this.UserPhoneCol.Name = "UserPhoneCol";
            this.UserPhoneCol.ReadOnly = true;
            this.UserPhoneCol.Width = 150;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(578, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 43);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(713, 329);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(12, 329);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "<<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblPAgeNumber
            // 
            this.lblPAgeNumber.AutoSize = true;
            this.lblPAgeNumber.Location = new System.Drawing.Point(397, 337);
            this.lblPAgeNumber.Name = "lblPAgeNumber";
            this.lblPAgeNumber.Size = new System.Drawing.Size(24, 15);
            this.lblPAgeNumber.TabIndex = 4;
            this.lblPAgeNumber.Text = "1/1";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(470, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 43);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Змінити";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(368, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 43);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblPAgeNumber);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnSearch);
            this.Name = "MainForm";
            this.Text = "Головне вікно";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSearch;
        private DataGridView dgvUsers;
        private Button btnAdd;
        private DataGridViewTextBoxColumn UserIdCol;
        private DataGridViewImageColumn UserImageCol;
        private DataGridViewTextBoxColumn UserNameCol;
        private DataGridViewTextBoxColumn UserEmailCol;
        private DataGridViewTextBoxColumn UserPhoneCol;
        private Button btnNext;
        private Button btnPrev;
        private Label lblPAgeNumber;
        private Button btnEdit;
        private Button btnDelete;
    }
}