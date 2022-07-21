namespace Phonebook
{
    partial class AddressListForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressTable = new System.Windows.Forms.DataGridView();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressListFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChoiceButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressListFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(352, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.EditToolStripMenuItem.Text = "Редактировать";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // addressTable
            // 
            this.addressTable.AllowUserToAddRows = false;
            this.addressTable.AllowUserToDeleteRows = false;
            this.addressTable.AllowUserToResizeColumns = false;
            this.addressTable.AllowUserToResizeRows = false;
            this.addressTable.AutoGenerateColumns = false;
            this.addressTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addressTable.BackgroundColor = System.Drawing.Color.White;
            this.addressTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addressTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.streetDataGridViewTextBoxColumn,
            this.houseDataGridViewTextBoxColumn,
            this.apartmentDataGridViewTextBoxColumn});
            this.addressTable.DataSource = this.addressListBindingSource;
            this.addressTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.addressTable.Location = new System.Drawing.Point(0, 24);
            this.addressTable.MultiSelect = false;
            this.addressTable.Name = "addressTable";
            this.addressTable.ReadOnly = true;
            this.addressTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.addressTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.addressTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addressTable.Size = new System.Drawing.Size(352, 251);
            this.addressTable.TabIndex = 5;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // houseDataGridViewTextBoxColumn
            // 
            this.houseDataGridViewTextBoxColumn.DataPropertyName = "House";
            this.houseDataGridViewTextBoxColumn.HeaderText = "Дом";
            this.houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
            this.houseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apartmentDataGridViewTextBoxColumn
            // 
            this.apartmentDataGridViewTextBoxColumn.DataPropertyName = "Apartment";
            this.apartmentDataGridViewTextBoxColumn.HeaderText = "Квартира";
            this.apartmentDataGridViewTextBoxColumn.Name = "apartmentDataGridViewTextBoxColumn";
            this.apartmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressListBindingSource
            // 
            this.addressListBindingSource.DataMember = "AddressList";
            this.addressListBindingSource.DataSource = this.addressListFormBindingSource;
            // 
            // addressListFormBindingSource
            // 
            this.addressListFormBindingSource.DataSource = typeof(Phonebook.AddressListForm);
            // 
            // ChoiceButton
            // 
            this.ChoiceButton.Location = new System.Drawing.Point(85, 287);
            this.ChoiceButton.Name = "ChoiceButton";
            this.ChoiceButton.Size = new System.Drawing.Size(180, 25);
            this.ChoiceButton.TabIndex = 6;
            this.ChoiceButton.Text = "Выбрать";
            this.ChoiceButton.UseVisualStyleBackColor = true;
            this.ChoiceButton.Click += new System.EventHandler(this.ChoiceButton_Click);
            // 
            // AddressListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 324);
            this.Controls.Add(this.ChoiceButton);
            this.Controls.Add(this.addressTable);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AddressListForm";
            this.Text = "Список адрессов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddressListForm_FormClosing);
            this.Load += new System.EventHandler(this.AddressListForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addressTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressListFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.DataGridView addressTable;
        private System.Windows.Forms.BindingSource addressListFormBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource addressListBindingSource;
        private System.Windows.Forms.Button ChoiceButton;
    }
}