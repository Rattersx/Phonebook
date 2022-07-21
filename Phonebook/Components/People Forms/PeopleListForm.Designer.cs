namespace Phonebook
{
    partial class PeopleListForm
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
            this.peopleListTable = new System.Windows.Forms.DataGridView();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bornyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleListBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.peopleListFormBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.peopleListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleListFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.peopleListTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleListBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleListFormBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleListFormBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleListBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // peopleListTable
            // 
            this.peopleListTable.AllowUserToAddRows = false;
            this.peopleListTable.AllowUserToDeleteRows = false;
            this.peopleListTable.AllowUserToOrderColumns = true;
            this.peopleListTable.AllowUserToResizeColumns = false;
            this.peopleListTable.AllowUserToResizeRows = false;
            this.peopleListTable.AutoGenerateColumns = false;
            this.peopleListTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.peopleListTable.BackgroundColor = System.Drawing.Color.White;
            this.peopleListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peopleListTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.bornyearDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.peopleListTable.DataSource = this.peopleListBindingSource2;
            this.peopleListTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peopleListTable.Location = new System.Drawing.Point(0, 24);
            this.peopleListTable.MultiSelect = false;
            this.peopleListTable.Name = "peopleListTable";
            this.peopleListTable.ReadOnly = true;
            this.peopleListTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.peopleListTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.peopleListTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.peopleListTable.Size = new System.Drawing.Size(652, 244);
            this.peopleListTable.TabIndex = 2;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bornyearDataGridViewTextBoxColumn
            // 
            this.bornyearDataGridViewTextBoxColumn.DataPropertyName = "Bornyear";
            this.bornyearDataGridViewTextBoxColumn.HeaderText = "Год рождения";
            this.bornyearDataGridViewTextBoxColumn.Name = "bornyearDataGridViewTextBoxColumn";
            this.bornyearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peopleListBindingSource2
            // 
            this.peopleListBindingSource2.DataMember = "PeopleList";
            this.peopleListBindingSource2.DataSource = this.peopleListFormBindingSource1;
            // 
            // peopleListFormBindingSource1
            // 
            this.peopleListFormBindingSource1.DataSource = typeof(Phonebook.PeopleListForm);
            // 
            // peopleListBindingSource
            // 
            this.peopleListBindingSource.DataMember = "PeopleList";
            this.peopleListBindingSource.DataSource = this.peopleListFormBindingSource;
            // 
            // peopleListFormBindingSource
            // 
            this.peopleListFormBindingSource.DataSource = typeof(Phonebook.PeopleListForm);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // peopleListBindingSource1
            // 
            this.peopleListBindingSource1.DataMember = "PeopleList";
            this.peopleListBindingSource1.DataSource = this.peopleListFormBindingSource;
            // 
            // PeopleListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 268);
            this.Controls.Add(this.peopleListTable);
            this.Controls.Add(this.menuStrip1);
            this.Name = "PeopleListForm";
            this.Text = "PeopleListForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PeopleListForm_FormClosing);
            this.Load += new System.EventHandler(this.PeopleListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peopleListTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleListBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleListFormBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleListFormBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleListBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView peopleListTable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.BindingSource peopleListBindingSource;
        private System.Windows.Forms.BindingSource peopleListFormBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bornyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource peopleListBindingSource2;
        private System.Windows.Forms.BindingSource peopleListFormBindingSource1;
        private System.Windows.Forms.BindingSource peopleListBindingSource1;
    }
}