
/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
** PROGRAMLAMAYA GİRİŞİ DERSİ
**
** ÖDEV NUMARASI…...:  Soru 3
** ÖĞRENCİ ADI...............:  Sümeyye Karataş
** ÖĞRENCİ NUMARASI.:  B221210005
** DERS GRUBU…………:    1. Öğretim A Grubu
YOUTUBE LİNKİ… …:  Soru-3  : https://youtu.be/ymmWe90tM8A  
                   Soru 1-2 : https://youtu.be/-O4EFmg2cCs
                   
****************************************************************************/

namespace Soru3_Form_Sümeyye_Karataş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<GeometrikSekiller> GeometrikSekillers = new List<GeometrikSekiller>();

        Nokta nokta1 = new Nokta();
        Dortgen dortgen1 = new Dortgen();
        Dortgen dortgen2 = new Dortgen();
        Cember cember1 = new Cember();
        Cember cember2 = new Cember();
        Silindir silindir1 = new Silindir();
        Silindir silindir2 = new Silindir();
        Küre küre1 = new Küre();
        Küre küre2 = new Küre();
        DikdörtgenPrizma prizma1 = new DikdörtgenPrizma();
        DikdörtgenPrizma prizma2 = new DikdörtgenPrizma();


        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0)
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                nokta1 = new Nokta(x, y);
                GeometrikSekillers.Add(nokta1);

                int a = Convert.ToInt32(textBox13.Text);
                int b = Convert.ToInt32(textBox12.Text);
                int h = Convert.ToInt32(textBox11.Text);
                int w = Convert.ToInt32(textBox10.Text);
                dortgen2 = new Dortgen(a, b, h, w);
                GeometrikSekillers.Add(dortgen2);

            }

            else if(comboBox1.SelectedIndex==1)
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                nokta1 = new Nokta(x, y);
                GeometrikSekillers.Add(nokta1);

                int a = Convert.ToInt32(textBox13.Text);
                int b = Convert.ToInt32(textBox12.Text);
                int r = Convert.ToInt32(textBox8.Text);
                cember2 = new Cember(a, b, r);
                GeometrikSekillers.Add(cember2);

            }

            else if(comboBox1.SelectedIndex==2)
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                nokta1 = new Nokta(x, y);
                GeometrikSekillers.Add(nokta1);

                int a = Convert.ToInt32(textBox13.Text);
                int b = Convert.ToInt32(textBox12.Text);
                int r = Convert.ToInt32(textBox8.Text);
                küre2 = new Küre(a, b, r);
                GeometrikSekillers.Add(küre2);

            }
            else if(comboBox1.SelectedIndex==3)
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                nokta1 = new Nokta(x, y);
                GeometrikSekillers.Add(nokta1);


                int a = Convert.ToInt32(textBox13.Text);
                int b = Convert.ToInt32(textBox12.Text);
                int h = Convert.ToInt32(textBox11.Text);
                int r = Convert.ToInt32(textBox8.Text);
                silindir2 = new Silindir(a, b, r, h);
                GeometrikSekillers.Add(silindir2);

            }

            else if(comboBox1.SelectedIndex==4)
            {

                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                int h1= Convert.ToInt32(textBox3.Text);
                int w1 = Convert.ToInt32(textBox4.Text);
                dortgen1 = new Dortgen(x, y, h1, w1);
                GeometrikSekillers.Add(dortgen1);

                int a = Convert.ToInt32(textBox13.Text);
                int b = Convert.ToInt32(textBox12.Text);
                int h = Convert.ToInt32(textBox11.Text);
                int w = Convert.ToInt32(textBox10.Text);
                dortgen2 = new Dortgen(a, b, h, w);
                GeometrikSekillers.Add(dortgen2);
            }

            else if(comboBox1.SelectedIndex==5)
            {

                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                int h1 = Convert.ToInt32(textBox3.Text);
                int w1 = Convert.ToInt32(textBox4.Text);
                dortgen1 = new Dortgen(x, y, h1, w1);
                GeometrikSekillers.Add(dortgen1);

                int a = Convert.ToInt32(textBox13.Text);
                int b = Convert.ToInt32(textBox12.Text);
                int r = Convert.ToInt32(textBox8.Text);
                cember2 = new Cember(a, b, r);
                GeometrikSekillers.Add(cember2);
            }

            else if(comboBox1.SelectedIndex==6)
            {

                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                int r1 = Convert.ToInt32(textBox6.Text);
                cember1 = new Cember(x, y, r1);
                GeometrikSekillers.Add(cember1);

                int a = Convert.ToInt32(textBox13.Text);
                int b = Convert.ToInt32(textBox12.Text);
                int r = Convert.ToInt32(textBox8.Text);
                cember2 = new Cember(a, b, r);
                GeometrikSekillers.Add(cember2);
            }
            else if(comboBox1.SelectedIndex==7)
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                int r1 = Convert.ToInt32(textBox6.Text);
                int h1 = Convert.ToInt32(textBox3.Text);
                silindir1 = new Silindir(x, y, r1, h1);
                GeometrikSekillers.Add(silindir1);

                int a = Convert.ToInt32(textBox13.Text);
                int b = Convert.ToInt32(textBox12.Text);
                int h = Convert.ToInt32(textBox11.Text);
                int r = Convert.ToInt32(textBox8.Text);
                silindir2 = new Silindir(a, b, r, h);
                GeometrikSekillers.Add(silindir2);
            }
            else if(comboBox1.SelectedIndex==8)
            {

                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                int r1 = Convert.ToInt32(textBox6.Text);
                küre1 = new Küre(x, y, r1);
                GeometrikSekillers.Add(küre1);

                int a = Convert.ToInt32(textBox13.Text);
                int b = Convert.ToInt32(textBox12.Text);
                int r = Convert.ToInt32(textBox8.Text);
                küre2 = new Küre(a, b, r);
                GeometrikSekillers.Add(küre2);

            }
            else if(comboBox1.SelectedIndex==9)
            {

                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                int r1 = Convert.ToInt32(textBox6.Text);
                küre1 = new Küre(x, y, r1);
                GeometrikSekillers.Add(küre1);

                int a = Convert.ToInt32(textBox13.Text);
                int b = Convert.ToInt32(textBox12.Text);
                int h = Convert.ToInt32(textBox11.Text);
                int r = Convert.ToInt32(textBox8.Text);
                silindir2 = new Silindir(a, b, r, h);
                GeometrikSekillers.Add(silindir2);
            }
            else if(comboBox1.SelectedIndex==10)
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                int r1 = Convert.ToInt32(textBox6.Text);
                küre1 = new Küre(x, y, r1);
                GeometrikSekillers.Add(küre1);

                int a = Convert.ToInt32(textBox13.Text);
                int b = Convert.ToInt32(textBox12.Text);
                int h = Convert.ToInt32(textBox11.Text);
                int w = Convert.ToInt32(textBox10.Text);
                prizma2 = new DikdörtgenPrizma(a, b, w, h);
                GeometrikSekillers.Add(prizma2);
            }
            else if(comboBox1.SelectedIndex==11)
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                int h1 = Convert.ToInt32(textBox3.Text);
                int w1 = Convert.ToInt32(textBox4.Text);
                prizma1 = new DikdörtgenPrizma(x, y, w1, h1);
                GeometrikSekillers.Add(prizma1);

                int a = Convert.ToInt32(textBox13.Text);
                int b = Convert.ToInt32(textBox12.Text);
                int h = Convert.ToInt32(textBox11.Text);
                int w = Convert.ToInt32(textBox10.Text);
                prizma2 = new DikdörtgenPrizma(a, b, w, h);
                GeometrikSekillers.Add(prizma2);

            }
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {


            if (comboBox1.SelectedIndex == 0)
            {
                nokta1.Cizdir(e.Graphics);
                dortgen2.Cizdir(e.Graphics);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                nokta1.Cizdir(e.Graphics);
                cember2.Cizdir(e.Graphics);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                nokta1.Cizdir(e.Graphics);
                küre2.Cizdir(e.Graphics);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                nokta1.Cizdir(e.Graphics);
                silindir2.Cizdir(e.Graphics);
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                dortgen1.Cizdir(e.Graphics);
                dortgen2.Cizdir(e.Graphics);
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                dortgen1.Cizdir(e.Graphics);
                cember2.Cizdir(e.Graphics);
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                cember1.Cizdir(e.Graphics);
                cember2.Cizdir(e.Graphics);
            }

            else if (comboBox1.SelectedIndex == 7)
            {
                silindir1.Cizdir(e.Graphics);
                silindir2.Cizdir(e.Graphics);
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                küre1.Cizdir(e.Graphics);
                küre2.Cizdir(e.Graphics);
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                küre1.Cizdir(e.Graphics);
                silindir2.Cizdir(e.Graphics);
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                küre1.Cizdir(e.Graphics);
                prizma2.Cizdir(e.Graphics);
            }
            else if (comboBox1.SelectedIndex == 11)
            {
                prizma1.Cizdir(e.Graphics);
                prizma2.Cizdir(e.Graphics);
            }
           
        }

        private GeometrikSekiller secim;
        private Point lastlocation;
        private void Form1_MouseDown(object sender, MouseEventArgs e)                // Nesnelerin fare ile hareket etmesi için 
        {
            lastlocation = e.Location;
            if (cember1.X <= e.X && e.X <= cember1.X + cember1.R && cember1.Y <= e.Y && e.Y <= cember1.Y + cember1.R / 2)       
            { secim = cember1; }
            else if (cember2.X <= e.X && e.X <= cember2.X + cember2.R && cember2.Y <= e.Y && e.Y <= cember2.Y + cember2.R / 2) 
            { secim = cember2; }
            else if ( silindir1.X <=e.X && e.X<= silindir1.X +2*silindir1.R && silindir1.Y <= e.Y &&e.Y <= silindir1.Y+silindir1.H )
            { secim = silindir1; }
            else if (silindir2.X <= e.X && e.X <= silindir2.X + 2 * silindir2.R && silindir2.Y <= e.Y && e.Y <= silindir2.Y + silindir2.H)
            { secim = silindir2; }
            else if(dortgen1.X<=e.X && e.X <= dortgen1.X+dortgen1.W &&
                dortgen1.Y<=e.Y &&e.Y <= dortgen1.Y+dortgen1.H)
            { secim = dortgen1; }
            else if (dortgen2.X <= e.X && e.X <= dortgen2.X + dortgen2.W &&
                dortgen2.Y <= e.Y && e.Y <= dortgen2.Y + dortgen2.H)
            { secim = dortgen2; }
            else if(Math.Pow(e.X-küre1.X,2)+ Math.Pow(e.Y - küre1.Y, 2)<=Math.Pow(küre1.R,2))
            { secim = küre1; }
            else if (Math.Pow(e.X - küre2.X, 2) + Math.Pow(e.Y - küre2.Y, 2) <= Math.Pow(küre2.R, 2))
            { secim = küre2; }
            else if(e.X>=nokta1.X &&e.X <= nokta1.X+15 && e.Y>= e.Y &&e.Y <=nokta1.Y+15)
            { secim = nokta1; }
            else if(e.X >=prizma1.X &&e.X <= prizma1.X+prizma1.W &&e.Y >= prizma1.Y &&e.Y <=prizma1.Y+prizma1.H)
            {
                secim = prizma1;
            }
            else if (e.X >= prizma2.X && e.X <= prizma2.X + prizma2.W && e.Y >= prizma2.Y && e.Y <= prizma2.Y + prizma2.H)
            {
                secim = prizma2;
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (secim != null && e.Button == MouseButtons.Left)
            {
                int deltaX = e.X - lastlocation.X;
                int deltaY = e.Y - lastlocation.Y;
                secim.X += deltaX;
                secim.Y += deltaY;
                lastlocation = e.Location;
                Invalidate();

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        if (Denetim.Nokta_Dortgen(nokta1, dortgen2))
                            MessageBox.Show("Çarpışma gerçekleşti.");
                        break;
                    case 1:
                        if (Denetim.Nokta_Cember(nokta1, cember2))
                            MessageBox.Show("Çarpışma gerçekleşti.");
                        break;
                    case 2:
                        if (Denetim.Nokta_Küre(nokta1, küre2))
                            MessageBox.Show("Çarpışma gerçekleşti.");
                        break;
                    case 3:
                        if (Denetim.Nokta_Silindir(nokta1, silindir2))
                            MessageBox.Show("Çarpışma gerçekleşti.");
                        break;
                    case 4:
                        if (Denetim.Dortgen_Dortgen(dortgen1, dortgen2))
                            MessageBox.Show("Çarpışma gerçekleşti.");
                        break;
                    case 5:
                        if (Denetim.Dortgen_Cember(dortgen1, cember2))
                            MessageBox.Show("Çarpışma gerçekleşti.");
                        break;
                    case 6:
                        if (Denetim.Cember_Cember(cember1, cember2))
                            MessageBox.Show("Çarpışma gerçekleşti.");
                        break;
                    case 7:
                        if (Denetim.Silindir_Silindir(silindir1, silindir2))
                            MessageBox.Show("Çarpışma gerçekleşti.");
                        break;
                    case 8:
                        if (Denetim.Küre_Küre(küre1, küre2))
                            MessageBox.Show("Çarpışma gerçekleşti.");
                        break;
                    case 9:
                        if (Denetim.Küre_Silindir(küre1, silindir2))
                            MessageBox.Show("Çarpışma gerçekleşti.");
                        break;
                    case 10:
                        if (Denetim.Küre_Prizma(küre1, prizma2))
                            MessageBox.Show("Çarpışma gerçekleşti.");
                        break;
                    case 11:
                        if (Denetim.Prizma_Prizma(prizma1, prizma2))
                            MessageBox.Show("Çarpışma gerçekleşti.");
                        break;


                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Invalidate();
            Temizle();
            if (comboBox1.SelectedIndex == 0)
            {

                textBox3.Visible = false;
                textBox4.Visible = false;
              
                textBox6.Visible = false;
                textBox8.Visible = false;
              
                textBox11.Visible = true;
                textBox10.Visible = true;
                label2.Text = "Nokta";
                label3.Text = "Dikdörtgen";

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label2.Text = "Nokta";
                label3.Text = "Çember";

                textBox3.Visible = false;
                textBox4.Visible = false;
              
                textBox6.Visible = false;
                textBox8.Visible = true;
              
                textBox11.Visible = false;
                textBox10.Visible = false;



            }
            else if (comboBox1.SelectedIndex == 2)
            {

                label2.Text = "Nokta";
                label3.Text = "Küre";


                textBox3.Visible = false;
                textBox4.Visible = false;
              textBox6.Visible = false;
                textBox8.Visible = true;
            
                textBox11.Visible = false;
                textBox10.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                label2.Text = "Nokta";
                label3.Text = "Silindir";

                textBox3.Visible = false;
                textBox4.Visible = false;
           
                textBox6.Visible = false;
                textBox8.Visible = true;
               
                textBox11.Visible = true;
                textBox10.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                label2.Text = "Didörtgen 1";
                label3.Text = "Dikdörtgen 2";


                textBox3.Visible = true;
                textBox4.Visible = true;
          
                textBox6.Visible = false;
                textBox8.Visible = false;
              
                textBox11.Visible = true;
                textBox10.Visible = true;


            }

            else if (comboBox1.SelectedIndex == 5)
            {
                label2.Text = "Dikdörtgen";
                label3.Text = "Çember";

                textBox3.Visible = true;
                textBox4.Visible = true;
         
                textBox6.Visible = false;
                textBox8.Visible = true;
            
                textBox11.Visible = false;
                textBox10.Visible = false;

            }
            else if (comboBox1.SelectedIndex == 6)
            {
                label2.Text = "Çember 1";
                label3.Text = "Çember 2";

                textBox3.Visible = false;
                textBox4.Visible = false;
             
                textBox6.Visible = true;
                textBox8.Visible = true;
             
                textBox11.Visible = false;
                textBox10.Visible = false;
            }

            else if (comboBox1.SelectedIndex == 7)
            {
                label2.Text = "Silindir 1";
                label3.Text = "Silindir 2";

                textBox3.Visible = true;
                textBox4.Visible = false;
        
                textBox6.Visible = true;
                textBox8.Visible = true;
         
                textBox11.Visible = true;
                textBox10.Visible = false;
            }

            else if (comboBox1.SelectedIndex == 8)
            {
                label2.Text = "Küre 1";
                label3.Text = "Küre 2";

                textBox3.Visible = false;
                textBox4.Visible = false;
            
                textBox6.Visible = true;
                textBox8.Visible = true;
               
                textBox11.Visible = false;
                textBox10.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                label2.Text = "Küre";
                label3.Text = "Silindir";

                textBox3.Visible = false;
                textBox4.Visible = false;
         
                textBox6.Visible = true;
                textBox8.Visible = true;
            
                textBox11.Visible = true;
                textBox10.Visible = false;

            }
            else if (comboBox1.SelectedIndex == 10)
            {
                label2.Text = "Küre";
                label3.Text = "Dikdörtgen Prizma";

                textBox3.Visible = false;
                textBox4.Visible = false;
            
                textBox6.Visible = true;
                textBox8.Visible = false;
              
                textBox11.Visible = true;
                textBox10.Visible = true;



            }
            else if (comboBox1.SelectedIndex == 11)
            {
                label2.Text = "Dikdörtgen Prizma 1";
                label3.Text = "Dikdörtgen Prizma 2";

                textBox3.Visible = true;
                textBox4.Visible = true;
         
                textBox6.Visible = false;
                textBox8.Visible = false;
               
                textBox11.Visible = true;
                textBox10.Visible = true;

            }

          
            }

        public void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        
            textBox6.Text = "";
            textBox8.Text = "";
        
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            Refresh();
            GeometrikSekillers.Clear();
            using (Graphics g = this.CreateGraphics())
            {
                g.Clear(this.BackColor);
            }
        }
    }

 
}