namespace WFA_Runtime_Buton_Uretme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 70; i++)
            {
                Button btn = new Button();
                //btn.Location = new Point(245 + (i * 30), 135);
                btn.Name = "Buton" + (i + 1);
                btn.Size = new Size(23, 23);
                btn.Text = "Buton" + (i + 1);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
    }
}
