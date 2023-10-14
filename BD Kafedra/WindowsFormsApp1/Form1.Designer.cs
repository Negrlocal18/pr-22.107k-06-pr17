namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label kODfakyl_tetaLabel;
            System.Windows.Forms.Label fIOdekanaLabel;
            System.Windows.Forms.Label nazvanirfakyl_tetaLabel;
            System.Windows.Forms.Label nomerkomnatidekanaLabel;
            System.Windows.Forms.Label telefondekanaLabel;
            this._22_107k_12__kafedra_DataSet = new WindowsFormsApp1._22_107k_12__kafedra_DataSet();
            this.fakul_tetiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fakul_tetiTableAdapter = new WindowsFormsApp1._22_107k_12__kafedra_DataSetTableAdapters.Fakul_tetiTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1._22_107k_12__kafedra_DataSetTableAdapters.TableAdapterManager();
            this.fakul_tetiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.fakul_tetiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kODfakyl_tetaTextBox = new System.Windows.Forms.TextBox();
            this.fIOdekanaTextBox = new System.Windows.Forms.TextBox();
            this.nazvanirfakyl_tetaTextBox = new System.Windows.Forms.TextBox();
            this.nomerkomnatidekanaTextBox = new System.Windows.Forms.TextBox();
            this.telefondekanaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            kODfakyl_tetaLabel = new System.Windows.Forms.Label();
            fIOdekanaLabel = new System.Windows.Forms.Label();
            nazvanirfakyl_tetaLabel = new System.Windows.Forms.Label();
            nomerkomnatidekanaLabel = new System.Windows.Forms.Label();
            telefondekanaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._22_107k_12__kafedra_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakul_tetiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakul_tetiBindingNavigator)).BeginInit();
            this.fakul_tetiBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // _22_107k_12__kafedra_DataSet
            // 
            this._22_107k_12__kafedra_DataSet.DataSetName = "_22_107k_12__kafedra_DataSet";
            this._22_107k_12__kafedra_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fakul_tetiBindingSource
            // 
            this.fakul_tetiBindingSource.DataMember = "Fakul\'teti";
            this.fakul_tetiBindingSource.DataSource = this._22_107k_12__kafedra_DataSet;
            // 
            // fakul_tetiTableAdapter
            // 
            this.fakul_tetiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DiscipliniTableAdapter = null;
            this.tableAdapterManager.Fakul_tetiTableAdapter = this.fakul_tetiTableAdapter;
            this.tableAdapterManager.GruppiTableAdapter = null;
            this.tableAdapterManager.KafedraTableAdapter = null;
            this.tableAdapterManager.PodchtablevedomostiTableAdapter = null;
            this.tableAdapterManager.PrepodiTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1._22_107k_12__kafedra_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VedomostiTableAdapter = null;
            // 
            // fakul_tetiBindingNavigator
            // 
            this.fakul_tetiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fakul_tetiBindingNavigator.BindingSource = this.fakul_tetiBindingSource;
            this.fakul_tetiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fakul_tetiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fakul_tetiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.fakul_tetiBindingNavigatorSaveItem});
            this.fakul_tetiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fakul_tetiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fakul_tetiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fakul_tetiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fakul_tetiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fakul_tetiBindingNavigator.Name = "fakul_tetiBindingNavigator";
            this.fakul_tetiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fakul_tetiBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.fakul_tetiBindingNavigator.TabIndex = 0;
            this.fakul_tetiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // fakul_tetiBindingNavigatorSaveItem
            // 
            this.fakul_tetiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fakul_tetiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fakul_tetiBindingNavigatorSaveItem.Image")));
            this.fakul_tetiBindingNavigatorSaveItem.Name = "fakul_tetiBindingNavigatorSaveItem";
            this.fakul_tetiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.fakul_tetiBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.fakul_tetiBindingNavigatorSaveItem.Click += new System.EventHandler(this.fakul_tetiBindingNavigatorSaveItem_Click);
            // 
            // kODfakyl_tetaLabel
            // 
            kODfakyl_tetaLabel.AutoSize = true;
            kODfakyl_tetaLabel.Location = new System.Drawing.Point(105, 87);
            kODfakyl_tetaLabel.Name = "kODfakyl_tetaLabel";
            kODfakyl_tetaLabel.Size = new System.Drawing.Size(93, 13);
            kODfakyl_tetaLabel.TabIndex = 1;
            kODfakyl_tetaLabel.Text = "КОДфакультета ";
            // 
            // kODfakyl_tetaTextBox
            // 
            this.kODfakyl_tetaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakul_tetiBindingSource, "KODfakyl\'teta", true));
            this.kODfakyl_tetaTextBox.Location = new System.Drawing.Point(204, 84);
            this.kODfakyl_tetaTextBox.Name = "kODfakyl_tetaTextBox";
            this.kODfakyl_tetaTextBox.Size = new System.Drawing.Size(100, 20);
            this.kODfakyl_tetaTextBox.TabIndex = 2;
            // 
            // fIOdekanaLabel
            // 
            fIOdekanaLabel.AutoSize = true;
            fIOdekanaLabel.Location = new System.Drawing.Point(164, 113);
            fIOdekanaLabel.Name = "fIOdekanaLabel";
            fIOdekanaLabel.Size = new System.Drawing.Size(34, 13);
            fIOdekanaLabel.TabIndex = 3;
            fIOdekanaLabel.Text = "ФИО";
            // 
            // fIOdekanaTextBox
            // 
            this.fIOdekanaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakul_tetiBindingSource, "FIOdekana", true));
            this.fIOdekanaTextBox.Location = new System.Drawing.Point(204, 110);
            this.fIOdekanaTextBox.Name = "fIOdekanaTextBox";
            this.fIOdekanaTextBox.Size = new System.Drawing.Size(100, 20);
            this.fIOdekanaTextBox.TabIndex = 4;
            // 
            // nazvanirfakyl_tetaLabel
            // 
            nazvanirfakyl_tetaLabel.AutoSize = true;
            nazvanirfakyl_tetaLabel.Location = new System.Drawing.Point(82, 191);
            nazvanirfakyl_tetaLabel.Name = "nazvanirfakyl_tetaLabel";
            nazvanirfakyl_tetaLabel.Size = new System.Drawing.Size(116, 13);
            nazvanirfakyl_tetaLabel.TabIndex = 5;
            nazvanirfakyl_tetaLabel.Text = "Названиефакультета";
            // 
            // nazvanirfakyl_tetaTextBox
            // 
            this.nazvanirfakyl_tetaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakul_tetiBindingSource, "Nazvanirfakyl\'teta", true));
            this.nazvanirfakyl_tetaTextBox.Location = new System.Drawing.Point(204, 188);
            this.nazvanirfakyl_tetaTextBox.Name = "nazvanirfakyl_tetaTextBox";
            this.nazvanirfakyl_tetaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazvanirfakyl_tetaTextBox.TabIndex = 6;
            // 
            // nomerkomnatidekanaLabel
            // 
            nomerkomnatidekanaLabel.AutoSize = true;
            nomerkomnatidekanaLabel.Location = new System.Drawing.Point(107, 165);
            nomerkomnatidekanaLabel.Name = "nomerkomnatidekanaLabel";
            nomerkomnatidekanaLabel.Size = new System.Drawing.Size(91, 13);
            nomerkomnatidekanaLabel.TabIndex = 7;
            nomerkomnatidekanaLabel.Text = "Номер кабинета";
            // 
            // nomerkomnatidekanaTextBox
            // 
            this.nomerkomnatidekanaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakul_tetiBindingSource, "Nomerkomnatidekana", true));
            this.nomerkomnatidekanaTextBox.Location = new System.Drawing.Point(204, 162);
            this.nomerkomnatidekanaTextBox.Name = "nomerkomnatidekanaTextBox";
            this.nomerkomnatidekanaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomerkomnatidekanaTextBox.TabIndex = 8;
            // 
            // telefondekanaLabel
            // 
            telefondekanaLabel.AutoSize = true;
            telefondekanaLabel.Location = new System.Drawing.Point(146, 139);
            telefondekanaLabel.Name = "telefondekanaLabel";
            telefondekanaLabel.Size = new System.Drawing.Size(52, 13);
            telefondekanaLabel.TabIndex = 9;
            telefondekanaLabel.Text = "Телефон";
            // 
            // telefondekanaTextBox
            // 
            this.telefondekanaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fakul_tetiBindingSource, "Telefondekana", true));
            this.telefondekanaTextBox.Location = new System.Drawing.Point(204, 136);
            this.telefondekanaTextBox.Name = "telefondekanaTextBox";
            this.telefondekanaTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefondekanaTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Следующая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 12;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(163, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 13;
            this.button3.Text = "Первая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(244, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 25);
            this.button4.TabIndex = 14;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(325, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 25);
            this.button5.TabIndex = 15;
            this.button5.Text = "Обновить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(406, 28);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 25);
            this.button6.TabIndex = 16;
            this.button6.Text = "Новая";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(487, 28);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 25);
            this.button7.TabIndex = 17;
            this.button7.Text = "Добавить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(568, 28);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 25);
            this.button8.TabIndex = 18;
            this.button8.Text = "Удалить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 415);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(115, 23);
            this.button9.TabIndex = 19;
            this.button9.Text = "Преподователи";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(telefondekanaLabel);
            this.Controls.Add(this.telefondekanaTextBox);
            this.Controls.Add(nomerkomnatidekanaLabel);
            this.Controls.Add(this.nomerkomnatidekanaTextBox);
            this.Controls.Add(nazvanirfakyl_tetaLabel);
            this.Controls.Add(this.nazvanirfakyl_tetaTextBox);
            this.Controls.Add(fIOdekanaLabel);
            this.Controls.Add(this.fIOdekanaTextBox);
            this.Controls.Add(kODfakyl_tetaLabel);
            this.Controls.Add(this.kODfakyl_tetaTextBox);
            this.Controls.Add(this.fakul_tetiBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._22_107k_12__kafedra_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakul_tetiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakul_tetiBindingNavigator)).EndInit();
            this.fakul_tetiBindingNavigator.ResumeLayout(false);
            this.fakul_tetiBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _22_107k_12__kafedra_DataSet _22_107k_12__kafedra_DataSet;
        private System.Windows.Forms.BindingSource fakul_tetiBindingSource;
        private _22_107k_12__kafedra_DataSetTableAdapters.Fakul_tetiTableAdapter fakul_tetiTableAdapter;
        private _22_107k_12__kafedra_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fakul_tetiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fakul_tetiBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox kODfakyl_tetaTextBox;
        private System.Windows.Forms.TextBox fIOdekanaTextBox;
        private System.Windows.Forms.TextBox nazvanirfakyl_tetaTextBox;
        private System.Windows.Forms.TextBox nomerkomnatidekanaTextBox;
        private System.Windows.Forms.TextBox telefondekanaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

