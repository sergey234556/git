namespace WindowsFormsApplication1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox9 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox8 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.красныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.желтыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.белыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключениеКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "2.jpg");
            this.imageList1.Images.SetKeyName(1, "sublime-samana-16.jpg");
            this.imageList1.Images.SetKeyName(2, "swimming-pool.jpg");
            this.imageList1.Images.SetKeyName(3, "Pool_night.jpg");
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 590);
            this.panel1.TabIndex = 7;
            this.panel1.UseWaitCursor = true;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(772, 450);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.UseWaitCursor = true;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.maskedTextBox9);
            this.groupBox1.Controls.Add(this.maskedTextBox8);
            this.groupBox1.Controls.Add(this.maskedTextBox7);
            this.groupBox1.Controls.Add(this.maskedTextBox6);
            this.groupBox1.Controls.Add(this.maskedTextBox5);
            this.groupBox1.Controls.Add(this.maskedTextBox4);
            this.groupBox1.Controls.Add(this.maskedTextBox3);
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(799, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 460);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите техст";
            this.groupBox1.UseWaitCursor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(117, 323);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.UseWaitCursor = true;
            // 
            // maskedTextBox9
            // 
            this.maskedTextBox9.Location = new System.Drawing.Point(138, 295);
            this.maskedTextBox9.Name = "maskedTextBox9";
            this.maskedTextBox9.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox9.TabIndex = 9;
            this.maskedTextBox9.UseWaitCursor = true;
            // 
            // maskedTextBox8
            // 
            this.maskedTextBox8.Location = new System.Drawing.Point(138, 76);
            this.maskedTextBox8.Name = "maskedTextBox8";
            this.maskedTextBox8.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox8.TabIndex = 8;
            this.maskedTextBox8.UseWaitCursor = true;
            // 
            // maskedTextBox7
            // 
            this.maskedTextBox7.Location = new System.Drawing.Point(138, 104);
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox7.TabIndex = 7;
            this.maskedTextBox7.UseWaitCursor = true;
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Location = new System.Drawing.Point(139, 139);
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox6.TabIndex = 6;
            this.maskedTextBox6.UseWaitCursor = true;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(138, 267);
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox5.TabIndex = 5;
            this.maskedTextBox5.UseWaitCursor = true;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(138, 202);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox4.TabIndex = 4;
            this.maskedTextBox4.UseWaitCursor = true;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(138, 232);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox3.TabIndex = 3;
            this.maskedTextBox3.UseWaitCursor = true;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(138, 174);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox2.TabIndex = 2;
            this.maskedTextBox2.UseWaitCursor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(139, 37);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.UseWaitCursor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(118, 300);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(613, 511);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 53);
            this.button2.TabIndex = 47;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(348, 429);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(288, 62);
            this.button4.TabIndex = 11;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.UseWaitCursor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(348, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(288, 76);
            this.button3.TabIndex = 10;
            this.button3.Text = "Регестрация";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(348, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 57);
            this.button1.TabIndex = 9;
            this.button1.Text = "Вывод документов";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(405, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 75);
            this.label1.TabIndex = 6;
            this.label1.Text = "Меню";
            this.label1.UseWaitCursor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(348, 170);
            this.button5.Margin = new System.Windows.Forms.Padding(1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(288, 57);
            this.button5.TabIndex = 4;
            this.button5.Text = "Таблицы";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.UseWaitCursor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1050, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветToolStripMenuItem,
            this.подключениеКБДToolStripMenuItem});
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.настройкаToolStripMenuItem.Text = "Настройка";
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.красныйToolStripMenuItem,
            this.зеленыйToolStripMenuItem,
            this.синийToolStripMenuItem,
            this.желтыйToolStripMenuItem,
            this.белыйToolStripMenuItem});
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.цветToolStripMenuItem.Text = "Цвет";
            // 
            // красныйToolStripMenuItem
            // 
            this.красныйToolStripMenuItem.Name = "красныйToolStripMenuItem";
            this.красныйToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.красныйToolStripMenuItem.Text = "Красный";
            this.красныйToolStripMenuItem.Click += new System.EventHandler(this.красныйToolStripMenuItem_Click);
            // 
            // зеленыйToolStripMenuItem
            // 
            this.зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            this.зеленыйToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.зеленыйToolStripMenuItem.Text = "Зеленый";
            this.зеленыйToolStripMenuItem.Click += new System.EventHandler(this.зеленыйToolStripMenuItem_Click);
            // 
            // синийToolStripMenuItem
            // 
            this.синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            this.синийToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.синийToolStripMenuItem.Text = "Синий ";
            this.синийToolStripMenuItem.Click += new System.EventHandler(this.синийToolStripMenuItem_Click);
            // 
            // желтыйToolStripMenuItem
            // 
            this.желтыйToolStripMenuItem.Name = "желтыйToolStripMenuItem";
            this.желтыйToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.желтыйToolStripMenuItem.Text = "Желтый";
            this.желтыйToolStripMenuItem.Click += new System.EventHandler(this.желтыйToolStripMenuItem_Click);
            // 
            // белыйToolStripMenuItem
            // 
            this.белыйToolStripMenuItem.Name = "белыйToolStripMenuItem";
            this.белыйToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.белыйToolStripMenuItem.Text = "Стандартный";
            this.белыйToolStripMenuItem.Click += new System.EventHandler(this.белыйToolStripMenuItem_Click);
            // 
            // подключениеКБДToolStripMenuItem
            // 
            this.подключениеКБДToolStripMenuItem.Name = "подключениеКБДToolStripMenuItem";
            this.подключениеКБДToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.подключениеКБДToolStripMenuItem.Text = "Подключение к БД";
            this.подключениеКБДToolStripMenuItem.Click += new System.EventHandler(this.подключениеКБДToolStripMenuItem_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(235, 511);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 53);
            this.button6.TabIndex = 40;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(125, 511);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 53);
            this.button7.TabIndex = 39;
            this.button7.Text = "Изменить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 511);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(108, 53);
            this.button8.TabIndex = 38;
            this.button8.Text = "Добавить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 590);
            this.panel2.TabIndex = 42;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1332, 665);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(137, 48);
            this.button9.TabIndex = 46;
            this.button9.Text = "Назад";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(653, 623);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Выбор таблицы";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Информация о покупках",
            "Тестирование",
            "Услуги",
            "Аккаунт",
            "План действия",
            "Оценка программы",
            "Информация о программе",
            "Рассылка",
            "Карта ",
            "Отзовы"});
            this.comboBox1.Location = new System.Drawing.Point(364, 511);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 24);
            this.comboBox1.TabIndex = 44;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(117, 353);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 12;
            this.comboBox3.UseWaitCursor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(118, 400);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 13;
            this.comboBox4.UseWaitCursor = true;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(117, 430);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 24);
            this.comboBox5.TabIndex = 14;
            this.comboBox5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 360);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 403);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 432);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = "label15";
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1050, 590);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(1013, 637);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приложение";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem настройкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem красныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зеленыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem желтыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem белыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключениеКБДToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

