namespace Phonebook
{
    partial class GeneralListForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phonebookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generalTable = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearbornDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generalListBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.generalListFormBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.generalListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generalListFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generalListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.peopleListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalListBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalListFormBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalListFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1206, 24);
            this.menuStrip1.TabIndex = 0;
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
            // generalTable
            // 
            this.generalTable.AllowUserToAddRows = false;
            this.generalTable.AllowUserToDeleteRows = false;
            this.generalTable.AllowUserToOrderColumns = true;
            this.generalTable.AllowUserToResizeColumns = false;
            this.generalTable.AllowUserToResizeRows = false;
            this.generalTable.AutoGenerateColumns = false;
            this.generalTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.generalTable.BackgroundColor = System.Drawing.Color.White;
            this.generalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generalTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.yearbornDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.phoneTypeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.generalTable.DataSource = this.generalListBindingSource2;
            this.generalTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalTable.Location = new System.Drawing.Point(0, 24);
            this.generalTable.MultiSelect = false;
            this.generalTable.Name = "generalTable";
            this.generalTable.ReadOnly = true;
            this.generalTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.generalTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.generalTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.generalTable.Size = new System.Drawing.Size(1206, 510);
            this.generalTable.TabIndex = 6;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearbornDataGridViewTextBoxColumn
            // 
            this.yearbornDataGridViewTextBoxColumn.DataPropertyName = "Yearborn";
            this.yearbornDataGridViewTextBoxColumn.HeaderText = "Год рождения";
            this.yearbornDataGridViewTextBoxColumn.Name = "yearbornDataGridViewTextBoxColumn";
            this.yearbornDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn2.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // phoneTypeDataGridViewTextBoxColumn
            // 
            this.phoneTypeDataGridViewTextBoxColumn.DataPropertyName = "PhoneType";
            this.phoneTypeDataGridViewTextBoxColumn.HeaderText = "Тип телефона";
            this.phoneTypeDataGridViewTextBoxColumn.Name = "phoneTypeDataGridViewTextBoxColumn";
            this.phoneTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // generalListBindingSource2
            // 
            this.generalListBindingSource2.DataMember = "GeneralList";
            this.generalListBindingSource2.DataSource = this.generalListFormBindingSource1;
            // 
            // generalListFormBindingSource1
            // 
            this.generalListFormBindingSource1.DataSource = typeof(Phonebook.GeneralListForm);
            // 
            // generalListBindingSource
            // 
            this.generalListBindingSource.DataMember = "GeneralList";
            this.generalListBindingSource.DataSource = this.generalListFormBindingSource;
            // 
            // generalListFormBindingSource
            // 
            this.generalListFormBindingSource.DataSource = typeof(Phonebook.GeneralListForm);
            // 
            // generalListBindingSource1
            // 
            this.generalListBindingSource1.DataMember = "GeneralList";
            this.generalListBindingSource1.DataSource = this.generalListFormBindingSource;
            // 
            // peopleListBindingSource
            // 
            this.peopleListBindingSource.DataSource = typeof(Phonebook.PeopleGeneralInfo);
            // 
            // GeneralListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 534);
            this.Controls.Add(this.generalTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GeneralListForm";
            this.Text = "Телефонный справочник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralListForm_FormClosing);
            this.Load += new System.EventHandler(this.GeneralListForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalListBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalListFormBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalListFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.BindingSource phonebookBindingSource;
        private System.Windows.Forms.BindingSource peopleListBindingSource;
        private System.Windows.Forms.DataGridView generalTable;
        private System.Windows.Forms.BindingSource generalListBindingSource;
        private System.Windows.Forms.BindingSource generalListFormBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn peopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource generalListBindingSource1;
        private System.Windows.Forms.BindingSource generalListBindingSource2;
        private System.Windows.Forms.BindingSource generalListFormBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearbornDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}

