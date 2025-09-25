
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;
using Lab1_zavd3;
namespace LR1_Zavd3

{
    public partial class Form1 : Form
    {
        string[] NameAttraction = new string[] { "Roller coaster", "Freefall tower", "Funnel slides", "�������", "Rail-free trains" };
        List<Ticket> tickets = new List<Ticket>();
        int count = 0;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(NameAttraction);
            comboBox1.SelectedIndexChanged += button_Check;
            nameBox.TextChanged += button_Check;
            last_nameBox.TextChanged += button_Check;
            yearBox.TextChanged += button_Check;
            datePicker.ValueChanged += button_Check;
            timeBox.TextChanged += button_Check;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //-----------------��������------------------- 
        private void button_Check(object sender, EventArgs e)
        {
            // г�
            if (!string.IsNullOrWhiteSpace(yearBox.Text) && !System.Text.RegularExpressions.Regex.IsMatch(yearBox.Text, @"^\d+$"))
            {
                MessageBox.Show("��� ������� ���� ����� �����!");
                button1.Enabled = false;
                button1.BackColor = Color.Red;
                return;
            }

            if (!string.IsNullOrWhiteSpace(yearBox.Text))
            {
                int year = int.Parse(yearBox.Text);
                if (year < 1 || year > 100)
                {
                    MessageBox.Show("³� ������� ���� �� 1 �� 100!");
                    button1.Enabled = false;
                    button1.BackColor = Color.Red;
                    return;
                }
            }

            // ��'�
            if (!string.IsNullOrWhiteSpace(nameBox.Text) && !System.Text.RegularExpressions.Regex.IsMatch(nameBox.Text, @"^[a-zA-Z�-��-߿�������]+$"))
            {
                MessageBox.Show("��� ������� ���� ����� �����!");
                button1.Enabled = false;
                button1.BackColor = Color.Red;
                return;
            }

            // �������
            if (!string.IsNullOrWhiteSpace(last_nameBox.Text) && !System.Text.RegularExpressions.Regex.IsMatch(last_nameBox.Text, @"^[a-zA-Z�-��-߿�������]+$"))
            {
                MessageBox.Show("��� ������� ���� ����� �����!");
                button1.Enabled = false;
                button1.BackColor = Color.Red;
                return;
            }

            // �������� ����
            bool isTimeValid = DateTime.TryParseExact(timeBox.Text, "HH:mm",
                                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime time);

            // ������ ������� ����� ���� �� ���� �������� + ������� ���
            bool allFilled = comboBox1.SelectedIndex != -1
                             && !string.IsNullOrWhiteSpace(nameBox.Text)
                             && !string.IsNullOrWhiteSpace(last_nameBox.Text)
                             && !string.IsNullOrWhiteSpace(yearBox.Text)
                             && isTimeValid;

            button1.Enabled = allFilled;
            button1.BackColor = allFilled ? Color.Green : Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ticket = new Ticket(
       nameBox.Text,
       last_nameBox.Text,
       comboBox1.SelectedItem.ToString(),
       int.Parse(yearBox.Text),
       datePicker.Value.Date + TimeSpan.Parse(timeBox.Text)
   );

            tickets.Add(ticket);

            WriteInDataGrid(ticket);

        }
        private void WriteInDataGrid(Ticket ticket)
        {
            int rowIndex = dataGridView1.Rows.Add();
            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            row.Cells[0].Value = count + 1;
            row.Cells[1].Value = ticket.FirstName;
            row.Cells[2].Value = ticket.LastName;
            row.Cells[3].Value = ticket.Age;
            row.Cells[4].Value = ticket.DateTime;
            row.Cells[5].Value = ticket.NameAttraction;

            count++;
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "BIN files (*.bin)|*.bin|All files (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (BinaryWriter writer = new BinaryWriter(File.Open(sfd.FileName, FileMode.Create)))
                    {
                        foreach (var ticket in tickets)
                        {
                            writer.Write(ticket.FirstName);
                            writer.Write(ticket.LastName);
                            writer.Write(ticket.Age);
                            writer.Write(ticket.DateTime.ToBinary()); // �������� DateTime � �������� ������
                            writer.Write(ticket.NameAttraction);
                        }
                    }
                    MessageBox.Show("��� ��������� � ������� ����!");
                }
            }
        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "BIN files (*.bin)|*.bin|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    tickets.Clear();
                    dataGridView1.Rows.Clear();
                    count = 0;

