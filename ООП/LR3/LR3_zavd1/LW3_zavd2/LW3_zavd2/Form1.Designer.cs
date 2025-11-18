namespace LR1_Zavd3
{
    partial class Form1
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
            button1 = new Button();
            last_nameBox = new TextBox();
            nameBox = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            yearBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            datePicker = new DateTimePicker();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            Nomer = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            DateTime_ = new DataGridViewTextBoxColumn();
            nameAttraction_ = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            вивестиToolStripMenuItem = new ToolStripMenuItem();
            копіюОбєктуToolStripMenuItem = new ToolStripMenuItem();
            поДефолтуToolStripMenuItem = new ToolStripMenuItem();
            вивестиToolStripMenuItem1 = new ToolStripMenuItem();
            поІменіToolStripMenuItem = new ToolStripMenuItem();
            поПрізвещіToolStripMenuItem = new ToolStripMenuItem();
            назвіАтракціонуToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиУФайлToolStripMenuItem = new ToolStripMenuItem();
            зчитатиЗФайлуToolStripMenuItem = new ToolStripMenuItem();
            сортируванняToolStripMenuItem = new ToolStripMenuItem();
            заВікомToolStripMenuItem = new ToolStripMenuItem();
            відМеншогоToolStripMenuItem = new ToolStripMenuItem();
            відБільшогоToolStripMenuItem = new ToolStripMenuItem();
            заІмямToolStripMenuItem = new ToolStripMenuItem();
            відАДоЯToolStripMenuItem = new ToolStripMenuItem();
            відЯДоАToolStripMenuItem = new ToolStripMenuItem();
            заПрізвищемToolStripMenuItem = new ToolStripMenuItem();
            відАДоЯToolStripMenuItem1 = new ToolStripMenuItem();
            відЯДоАToolStripMenuItem1 = new ToolStripMenuItem();
            label6 = new Label();
            timeBox = new MaskedTextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(62, 382);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Ввести";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // last_nameBox
            // 
            last_nameBox.Location = new Point(228, 159);
            last_nameBox.Name = "last_nameBox";
            last_nameBox.Size = new Size(125, 27);
            last_nameBox.TabIndex = 1;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(62, 159);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(125, 27);
            nameBox.TabIndex = 2;
            nameBox.TextChanged += nameBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 31);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 3;
            label1.Text = "Тип атракціону";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(62, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 118);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 5;
            label2.Text = "Ім'я";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 118);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 6;
            label3.Text = "Прізвище";
            // 
            // yearBox
            // 
            yearBox.Location = new Point(62, 235);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(125, 27);
            yearBox.TabIndex = 7;
            yearBox.TextChanged += yearBox_TextChanged;
            yearBox.Leave += yearBox_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 203);
            label4.Name = "label4";
            label4.Size = new Size(29, 20);
            label4.TabIndex = 8;
            label4.Text = "Вік";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 282);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 9;
            label5.Text = "Дата/Час";
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Time;
            datePicker.Location = new Point(68, 305);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(119, 27);
            datePicker.TabIndex = 10;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(374, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(796, 453);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(788, 420);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Усі квитки";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nomer, FirstName, LastName, Year, DateTime_, nameAttraction_ });
            dataGridView1.Location = new Point(3, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(785, 419);
            dataGridView1.TabIndex = 0;
            // 
            // Nomer
            // 
            Nomer.HeaderText = "№";
            Nomer.MinimumWidth = 6;
            Nomer.Name = "Nomer";
            Nomer.ReadOnly = true;
            Nomer.Width = 125;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "Ім'я";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.Width = 125;
            // 
            // LastName
            // 
            LastName.HeaderText = "Прізвище";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.Width = 125;
            // 
            // Year
            // 
            Year.HeaderText = "Вік";
            Year.MinimumWidth = 6;
            Year.Name = "Year";
            Year.Width = 125;
            // 
            // DateTime_
            // 
            DateTime_.HeaderText = "Дата/Час";
            DateTime_.MinimumWidth = 6;
            DateTime_.Name = "DateTime_";
            DateTime_.Width = 125;
            // 
            // nameAttraction_
            // 
            nameAttraction_.HeaderText = "Назва атракціону";
            nameAttraction_.MinimumWidth = 6;
            nameAttraction_.Name = "nameAttraction_";
            nameAttraction_.Width = 125;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(788, 420);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Пошук";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridView2.Location = new Point(2, 1);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(785, 419);
            dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "№";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Ім'я";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Прізвище";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Вік";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Дата/Час";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Назва атракціону";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(788, 420);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Атракіони";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, Price });
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(785, 419);
            dataGridView3.TabIndex = 2;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            dataGridView3.CellDoubleClick += dataGridView3_CellDoubleClick;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "№";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Назва";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Мінімальний Вік";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Тривалість";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // Price
            // 
            Price.HeaderText = "Ціна";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { вивестиToolStripMenuItem, вивестиToolStripMenuItem1, зберегтиToolStripMenuItem, сортируванняToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1170, 28);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // вивестиToolStripMenuItem
            // 
            вивестиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { копіюОбєктуToolStripMenuItem, поДефолтуToolStripMenuItem });
            вивестиToolStripMenuItem.Name = "вивестиToolStripMenuItem";
            вивестиToolStripMenuItem.Size = new Size(92, 24);
            вивестиToolStripMenuItem.Text = "Створити ";
            вивестиToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight;
            // 
            // копіюОбєктуToolStripMenuItem
            // 
            копіюОбєктуToolStripMenuItem.Name = "копіюОбєктуToolStripMenuItem";
            копіюОбєктуToolStripMenuItem.Size = new Size(187, 26);
            копіюОбєктуToolStripMenuItem.Text = "Копію об'єкту";
            копіюОбєктуToolStripMenuItem.Click += копіюОбєктуToolStripMenuItem_Click;
            // 
            // поДефолтуToolStripMenuItem
            // 
            поДефолтуToolStripMenuItem.Name = "поДефолтуToolStripMenuItem";
            поДефолтуToolStripMenuItem.Size = new Size(187, 26);
            поДефолтуToolStripMenuItem.Text = "По дефолту";
            поДефолтуToolStripMenuItem.Click += поДефолтуToolStripMenuItem_Click;
            // 
            // вивестиToolStripMenuItem1
            // 
            вивестиToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { поІменіToolStripMenuItem, поПрізвещіToolStripMenuItem, назвіАтракціонуToolStripMenuItem });
            вивестиToolStripMenuItem1.Name = "вивестиToolStripMenuItem1";
            вивестиToolStripMenuItem1.Size = new Size(79, 24);
            вивестиToolStripMenuItem1.Text = "Вивести";
            // 
            // поІменіToolStripMenuItem
            // 
            поІменіToolStripMenuItem.Name = "поІменіToolStripMenuItem";
            поІменіToolStripMenuItem.Size = new Size(210, 26);
            поІменіToolStripMenuItem.Text = "По імені";
            поІменіToolStripMenuItem.Click += поІменіToolStripMenuItem_Click;
            // 
            // поПрізвещіToolStripMenuItem
            // 
            поПрізвещіToolStripMenuItem.Name = "поПрізвещіToolStripMenuItem";
            поПрізвещіToolStripMenuItem.Size = new Size(210, 26);
            поПрізвещіToolStripMenuItem.Text = "По прізвищу";
            поПрізвещіToolStripMenuItem.Click += поПрізвещіToolStripMenuItem_Click;
            // 
            // назвіАтракціонуToolStripMenuItem
            // 
            назвіАтракціонуToolStripMenuItem.Name = "назвіАтракціонуToolStripMenuItem";
            назвіАтракціонуToolStripMenuItem.Size = new Size(210, 26);
            назвіАтракціонуToolStripMenuItem.Text = "Назві атракціону";
            назвіАтракціонуToolStripMenuItem.Click += назвіАтракціонуToolStripMenuItem_Click;
            // 
            // зберегтиToolStripMenuItem
            // 
            зберегтиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { зберегтиУФайлToolStripMenuItem, зчитатиЗФайлуToolStripMenuItem });
            зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            зберегтиToolStripMenuItem.Size = new Size(59, 24);
            зберегтиToolStripMenuItem.Text = "Файл";
            зберегтиToolStripMenuItem.Click += зберегтиToolStripMenuItem_Click;
            // 
            // зберегтиУФайлToolStripMenuItem
            // 
            зберегтиУФайлToolStripMenuItem.Name = "зберегтиУФайлToolStripMenuItem";
            зберегтиУФайлToolStripMenuItem.Size = new Size(205, 26);
            зберегтиУФайлToolStripMenuItem.Text = "Зберегти у файл";
            зберегтиУФайлToolStripMenuItem.Click += зберегтиУФайлToolStripMenuItem_Click;
            // 
            // зчитатиЗФайлуToolStripMenuItem
            // 
            зчитатиЗФайлуToolStripMenuItem.Name = "зчитатиЗФайлуToolStripMenuItem";
            зчитатиЗФайлуToolStripMenuItem.Size = new Size(205, 26);
            зчитатиЗФайлуToolStripMenuItem.Text = "Зчитати з файлу";
            зчитатиЗФайлуToolStripMenuItem.Click += зчитатиЗФайлуToolStripMenuItem_Click;
            // 
            // сортируванняToolStripMenuItem
            // 
            сортируванняToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { заВікомToolStripMenuItem, заІмямToolStripMenuItem, заПрізвищемToolStripMenuItem });
            сортируванняToolStripMenuItem.Name = "сортируванняToolStripMenuItem";
            сортируванняToolStripMenuItem.Size = new Size(123, 24);
            сортируванняToolStripMenuItem.Text = "Сортирування";
            // 
            // заВікомToolStripMenuItem
            // 
            заВікомToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { відМеншогоToolStripMenuItem, відБільшогоToolStripMenuItem });
            заВікомToolStripMenuItem.Name = "заВікомToolStripMenuItem";
            заВікомToolStripMenuItem.Size = new Size(189, 26);
            заВікомToolStripMenuItem.Text = "За віком";
            // 
            // відМеншогоToolStripMenuItem
            // 
            відМеншогоToolStripMenuItem.Name = "відМеншогоToolStripMenuItem";
            відМеншогоToolStripMenuItem.Size = new Size(182, 26);
            відМеншогоToolStripMenuItem.Text = "Від меншого";
            відМеншогоToolStripMenuItem.Click += відМеншогоToolStripMenuItem_Click;
            // 
            // відБільшогоToolStripMenuItem
            // 
            відБільшогоToolStripMenuItem.Name = "відБільшогоToolStripMenuItem";
            відБільшогоToolStripMenuItem.Size = new Size(182, 26);
            відБільшогоToolStripMenuItem.Text = "Від більшого";
            відБільшогоToolStripMenuItem.Click += відБільшогоToolStripMenuItem_Click;
            // 
            // заІмямToolStripMenuItem
            // 
            заІмямToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { відАДоЯToolStripMenuItem, відЯДоАToolStripMenuItem });
            заІмямToolStripMenuItem.Name = "заІмямToolStripMenuItem";
            заІмямToolStripMenuItem.Size = new Size(189, 26);
            заІмямToolStripMenuItem.Text = "За ім'ям";
            // 
            // відАДоЯToolStripMenuItem
            // 
            відАДоЯToolStripMenuItem.Name = "відАДоЯToolStripMenuItem";
            відАДоЯToolStripMenuItem.Size = new Size(161, 26);
            відАДоЯToolStripMenuItem.Text = "Від А до Я";
            відАДоЯToolStripMenuItem.Click += відАДоЯToolStripMenuItem_Click;
            // 
            // відЯДоАToolStripMenuItem
            // 
            відЯДоАToolStripMenuItem.Name = "відЯДоАToolStripMenuItem";
            відЯДоАToolStripMenuItem.Size = new Size(161, 26);
            відЯДоАToolStripMenuItem.Text = "Від Я до А";
            відЯДоАToolStripMenuItem.Click += відЯДоАToolStripMenuItem_Click;
            // 
            // заПрізвищемToolStripMenuItem
            // 
            заПрізвищемToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { відАДоЯToolStripMenuItem1, відЯДоАToolStripMenuItem1 });
            заПрізвищемToolStripMenuItem.Name = "заПрізвищемToolStripMenuItem";
            заПрізвищемToolStripMenuItem.Size = new Size(189, 26);
            заПрізвищемToolStripMenuItem.Text = "За прізвищем";
            // 
            // відАДоЯToolStripMenuItem1
            // 
            відАДоЯToolStripMenuItem1.Name = "відАДоЯToolStripMenuItem1";
            відАДоЯToolStripMenuItem1.Size = new Size(161, 26);
            відАДоЯToolStripMenuItem1.Text = "Від А до Я";
            відАДоЯToolStripMenuItem1.Click += відАДоЯToolStripMenuItem1_Click;
            // 
            // відЯДоАToolStripMenuItem1
            // 
            відЯДоАToolStripMenuItem1.Name = "відЯДоАToolStripMenuItem1";
            відЯДоАToolStripMenuItem1.Size = new Size(161, 26);
            відЯДоАToolStripMenuItem1.Text = "Від Я до А";
            відЯДоАToolStripMenuItem1.Click += відЯДоАToolStripMenuItem1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(228, 282);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 13;
            label6.Text = "Час";
            // 
            // timeBox
            // 
            timeBox.Location = new Point(228, 305);
            timeBox.Mask = "00:00";
            timeBox.Name = "timeBox";
            timeBox.Size = new Size(125, 27);
            timeBox.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 450);
            Controls.Add(timeBox);
            Controls.Add(label6);
            Controls.Add(tabControl1);
            Controls.Add(datePicker);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(yearBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(nameBox);
            Controls.Add(last_nameBox);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox last_nameBox;
        private TextBox nameBox;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private TextBox yearBox;
        private Label label4;
        private Label label5;
        private DateTimePicker datePicker;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem вивестиToolStripMenuItem;
        private ToolStripMenuItem вивестиToolStripMenuItem1;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private DataGridView dataGridView1;
        private Label label6;
        private MaskedTextBox timeBox;
        private ToolStripMenuItem копіюОбєктуToolStripMenuItem;
        private ToolStripMenuItem поДефолтуToolStripMenuItem;
        private ToolStripMenuItem зберегтиУФайлToolStripMenuItem;
        private ToolStripMenuItem зчитатиЗФайлуToolStripMenuItem;
        private DataGridViewTextBoxColumn Nomer;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn DateTime_;
        private DataGridViewTextBoxColumn nameAttraction_;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private ToolStripMenuItem поІменіToolStripMenuItem;
        private ToolStripMenuItem поПрізвещіToolStripMenuItem;
        private ToolStripMenuItem назвіАтракціонуToolStripMenuItem;
        private ToolStripMenuItem сортируванняToolStripMenuItem;
        private ToolStripMenuItem заВікомToolStripMenuItem;
        private ToolStripMenuItem відМеншогоToolStripMenuItem;
        private ToolStripMenuItem відБільшогоToolStripMenuItem;
        private ToolStripMenuItem заІмямToolStripMenuItem;
        private ToolStripMenuItem відАДоЯToolStripMenuItem;
        private ToolStripMenuItem відЯДоАToolStripMenuItem;
        private ToolStripMenuItem заПрізвищемToolStripMenuItem;
        private ToolStripMenuItem відАДоЯToolStripMenuItem1;
        private ToolStripMenuItem відЯДоАToolStripMenuItem1;
        private TabPage tabPage3;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn Price;
    }
}
