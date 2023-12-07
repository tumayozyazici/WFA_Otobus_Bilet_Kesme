using Microsoft.VisualBasic.ApplicationServices;
using System.Text;
using System.Windows.Forms;

namespace WFA_Otobus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int bosKoltuk = 3, sayac = 0;
            for (int i = 1; i < 69; i++)
            {
                Button btn = new Button();

                if (i == bosKoltuk)
                {
                    bosKoltuk += 5;
                    btn.Size = new Size(45, 0);
                    flp_koltuk.Controls.Add(btn);
                    sayac++;
                }
                else
                {
                    btn.Size = new Size(45, 45);
                    btn.Text = $"{i - sayac}";
                    btn.Tag = (i - sayac);
                    flp_koltuk.Controls.Add(btn);
                    btn.Click += btn_Click;
                }
            }
            Label lbl_kapi = new Label();
            lbl_kapi.BorderStyle = BorderStyle.FixedSingle;
            lbl_kapi.Size = new Size(95, 45);
            lbl_kapi.BackColor = Color.Yellow;
            lbl_kapi.Text = "KAPI";
            lbl_kapi.TextAlign = ContentAlignment.MiddleCenter;
            flp_koltuk.Controls.Add(lbl_kapi);

            gb_kisiselBilgiler.Enabled = false;
        }

        Button secilenButonHafizadaTut;

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            gb_kisiselBilgiler.Enabled = true;
            txt_koltuk.Enabled = false;
            txt_koltuk.Text = btn.Tag.ToString();
            secilenButonHafizadaTut = btn;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string boslar = string.Empty;
            foreach (Control item in gb_kisiselBilgiler.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    if (string.IsNullOrEmpty(txt.Text))
                    {
                        boslar += txt.Tag + " ";
                    }
                }
            }
            if (!string.IsNullOrEmpty(boslar))
            {
                MessageBox.Show(boslar, "Þu nesneleri boþ býraktýnýz", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cinsiyet = rdb_erkek.Checked ? rdb_erkek.Text : rdb_kadin.Text;

                bool isKoltuk = true;
                for (int i = 0; i < flp_koltuk.Controls.Count; i++)
                {
                    if (flp_koltuk.Controls[i] is Button)
                    {
                        Button btn = flp_koltuk.Controls[i] as Button;
                        if (Convert.ToInt32(secilenButonHafizadaTut.Tag) % 2 == 0)
                        {
                            if (btn.Text == (Convert.ToInt32(secilenButonHafizadaTut.Tag) - 1).ToString())
                            {
                                if (!(btn.Tag.GetType().Name == "Int32"))
                                {
                                    if (btn.Tag != cinsiyet)
                                    {
                                        isKoltuk = false;
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (btn.Text == (Convert.ToInt32(secilenButonHafizadaTut.Tag) + 1).ToString())
                            {
                                if (!(btn.Tag.GetType().Name == "Int32"))
                                {
                                    if (btn.Tag != cinsiyet)
                                    {
                                        isKoltuk = false;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                if (isKoltuk == true)
                {
                    string veriler = $"{txt_koltuk.Text} nolu koltuk: {txt_ad.Text} {txt_soyad.Text} {cinsiyet} telefon no: {txt_telefon.Text}";

                    listBox1.Items.Add(veriler);
                    secilenButonHafizadaTut.Enabled = false;
                    secilenButonHafizadaTut.BackColor = rdb_erkek.Checked ? Color.Azure : Color.LightPink;
                    secilenButonHafizadaTut.Tag = cinsiyet;

                    gb_kisiselBilgiler.Enabled = false;
                    txt_ad.Clear();
                    txt_soyad.Clear();
                    txt_telefon.Clear();

                    cinsiyet = rdb_erkek.Checked ? "C:\\Users\\--\\Desktop\\Çalýþmalar\\WFA_Runtime_Buton_Uretme\\WFA_Otobus\\NewFolder\\m.png" : "C:\\Users\\--\\Desktop\\Çalýþmalar\\WFA_Runtime_Buton_Uretme\\WFA_Otobus\\NewFolder\\f.png";

                    secilenButonHafizadaTut.BackgroundImageLayout = ImageLayout.Stretch;
                    secilenButonHafizadaTut.BackgroundImage = Image.FromFile(cinsiyet);

                    MessageBox.Show("Ýþlem Baþarýlý");
                }
                else
                {
                    MessageBox.Show("Alamazsýn.");
                }
            }
            
        }
    }
}
