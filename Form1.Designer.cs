namespace Biblioteka
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idчитачDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.картаЧитачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пІБDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.читачіBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotekaDataSet = new Biblioteka.bibliotekaDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.читачіЗапросBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.читачіTableAdapter = new Biblioteka.bibliotekaDataSetTableAdapters.ЧитачіTableAdapter();
            this.читачі_ЗапросTableAdapter = new Biblioteka.bibliotekaDataSetTableAdapters.Читачі_ЗапросTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.видачаTableAdapter1 = new Biblioteka.bibliotekaDataSetTableAdapters.ВидачаTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗаписьОВыдачеКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.idкнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.шифрКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.назваКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авторDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idчитачDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.картаЧитачаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пІБDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВидачіDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПоверненняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаФактичногоПоверненняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_vidachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.читачіBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.читачіЗапросBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idчитачDataGridViewTextBoxColumn,
            this.картаЧитачаDataGridViewTextBoxColumn,
            this.пІБDataGridViewTextBoxColumn,
            this.адресаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.читачіBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 45);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(539, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click_1);
            // 
            // idчитачDataGridViewTextBoxColumn
            // 
            this.idчитачDataGridViewTextBoxColumn.DataPropertyName = "id_читач";
            this.idчитачDataGridViewTextBoxColumn.HeaderText = "id_читач";
            this.idчитачDataGridViewTextBoxColumn.Name = "idчитачDataGridViewTextBoxColumn";
            this.idчитачDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // картаЧитачаDataGridViewTextBoxColumn
            // 
            this.картаЧитачаDataGridViewTextBoxColumn.DataPropertyName = "Карта читача";
            this.картаЧитачаDataGridViewTextBoxColumn.HeaderText = "Карта читача";
            this.картаЧитачаDataGridViewTextBoxColumn.Name = "картаЧитачаDataGridViewTextBoxColumn";
            this.картаЧитачаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // пІБDataGridViewTextBoxColumn
            // 
            this.пІБDataGridViewTextBoxColumn.DataPropertyName = "ПІБ";
            this.пІБDataGridViewTextBoxColumn.HeaderText = "ПІБ";
            this.пІБDataGridViewTextBoxColumn.Name = "пІБDataGridViewTextBoxColumn";
            this.пІБDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // адресаDataGridViewTextBoxColumn
            // 
            this.адресаDataGridViewTextBoxColumn.DataPropertyName = "Адреса";
            this.адресаDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.адресаDataGridViewTextBoxColumn.Name = "адресаDataGridViewTextBoxColumn";
            this.адресаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // читачіBindingSource
            // 
            this.читачіBindingSource.DataMember = "Читачі";
            this.читачіBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // bibliotekaDataSet
            // 
            this.bibliotekaDataSet.DataSetName = "bibliotekaDataSet";
            this.bibliotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idкнигиDataGridViewTextBoxColumn,
            this.шифрКнигиDataGridViewTextBoxColumn,
            this.назваКнигиDataGridViewTextBoxColumn,
            this.авторDataGridViewTextBoxColumn,
            this.idчитачDataGridViewTextBoxColumn1,
            this.картаЧитачаDataGridViewTextBoxColumn1,
            this.пІБDataGridViewTextBoxColumn1,
            this.датаВидачіDataGridViewTextBoxColumn,
            this.датаПоверненняDataGridViewTextBoxColumn,
            this.датаФактичногоПоверненняDataGridViewTextBoxColumn,
            this.id_vidachi});
            this.dataGridView2.DataSource = this.читачіЗапросBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(23, 218);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(950, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // читачіЗапросBindingSource
            // 
            this.читачіЗапросBindingSource.DataMember = "Читачі Запрос";
            this.читачіЗапросBindingSource.DataSource = this.bibliotekaDataSet;
            this.читачіЗапросBindingSource.CurrentChanged += new System.EventHandler(this.читачіЗапросBindingSource_CurrentChanged);
            // 
            // читачіTableAdapter
            // 
            this.читачіTableAdapter.ClearBeforeFill = true;
            // 
            // читачі_ЗапросTableAdapter
            // 
            this.читачі_ЗапросTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(395, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавление";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // видачаTableAdapter1
            // 
            this.видачаTableAdapter1.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактированиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(995, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьЗаписьОВыдачеКнигиToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить запись о выдаче книги";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьЗаписьОВыдачеКнигиToolStripMenuItem
            // 
            this.удалитьЗаписьОВыдачеКнигиToolStripMenuItem.Name = "удалитьЗаписьОВыдачеКнигиToolStripMenuItem";
            this.удалитьЗаписьОВыдачеКнигиToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.удалитьЗаписьОВыдачеКнигиToolStripMenuItem.Text = "Удалить запись о выдаче книги";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Удалить запись";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // idкнигиDataGridViewTextBoxColumn
            // 
            this.idкнигиDataGridViewTextBoxColumn.DataPropertyName = "id_книги";
            this.idкнигиDataGridViewTextBoxColumn.HeaderText = "id_книги";
            this.idкнигиDataGridViewTextBoxColumn.Name = "idкнигиDataGridViewTextBoxColumn";
            this.idкнигиDataGridViewTextBoxColumn.Visible = false;
            // 
            // шифрКнигиDataGridViewTextBoxColumn
            // 
            this.шифрКнигиDataGridViewTextBoxColumn.DataPropertyName = "Шифр книги";
            this.шифрКнигиDataGridViewTextBoxColumn.HeaderText = "Шифр книги";
            this.шифрКнигиDataGridViewTextBoxColumn.Name = "шифрКнигиDataGridViewTextBoxColumn";
            // 
            // назваКнигиDataGridViewTextBoxColumn
            // 
            this.назваКнигиDataGridViewTextBoxColumn.DataPropertyName = "Назва книги";
            this.назваКнигиDataGridViewTextBoxColumn.HeaderText = "Назва книги";
            this.назваКнигиDataGridViewTextBoxColumn.Name = "назваКнигиDataGridViewTextBoxColumn";
            // 
            // авторDataGridViewTextBoxColumn
            // 
            this.авторDataGridViewTextBoxColumn.DataPropertyName = "Автор";
            this.авторDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.авторDataGridViewTextBoxColumn.Name = "авторDataGridViewTextBoxColumn";
            // 
            // idчитачDataGridViewTextBoxColumn1
            // 
            this.idчитачDataGridViewTextBoxColumn1.DataPropertyName = "id_читач";
            this.idчитачDataGridViewTextBoxColumn1.HeaderText = "id_читач";
            this.idчитачDataGridViewTextBoxColumn1.Name = "idчитачDataGridViewTextBoxColumn1";
            this.idчитачDataGridViewTextBoxColumn1.Visible = false;
            // 
            // картаЧитачаDataGridViewTextBoxColumn1
            // 
            this.картаЧитачаDataGridViewTextBoxColumn1.DataPropertyName = "Карта читача";
            this.картаЧитачаDataGridViewTextBoxColumn1.HeaderText = "Карта читача";
            this.картаЧитачаDataGridViewTextBoxColumn1.Name = "картаЧитачаDataGridViewTextBoxColumn1";
            // 
            // пІБDataGridViewTextBoxColumn1
            // 
            this.пІБDataGridViewTextBoxColumn1.DataPropertyName = "ПІБ";
            this.пІБDataGridViewTextBoxColumn1.HeaderText = "ПІБ";
            this.пІБDataGridViewTextBoxColumn1.Name = "пІБDataGridViewTextBoxColumn1";
            // 
            // датаВидачіDataGridViewTextBoxColumn
            // 
            this.датаВидачіDataGridViewTextBoxColumn.DataPropertyName = "Дата видачі";
            this.датаВидачіDataGridViewTextBoxColumn.HeaderText = "Дата видачі";
            this.датаВидачіDataGridViewTextBoxColumn.Name = "датаВидачіDataGridViewTextBoxColumn";
            // 
            // датаПоверненняDataGridViewTextBoxColumn
            // 
            this.датаПоверненняDataGridViewTextBoxColumn.DataPropertyName = "Дата повернення";
            this.датаПоверненняDataGridViewTextBoxColumn.HeaderText = "Дата повернення";
            this.датаПоверненняDataGridViewTextBoxColumn.Name = "датаПоверненняDataGridViewTextBoxColumn";
            // 
            // датаФактичногоПоверненняDataGridViewTextBoxColumn
            // 
            this.датаФактичногоПоверненняDataGridViewTextBoxColumn.DataPropertyName = "Дата фактичного повернення";
            this.датаФактичногоПоверненняDataGridViewTextBoxColumn.HeaderText = "Дата фактичного повернення";
            this.датаФактичногоПоверненняDataGridViewTextBoxColumn.Name = "датаФактичногоПоверненняDataGridViewTextBoxColumn";
            // 
            // id_vidachi
            // 
            this.id_vidachi.DataPropertyName = "id_vidachi";
            this.id_vidachi.HeaderText = "id_vidachi";
            this.id_vidachi.Name = "id_vidachi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 408);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.читачіBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.читачіЗапросBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bibliotekaDataSet bibliotekaDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource читачіBindingSource;
        private bibliotekaDataSetTableAdapters.ЧитачіTableAdapter читачіTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idчитачDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn картаЧитачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пІБDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource читачіЗапросBindingSource;
        private bibliotekaDataSetTableAdapters.Читачі_ЗапросTableAdapter читачі_ЗапросTableAdapter;
        private System.Windows.Forms.Button button1;
        private bibliotekaDataSetTableAdapters.ВидачаTableAdapter видачаTableAdapter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаписьОВыдачеКнигиToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idкнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn шифрКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn авторDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idчитачDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn картаЧитачаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn пІБDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВидачіDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПоверненняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаФактичногоПоверненняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vidachi;
    }
}

