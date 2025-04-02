namespace calculate_tax
{
    public partial class Form1 : Form
    {
        int year;
        string selectedItem;
        int yearResult;
        public Form1()
        {
            InitializeComponent();
            era.Items.Add("พ.ศ. -> ค.ศ.");
            era.Items.Add("ค.ศ. -> พ.ศ.");
            era.SelectedIndexChanged += era_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void era_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = era.SelectedItem.ToString();
            if (selectedItem == "พ.ศ. -> ค.ศ.")
            {
                label3.Text = "พ.ศ.";
                labelEra.Text = "ค.ศ.";
            }
            else if (selectedItem == "ค.ศ. -> พ.ศ.")
            {
                label3.Text = "ค.ศ.";
                labelEra.Text = "พ.ศ.";
            }

        }
        private void txtYear_TextChanged_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtYear.Text, out int result))
            {
                MessageBox.Show("กรุณากรอกตัวเลขเป็นปีศักราชเท่านั้น");
            }
            else
            {
                year = int.Parse(txtYear.Text);
                if (selectedItem == "พ.ศ. -> ค.ศ.")
                {
                    label3.Text = "พ.ศ.";
                    yearResult = year - 543;
                }
                else if (selectedItem == "ค.ศ. -> พ.ศ.")
                {
                    label3.Text = "ค.ศ.";
                    yearResult = year + 543;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelResult.Text = yearResult.ToString();
        }

        private void labelResult_Click(object sender, EventArgs e)
        {
        }

        private void labelEra_Click(object sender, EventArgs e)
        {
        }
    }
}
