using System.Xml.Linq;

namespace Login_Ekran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string istusername = usernametxtbox.Text;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string istusername1 = usernametxtbox.Text;
            string istusername2 = passwordtxtbox.Text;
            string username = "Ehed123";
            string parol = "Admin123";
            if(username==istusername1 && parol == istusername2)
            {
                adtxtbox.Visible = true;
                adtxt.Visible = true;
                sifretxtbox.Visible = true;
                sifretxt.Visible = true;
                usernametxt.Visible = false;
                password.Visible = false;
                passwordtxtbox.Visible = false;
                usernametxtbox.Visible = false;
                login.Visible = false;
                checkboxev.Visible = true;
                checkboxsb.Visible= true;
                comboBox1.Visible = true;
                label1.Visible = true;
                button1.Visible = true;
                string adin = adtxtbox.Text;
                nameshow.Visible = true;
                shownamexet.Visible = true;
                passshow.Visible = true;
                passshowxet.Visible=true;
                ailevezshow.Visible = true;
                ailevezshowxet.Visible = true;
                ensevdiyinfenn.Visible = true;
                ensevdiyinfennxet.Visible = true;
                listBox1.Visible = true;

            }
            else
            {
                MessageBox.Show("Istifadeci Adi Ve Ya Sifreniz Yalnisdir Yeniden Cehd Edin");
            }
    
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void adtxtbox_TextChanged(object sender, EventArgs e)
        {
           
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            shownamexet.Text = adtxtbox.Text;
            passshowxet.Text = sifretxtbox.Text;
            string selecet = comboBox1.Text;
            ensevdiyinfennxet.Text = selecet;
            bool deyer = checkboxev.Checked;
            if (deyer == true)
            {
                ailevezshowxet.Text="Evlisen";
            }
            bool deyer1 = checkboxsb.Checked;
            if (deyer1 == true)
            {
                ailevezshowxet.Text="Subaysan";
                
            }
            listBox1.Items.Add(adtxtbox.Text);
            listBox1.SelectedIndex = 0;
            listBox1.Items.Add(sifretxtbox.Text);
            listBox1.SelectedIndex = 1;
          //yenileme3        
        }

        private void password_Click(object sender, EventArgs e)
        {
            //yenileme 2
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //yenile 1
        }


    }
}