                    using (BinaryReader reader = new BinaryReader(File.Open(ofd.FileName, FileMode.Open)))
                    {
                        while (reader.BaseStream.Position < reader.BaseStream.Length)
                        {
                            string firstName = reader.ReadString();
                            string lastName = reader.ReadString();
                            int age = reader.ReadInt32();
                            DateTime dateTime = DateTime.FromBinary(reader.ReadInt64());
                            string attraction = reader.ReadString();

                            var ticket = new Ticket(firstName, lastName, attraction, age, dateTime);
                            tickets.Add(ticket);

                            int rowIndex = dataGridView1.Rows.Add();
                            DataGridViewRow row = dataGridView1.Rows[rowIndex];
                            row.Cells[0].Value = ++count;
                            row.Cells[1].Value = ticket.FirstName;
                            row.Cells[2].Value = ticket.LastName;
                            row.Cells[3].Value = ticket.Age;
                            row.Cells[4].Value = ticket.DateTime;
                            row.Cells[5].Value = ticket.NameAttraction;
                        }
                    }
                    MessageBox.Show("��� ����������� � �������� �����!");
                }
            }
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tickets.Count == 0)
            {
                MessageBox.Show("���� ������ ��� ���������!");
                return;
            }

            using (var copyForm = new CopyTicketForm(tickets.Count))
            {
                if (copyForm.ShowDialog() == DialogResult.OK)
                {
                    int index = copyForm.SelectedIndex;


                    var original = tickets[index];
                    nameBox.Text = original.FirstName;
                    last_nameBox.Text = original.LastName;
                    yearBox.Text = original.Age.ToString();
                    comboBox1.Text = original.NameAttraction;
                    timeBox.Text = original.DateTime.ToString("HH:mm");
                    datePicker.Value = original.DateTime;

                }
            }
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ticket defolt = new Ticket();
            nameBox.Text = defolt.FirstName;
            last_nameBox.Text = defolt.LastName;
            yearBox.Text = defolt.Age.ToString();
            comboBox1.Text = defolt.NameAttraction;
            timeBox.Text = defolt.DateTime.ToString("HH:mm");
            datePicker.Value = defolt.DateTime;
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (tickets.Count == 0)
            {
                MessageBox.Show("������ ������ �������!");
                return;
            }

            // ��������� ������ ��� ����
            List<string> allNames = tickets.Select(t => t.FirstName).ToList();

            using (var searchForm = new NameSearchForm(allNames))
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    string name = searchForm.NameToSearch;

                    dataGridView2.Rows.Clear();
                    int tempCount = 0;

                    foreach (var ticket in tickets)
                    {
                        if (ticket.FirstName.Equals(name, StringComparison.OrdinalIgnoreCase))
                        {
                            int rowIndex = dataGridView2.Rows.Add();
                            DataGridViewRow row = dataGridView2.Rows[rowIndex];

                            row.Cells[0].Value = ++tempCount;
                            row.Cells[1].Value = ticket.FirstName;
                            row.Cells[2].Value = ticket.LastName;
                            row.Cells[3].Value = ticket.Age;
                            row.Cells[4].Value = ticket.DateTime;
                            row.Cells[5].Value = ticket.NameAttraction;
                        }
                    }

                    if (tempCount == 0)
                        MessageBox.Show("������ � ����� ��'�� �� ��������!");
                }
            }
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tickets.Count == 0)
            {
                MessageBox.Show("������ ������ �������!");
                return;
            }

            // ��������� ������ ��� ����
            List<string> allNames = tickets.Select(t => t.LastName).ToList();

            using (var searchForm = new NameSearchForm(allNames))
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    string name = searchForm.NameToSearch;

                    dataGridView2.Rows.Clear();
                    int tempCount = 0;

                    foreach (var ticket in tickets)
                    {
                        if (ticket.LastName.Equals(name, StringComparison.OrdinalIgnoreCase))
                        {
                            int rowIndex = dataGridView2.Rows.Add();
                            DataGridViewRow row = dataGridView2.Rows[rowIndex];

                            row.Cells[0].Value = ++tempCount;
                            row.Cells[1].Value = ticket.FirstName;
                            row.Cells[2].Value = ticket.LastName;
                            row.Cells[3].Value = ticket.Age;
                            row.Cells[4].Value = ticket.DateTime;
                            row.Cells[5].Value = ticket.NameAttraction;
                        }
                    }

                    if (tempCount == 0)
                        MessageBox.Show("������ � ����� ��'�� �� ��������!");
                }
            }
        }

        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tickets.Count == 0)
            {
                MessageBox.Show("������ ������ �������!");
                return;
            }

            // ��������� ������ ��� ����
            List<string> allNames = tickets.Select(t => t.NameAttraction).ToList();

            using (var searchForm = new NameSearchForm(allNames))
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    string name = searchForm.NameToSearch;

                    dataGridView2.Rows.Clear();
                    int tempCount = 0;

                    foreach (var ticket in tickets)
                    {
                        if (ticket.NameAttraction.Equals(name, StringComparison.OrdinalIgnoreCase))
                        {
                            int rowIndex = dataGridView2.Rows.Add();
                            DataGridViewRow row = dataGridView2.Rows[rowIndex];

                            row.Cells[0].Value = ++tempCount;
                            row.Cells[1].Value = ticket.FirstName;
                            row.Cells[2].Value = ticket.LastName;
                            row.Cells[3].Value = ticket.Age;
                            row.Cells[4].Value = ticket.DateTime;
                            row.Cells[5].Value = ticket.NameAttraction;
                        }
                    }

                    if (tempCount == 0)
                        MessageBox.Show("������ � ����� ��'�� �� ��������!");
                }
            }
        }
        private void UpdateDataGrid()
        {
            dataGridView1.Rows.Clear();
            count = 0;

            foreach (var ticket in tickets)
            {
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                row.Cells[0].Value = ++count;
                row.Cells[1].Value = ticket.FirstName;
                row.Cells[2].Value = ticket.LastName;
                row.Cells[3].Value = ticket.Age;
                row.Cells[4].Value = ticket.DateTime;
                row.Cells[5].Value = ticket.NameAttraction;
            }
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tickets = tickets.OrderBy(t => t.Age).ToList(); 
            UpdateDataGrid();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tickets = tickets.OrderByDescending(t => t.Age).ToList(); 
            UpdateDataGrid();
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tickets = tickets.OrderBy(t => t.FirstName).ToList();
            UpdateDataGrid();
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tickets = tickets.OrderByDescending(t => t.FirstName).ToList();
            UpdateDataGrid();
        }

        private void ������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tickets = tickets.OrderBy(t => t.LastName).ToList();
            UpdateDataGrid();
        }

        private void ������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tickets = tickets.OrderByDescending(t => t.LastName).ToList();
            UpdateDataGrid();
        }
    }
}
