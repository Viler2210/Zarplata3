namespace Zarplata3
{
    partial class FormCoefficient
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
            System.Windows.Forms.Label id_CoefficientLabel;
            System.Windows.Forms.Label juniorLabel;
            System.Windows.Forms.Label middleLabel;
            System.Windows.Forms.Label seniorLabel;
            System.Windows.Forms.Label k_A_PLabel;
            System.Windows.Forms.Label k_U_OLabel;
            System.Windows.Forms.Label k_T_O_CLabel;
            System.Windows.Forms.Label k_VLabel;
            System.Windows.Forms.Label k_CLabel;
            System.Windows.Forms.Label k_P_D_ELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCoefficient));
            this.zarplata2DataSet = new Zarplata3.Zarplata2DataSet();
            this.coefficientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coefficientTableAdapter = new Zarplata3.Zarplata2DataSetTableAdapters.CoefficientTableAdapter();
            this.tableAdapterManager = new Zarplata3.Zarplata2DataSetTableAdapters.TableAdapterManager();
            this.coefficientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.coefficientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_CoefficientTextBox = new System.Windows.Forms.TextBox();
            this.juniorTextBox = new System.Windows.Forms.TextBox();
            this.middleTextBox = new System.Windows.Forms.TextBox();
            this.seniorTextBox = new System.Windows.Forms.TextBox();
            this.k_A_PTextBox = new System.Windows.Forms.TextBox();
            this.k_U_OTextBox = new System.Windows.Forms.TextBox();
            this.k_T_O_CTextBox = new System.Windows.Forms.TextBox();
            this.k_VTextBox = new System.Windows.Forms.TextBox();
            this.k_CTextBox = new System.Windows.Forms.TextBox();
            this.k_P_D_ETextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            id_CoefficientLabel = new System.Windows.Forms.Label();
            juniorLabel = new System.Windows.Forms.Label();
            middleLabel = new System.Windows.Forms.Label();
            seniorLabel = new System.Windows.Forms.Label();
            k_A_PLabel = new System.Windows.Forms.Label();
            k_U_OLabel = new System.Windows.Forms.Label();
            k_T_O_CLabel = new System.Windows.Forms.Label();
            k_VLabel = new System.Windows.Forms.Label();
            k_CLabel = new System.Windows.Forms.Label();
            k_P_D_ELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zarplata2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientBindingNavigator)).BeginInit();
            this.coefficientBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_CoefficientLabel
            // 
            id_CoefficientLabel.AutoSize = true;
            id_CoefficientLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_CoefficientLabel.Location = new System.Drawing.Point(388, 61);
            id_CoefficientLabel.Name = "id_CoefficientLabel";
            id_CoefficientLabel.Size = new System.Drawing.Size(116, 21);
            id_CoefficientLabel.TabIndex = 1;
            id_CoefficientLabel.Text = "Коэффициент:";
            // 
            // juniorLabel
            // 
            juniorLabel.AutoSize = true;
            juniorLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            juniorLabel.Location = new System.Drawing.Point(345, 100);
            juniorLabel.Name = "juniorLabel";
            juniorLabel.Size = new System.Drawing.Size(161, 21);
            juniorLabel.TabIndex = 3;
            juniorLabel.Text = "Начальный уровень:";
            // 
            // middleLabel
            // 
            middleLabel.AutoSize = true;
            middleLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            middleLabel.Location = new System.Drawing.Point(363, 137);
            middleLabel.Name = "middleLabel";
            middleLabel.Size = new System.Drawing.Size(143, 21);
            middleLabel.TabIndex = 5;
            middleLabel.Text = "Средний уровень:";
            // 
            // seniorLabel
            // 
            seniorLabel.AutoSize = true;
            seniorLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            seniorLabel.Location = new System.Drawing.Point(363, 171);
            seniorLabel.Name = "seniorLabel";
            seniorLabel.Size = new System.Drawing.Size(143, 21);
            seniorLabel.TabIndex = 7;
            seniorLabel.Text = "Высокий уровень:";
            // 
            // k_A_PLabel
            // 
            k_A_PLabel.AutoSize = true;
            k_A_PLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            k_A_PLabel.Location = new System.Drawing.Point(152, 212);
            k_A_PLabel.Name = "k_A_PLabel";
            k_A_PLabel.Size = new System.Drawing.Size(354, 21);
            k_A_PLabel.TabIndex = 9;
            k_A_PLabel.Text = "Коэффициент для установки и проетирование:";
            // 
            // k_U_OLabel
            // 
            k_U_OLabel.AutoSize = true;
            k_U_OLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            k_U_OLabel.Location = new System.Drawing.Point(172, 251);
            k_U_OLabel.Name = "k_U_OLabel";
            k_U_OLabel.Size = new System.Drawing.Size(332, 21);
            k_U_OLabel.TabIndex = 11;
            k_U_OLabel.Text = "Коэффициент для установки оборудования:";
            // 
            // k_T_O_CLabel
            // 
            k_T_O_CLabel.AutoSize = true;
            k_T_O_CLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            k_T_O_CLabel.Location = new System.Drawing.Point(10, 286);
            k_T_O_CLabel.Name = "k_T_O_CLabel";
            k_T_O_CLabel.Size = new System.Drawing.Size(494, 21);
            k_T_O_CLabel.TabIndex = 13;
            k_T_O_CLabel.Text = "Коэффициент для технического обслуживания и сопровождения:";
            // 
            // k_VLabel
            // 
            k_VLabel.AutoSize = true;
            k_VLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            k_VLabel.Location = new System.Drawing.Point(319, 320);
            k_VLabel.Name = "k_VLabel";
            k_VLabel.Size = new System.Drawing.Size(185, 21);
            k_VLabel.TabIndex = 15;
            k_VLabel.Text = "Коэффициент времени:";
            // 
            // k_CLabel
            // 
            k_CLabel.AutoSize = true;
            k_CLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            k_CLabel.Location = new System.Drawing.Point(305, 354);
            k_CLabel.Name = "k_CLabel";
            k_CLabel.Size = new System.Drawing.Size(199, 21);
            k_CLabel.TabIndex = 17;
            k_CLabel.Text = "Коэффициент сложности:";
            // 
            // k_P_D_ELabel
            // 
            k_P_D_ELabel.AutoSize = true;
            k_P_D_ELabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            k_P_D_ELabel.Location = new System.Drawing.Point(100, 389);
            k_P_D_ELabel.Name = "k_P_D_ELabel";
            k_P_D_ELabel.Size = new System.Drawing.Size(404, 21);
            k_P_D_ELabel.TabIndex = 19;
            k_P_D_ELabel.Text = "Коэффициент для перевода в денежный эквивалент:";
            // 
            // zarplata2DataSet
            // 
            this.zarplata2DataSet.DataSetName = "Zarplata2DataSet";
            this.zarplata2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coefficientBindingSource
            // 
            this.coefficientBindingSource.DataMember = "Coefficient";
            this.coefficientBindingSource.DataSource = this.zarplata2DataSet;
            // 
            // coefficientTableAdapter
            // 
            this.coefficientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoefficientTableAdapter = this.coefficientTableAdapter;
            this.tableAdapterManager.ExecutorTableAdapter = null;
            this.tableAdapterManager.MenegerTableAdapter = null;
            this.tableAdapterManager.TaskTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Zarplata3.Zarplata2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // coefficientBindingNavigator
            // 
            this.coefficientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.coefficientBindingNavigator.BindingSource = this.coefficientBindingSource;
            this.coefficientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.coefficientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.coefficientBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.coefficientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.coefficientBindingNavigatorSaveItem});
            this.coefficientBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.coefficientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.coefficientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.coefficientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.coefficientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.coefficientBindingNavigator.Name = "coefficientBindingNavigator";
            this.coefficientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.coefficientBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.coefficientBindingNavigator.TabIndex = 0;
            this.coefficientBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // coefficientBindingNavigatorSaveItem
            // 
            this.coefficientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.coefficientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("coefficientBindingNavigatorSaveItem.Image")));
            this.coefficientBindingNavigatorSaveItem.Name = "coefficientBindingNavigatorSaveItem";
            this.coefficientBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.coefficientBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.coefficientBindingNavigatorSaveItem.Click += new System.EventHandler(this.coefficientBindingNavigatorSaveItem_Click);
            // 
            // id_CoefficientTextBox
            // 
            this.id_CoefficientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "Id_Coefficient", true));
            this.id_CoefficientTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_CoefficientTextBox.Location = new System.Drawing.Point(576, 54);
            this.id_CoefficientTextBox.Name = "id_CoefficientTextBox";
            this.id_CoefficientTextBox.Size = new System.Drawing.Size(100, 28);
            this.id_CoefficientTextBox.TabIndex = 2;
            // 
            // juniorTextBox
            // 
            this.juniorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "Junior", true));
            this.juniorTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.juniorTextBox.Location = new System.Drawing.Point(576, 93);
            this.juniorTextBox.Name = "juniorTextBox";
            this.juniorTextBox.Size = new System.Drawing.Size(100, 28);
            this.juniorTextBox.TabIndex = 4;
            // 
            // middleTextBox
            // 
            this.middleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "Middle", true));
            this.middleTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleTextBox.Location = new System.Drawing.Point(576, 130);
            this.middleTextBox.Name = "middleTextBox";
            this.middleTextBox.Size = new System.Drawing.Size(100, 28);
            this.middleTextBox.TabIndex = 6;
            // 
            // seniorTextBox
            // 
            this.seniorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "Senior", true));
            this.seniorTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seniorTextBox.Location = new System.Drawing.Point(576, 164);
            this.seniorTextBox.Name = "seniorTextBox";
            this.seniorTextBox.Size = new System.Drawing.Size(100, 28);
            this.seniorTextBox.TabIndex = 8;
            // 
            // k_A_PTextBox
            // 
            this.k_A_PTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "K_A_P", true));
            this.k_A_PTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.k_A_PTextBox.Location = new System.Drawing.Point(576, 205);
            this.k_A_PTextBox.Name = "k_A_PTextBox";
            this.k_A_PTextBox.Size = new System.Drawing.Size(100, 28);
            this.k_A_PTextBox.TabIndex = 10;
            // 
            // k_U_OTextBox
            // 
            this.k_U_OTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "K_U_O", true));
            this.k_U_OTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.k_U_OTextBox.Location = new System.Drawing.Point(576, 244);
            this.k_U_OTextBox.Name = "k_U_OTextBox";
            this.k_U_OTextBox.Size = new System.Drawing.Size(100, 28);
            this.k_U_OTextBox.TabIndex = 12;
            this.k_U_OTextBox.TextChanged += new System.EventHandler(this.k_U_OTextBox_TextChanged);
            // 
            // k_T_O_CTextBox
            // 
            this.k_T_O_CTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "K_T_O_C", true));
            this.k_T_O_CTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.k_T_O_CTextBox.Location = new System.Drawing.Point(576, 279);
            this.k_T_O_CTextBox.Name = "k_T_O_CTextBox";
            this.k_T_O_CTextBox.Size = new System.Drawing.Size(100, 28);
            this.k_T_O_CTextBox.TabIndex = 14;
            // 
            // k_VTextBox
            // 
            this.k_VTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "K_V", true));
            this.k_VTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.k_VTextBox.Location = new System.Drawing.Point(576, 313);
            this.k_VTextBox.Name = "k_VTextBox";
            this.k_VTextBox.Size = new System.Drawing.Size(100, 28);
            this.k_VTextBox.TabIndex = 16;
            // 
            // k_CTextBox
            // 
            this.k_CTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "K_C", true));
            this.k_CTextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.k_CTextBox.Location = new System.Drawing.Point(576, 347);
            this.k_CTextBox.Name = "k_CTextBox";
            this.k_CTextBox.Size = new System.Drawing.Size(100, 28);
            this.k_CTextBox.TabIndex = 18;
            // 
            // k_P_D_ETextBox
            // 
            this.k_P_D_ETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coefficientBindingSource, "K_P_D_E", true));
            this.k_P_D_ETextBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.k_P_D_ETextBox.Location = new System.Drawing.Point(576, 382);
            this.k_P_D_ETextBox.Name = "k_P_D_ETextBox";
            this.k_P_D_ETextBox.Size = new System.Drawing.Size(100, 28);
            this.k_P_D_ETextBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(455, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 28);
            this.button1.TabIndex = 22;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(605, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 28);
            this.button2.TabIndex = 23;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zarplata3.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 90);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FormCoefficient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(id_CoefficientLabel);
            this.Controls.Add(this.id_CoefficientTextBox);
            this.Controls.Add(juniorLabel);
            this.Controls.Add(this.juniorTextBox);
            this.Controls.Add(middleLabel);
            this.Controls.Add(this.middleTextBox);
            this.Controls.Add(seniorLabel);
            this.Controls.Add(this.seniorTextBox);
            this.Controls.Add(k_A_PLabel);
            this.Controls.Add(this.k_A_PTextBox);
            this.Controls.Add(k_U_OLabel);
            this.Controls.Add(this.k_U_OTextBox);
            this.Controls.Add(k_T_O_CLabel);
            this.Controls.Add(this.k_T_O_CTextBox);
            this.Controls.Add(k_VLabel);
            this.Controls.Add(this.k_VTextBox);
            this.Controls.Add(k_CLabel);
            this.Controls.Add(this.k_CTextBox);
            this.Controls.Add(k_P_D_ELabel);
            this.Controls.Add(this.k_P_D_ETextBox);
            this.Controls.Add(this.coefficientBindingNavigator);
            this.Name = "FormCoefficient";
            this.Text = "FormCoefficient";
            this.Load += new System.EventHandler(this.FormCoefficient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zarplata2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coefficientBindingNavigator)).EndInit();
            this.coefficientBindingNavigator.ResumeLayout(false);
            this.coefficientBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Zarplata2DataSet zarplata2DataSet;
        private System.Windows.Forms.BindingSource coefficientBindingSource;
        private Zarplata2DataSetTableAdapters.CoefficientTableAdapter coefficientTableAdapter;
        private Zarplata2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator coefficientBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton coefficientBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_CoefficientTextBox;
        private System.Windows.Forms.TextBox juniorTextBox;
        private System.Windows.Forms.TextBox middleTextBox;
        private System.Windows.Forms.TextBox seniorTextBox;
        private System.Windows.Forms.TextBox k_A_PTextBox;
        private System.Windows.Forms.TextBox k_U_OTextBox;
        private System.Windows.Forms.TextBox k_T_O_CTextBox;
        private System.Windows.Forms.TextBox k_VTextBox;
        private System.Windows.Forms.TextBox k_CTextBox;
        private System.Windows.Forms.TextBox k_P_D_ETextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}