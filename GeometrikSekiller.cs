
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3_Form_Sümeyye_Karataş
{
    public class GeometrikSekiller
    {
        public int X { get; set; }
        public int Y { get; set; }

        public GeometrikSekiller()
        {
            X = 0;
            Y = 0;
        }
    }

    public class Cember : GeometrikSekiller
    {

        public int R { get; set; }
        public Cember()
        {
            R = 0;
        }

        public Cember(int x, int y, int r)
        {
            X = x;
            Y = y;
            R = r;
        }

        public void Cizdir(Graphics g)
        {
            g.DrawEllipse(Pens.Black, X - R, Y - R, 2 * R, 2 * R);
        }
    }

    public class Dortgen : GeometrikSekiller
    {
        public int W { get; set; }   //Widht=genişlik
        public int H { get; set; }    //Height=yükseklik

        public Dortgen()
        {
            W = 0;
            H = 0;
        }

        public Dortgen(int x, int y, int h, int w)
        {
            X = x;
            Y = y;
            H = h;
            W = w;
        }

        public void Cizdir(Graphics g)
        {
            g.DrawRectangle(Pens.Black, X, Y, W, H);

        }
    }
    public class Silindir : GeometrikSekiller
    {
        public int R { get; set; }
        public int H { get; set; }

        //public int Z { get; set; }

        public Silindir()
        {
            R = 0;
            H = 0;
            //Z = 0;
        }
        public Silindir(int x, int y, int r, int h)
        {
            X = x;
            Y = y;
            //Z = z;
            R = r;
            H = h;
        }

        public void Cizdir(Graphics g)
        {
            g.DrawEllipse(Pens.Black, X - R, Y - H / 2, 2 * R, R);    //silindirin üst yüzeyi çizilir
            g.DrawEllipse(Pens.Black, X - R, Y + H / 2, 2 * R, R);     // Silindirin alt yüzeyi çizilir
            g.DrawLine(Pens.Black, X - R, Y - H / 2 + R / 2, X - R, Y + H / 2 + R / 2);          //Çemberler çizgilerle birleştiriliyor.
            g.DrawLine(Pens.Black, X + R, Y - H / 2 + R / 2,X+R, Y + H / 2 + R / 2);
        }
    }

    public class DikdörtgenPrizma : GeometrikSekiller
    {
        public int W { get; set; }   //Widht=genişlik
        public int H { get; set; }    //Height=yükseklik
        public int D { get; set; }    //Depht=derinlik

        public DikdörtgenPrizma()
        {
            W = 0;
            H = 0;
            //D = 0;
        }

        public DikdörtgenPrizma(int x, int y, int w, int h/*, int d*/)
        {
            X = x;
            Y = y;
            W = w;
            H = h;
            //D = d;
        }

        public void Cizdir(Graphics g)
        {
            g.DrawRectangle(Pens.Black,X, Y, W, H);
            g.DrawRectangle(Pens.Black, X+W, Y+W, W, H); ;     //Koordinat bilgileri ile ikinci dikdörtgen çizilir

            g.DrawLine(Pens.Black, X,Y, X + W, Y + W);                                //İki dikdörtgenenin köşeleri çizgiler ile birleştirildi
            g.DrawLine(Pens.Black, X + W, Y, X + 2 * W, Y + W);               
            g.DrawLine(Pens.Black, X, Y + H, X + W, Y + W + H);
            g.DrawLine(Pens.Black, X + W, Y + H, X + 2 * W, Y + W + H);


        }
    }
        public class Küre : GeometrikSekiller
        {
            public int R { get; set; }

            public Küre()
            {
                R = 50;      //Burada R 'ye değer atadım. Çünkü drawpie yöntemi değer olmadan çalışmıyor
            }
            public Küre(int x, int y, int r)
            {
                X = x;
                Y = y;
                R = r;
            }

        public void Cizdir(Graphics g)
        {
           
            g.DrawEllipse(Pens.Black, X - R, Y - R, 2 * R, 2 * R);     //Kürenin tamamını çizer
            g.DrawEllipse(Pens.Black, X - R, Y, 2 * R, 0.2f * R);      // Kürenin ekvatorunu çizer
            g.DrawPie(Pens.Black, X - R, Y - R, 2 * R, 2 * R, 0, 180);     //Kürenin yarısını çizer

        }


        }

        public class Nokta : GeometrikSekiller
        {

            public Nokta()
            {
                X = 0;
                Y = 0;

            }
            public Nokta(int x, int y)
            {
                X = x;
                Y = y;
            }

        public void Cizdir(Graphics g)
        {
            g.FillEllipse(Brushes.Black, X, Y, 15, 15);
        }

        }

    }
