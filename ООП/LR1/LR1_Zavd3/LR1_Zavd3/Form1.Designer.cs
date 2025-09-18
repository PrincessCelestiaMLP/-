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
            dateTimePicker1 = new DateTimePicker();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            Nomer = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            DateTime = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            menuStrip1 = new MenuStrip();
            вивестиToolStripMenuItem = new ToolStripMenuItem();
            вивестиToolStripMenuItem1 = new ToolStripMenuItem();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            label6 = new Label();
            timeBox = new MaskedTextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(62, 382);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Ввести";
            button1.UseVisualStyleBackColor = true;
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 31);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 3;
            label1.Text = "Назва атракціону";
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
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(68, 305);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(119, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(374, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(639, 453);
            tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(631, 420);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Усі квітки";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nomer, FirstName, LastName, Year, DateTime });
            dataGridView1.Location = new Point(0, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(628, 419);
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
            // DateTime
            // 
            DateTime.HeaderText = "Дата/Час";
            DateTime.MinimumWidth = 6;
            DateTime.Name = "DateTime";
            DateTime.Width = 125;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(631, 420);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Пошук";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 1);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(422, 419);
            dataGridView2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { вивестиToolStripMenuItem, вивестиToolStripMenuItem1, зберегтиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1013, 28);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // вивестиToolStripMenuItem
            // 
            вивестиToolStripMenuItem.Name = "вивестиToolStripMenuItem";
            вивестиToolStripMenuItem.Size = new Size(99, 24);
            вивестиToolStripMenuItem.Text = "Редагувати";
            // 
            // вивестиToolStripMenuItem1
            // 
            вивестиToolStripMenuItem1.Name = "вивестиToolStripMenuItem1";
            вивестиToolStripMenuItem1.Size = new Size(79, 24);
            вивестиToolStripMenuItem1.Text = "Вивести";
            // 
            // зберегтиToolStripMenuItem
            // 
            зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            зберегтиToolStripMenuItem.Size = new Size(86, 24);
            зберегтиToolStripMenuItem.Text = "Зберегти";
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
            ClientSize = new Size(1013, 450);
            Controls.Add(timeBox);
            Controls.Add(label6);
            Controls.Add(tabControl1);
            Controls.Add(dateTimePicker1);
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
        private DateTimePicker dateTimePicker1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem вивестиToolStripMenuItem;
        private ToolStripMenuItem вивестиToolStripMenuItem1;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nomer;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn DateTime;
        private DataGridView dataGridView2;
        private Label label6;
        private MaskedTextBox timeBox;
    }
}
