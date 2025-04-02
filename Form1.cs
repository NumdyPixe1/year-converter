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
            era.Items.Add("�.�. -> �.�.");
            era.Items.Add("�.�. -> �.�.");
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
            if (selectedItem == "�.�. -> �.�.")
            {
                label3.Text = "�.�.";
                labelEra.Text = "�.�.";
            }
            else if (selectedItem == "�.�. -> �.�.")
            {
                label3.Text = "�.�.";
                labelEra.Text = "�.�.";
            }

        }
        private void txtYear_TextChanged_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtYear.Text, out int result))
            {
                MessageBox.Show("��سҡ�͡����Ţ�繻��ѡ�Ҫ��ҹ��");
            }
            else
            {
                year = int.Parse(txtYear.Text);
                if (selectedItem == "�.�. -> �.�.")
                {
                    label3.Text = "�.�.";
                    yearResult = year - 543;
                }
                else if (selectedItem == "�.�. -> �.�.")
                {
                    label3.Text = "�.�.";
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
