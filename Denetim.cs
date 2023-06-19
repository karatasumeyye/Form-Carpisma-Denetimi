using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3_Form_Sümeyye_Karataş
{
    public class Denetim
    {
        public static bool Nokta_Dortgen(Nokta n1, Dortgen di1)
        {

            float di1Left = di1.X - di1.W / 2;                 //Dikdörtgenin sol,sağ,üst ve alt köşeleri hesaplanır ve noktanın bu koordinatlar içinde olup olmadığı kontrol edilir.
            float di1Right = di1.X + di1.W / 2;
            float di1Top = di1.Y + di1.H / 2;
            float di1Bottom = di1.Y - di1.H / 2;


            bool result1 = di1Bottom <= n1.X && n1.X <= di1Top;        // Noktanın bu koordinatlar içinde olup olmadığı kontrol edilir.
            bool result2 = di1Left <= n1.Y && n1.Y <= di1Right;
            if (result1 && result2)
                return true;
            else
                return false;


        }

        public static bool Nokta_Cember(Nokta p1, Cember c1)
        {
            float d = (float)Math.Sqrt(Math.Pow((p1.X - c1.X), 2) + Math.Pow((p1.Y - c1.Y), 2));       //noktanın çemberin merkezine olan uzaklığı hesaplandı.                            

            if (d <= c1.R)                    //yarıçap ve uzaklık karşılaştırılıyor.
                return true;
            else
                return false;
        }

        public static bool Dortgen_Dortgen(Dortgen di1, Dortgen di2)
        {
            float di1Left = di1.X - di1.W / 2;                 //Dikdörtgenin sol,sağ,üst ve alt köşeleri hesaplanır ve noktanın bu koordinatlar içinde olup olmadığı kontrol edilir.
            float di1Right = di1.X + di1.W / 2;
            float di1Top = di1.Y + di1.H / 2;
            float di1Bottom = di1.Y - di1.H / 2;

            float di2Left = di2.X - di2.W / 2;
            float di2Right = di2.X + di2.W / 2;
            float di2Top = di2.X + di2.H / 2;
            float di2Bottom = di2.X - di2.H / 2;

            bool result1 = (di1Bottom <= di2Top && di1Bottom >= di2Bottom) || (di2Bottom <= di1Top && di2Bottom >= di1Bottom);
            bool result2 = (di1Left <= di2Right && di1Left >= di2Left) || (di2Left <= di1Right && di2Left >= di1Left);

            if (result1 && result2)
                return true;
            else
                return false;
        }

        public static bool Dortgen_Cember(Dortgen di1, Cember c1)
        {
            float distx = Math.Abs(c1.X - di1.X);    // Dairenin merkezi ile dikdörtgenin merkezi arasındaki x ve y farkının mutlak değeri hesaplanır.
            float disty = Math.Abs(c1.Y - di1.Y);

            if (distx > (di1.W / 2 + c1.R))
                return false;
            if (disty > (di1.H / 2 + c1.R))
                return false;
            if (distx <= (di1.W / 2))
                return true;
            if (disty <= (di1.H / 2))
                return true;

            var hypot = Math.Sqrt(Math.Pow((distx - di1.W / 2), 2) + Math.Pow((disty - di1.H / 2), 2));   //Dik merkezden dik köşeye bir çizginin çember yarıçapı kadar uzatılmasıyla ,çemberin merkezinin çizgi üzerinde olup olmadığı hesaplanır.
            return (hypot <= c1.R);
        }


        public static bool Cember_Cember(Cember c1, Cember c2)
        {

            float d = (float)Math.Sqrt(Math.Pow((c1.X - c2.X), 2) + Math.Pow((c1.Y - c2.Y), 2));

            if ((c1.R + c2.R) > d)
                return true;
            else
                return false;

        }

        public static bool Nokta_Küre(Nokta n1, Küre da1)
        {
            // nokta ve kürenin merkezleri arasındaki mesafe hesaplanır
            var d = Math.Sqrt(Math.Pow((n1.X - da1.X), 2) + Math.Pow((n1.Y - da1.Y), 2));

            if (d <= da1.R)                 // uzaklık ve yarıçap karşılaştırılır
                return true;
            else
                return false;
        }



        public static bool Nokta_Silindir(Nokta n1, Silindir s1)
        {
            //silindirin merkezi ile nokta arası mesafe heaplanır
            var d = Math.Sqrt(Math.Pow((n1.X - s1.X), 2) + Math.Pow((n1.Y - s1.Y), 2));

            //mesafenin silindir yarıçapından küçük olup olmadığı kontrol edilir
            if (d <= s1.R)
                return true;

            //Noktanın silindirin üst veya alt diski içinde olup olmadığı kontrol edilmesi

            var d1 = Math.Abs(n1.Y - s1.Y);
            if (d1 <= s1.R && d1 <= s1.H / 2)
                return true;

            else
                return false;




        }

        public static bool Silindir_Silindir(Silindir s1, Silindir s2)
        {
            var d = Math.Sqrt(Math.Pow((s1.X - s2.X), 2) + Math.Pow((s1.Y - s2.Y), 2));

            if (d <= s1.R + s2.R)
                return true;
            else
                return false;



        }

        public static bool Küre_Küre(Küre da1, Küre da2)
        {
            //İki kürenin merkezleri arasındaki mesafe hesaplanır
            var d = Math.Sqrt(Math.Pow((da1.X - da2.X), 2) + Math.Pow((da1.Y - da2.Y), 2));

            if (da1.R + da2.R >= d)
                return true;
            else
                return false;

        }


        public static bool Küre_Silindir(Küre da1, Silindir s1)
        {
            float distX = Math.Abs(s1.X - da1.X);
            float distY = Math.Abs(s1.Y - da1.Y);
            // float distZ = Math.Abs(s1.Z - da1.Z);

            if (distX > (s1.R + da1.R) || distY > (s1.H / 2 + da1.R))
                return false;
            else if (distX <= s1.R)
                return true;
            else
            {
                var d = Math.Pow((distX - s1.R), 2);
                if (d <= (da1.R * da1.R - distY * distY))
                    return true;
                else
                    return false;

            }

        }

        public static bool Küre_Prizma(Küre da1, DikdörtgenPrizma pr1)
        {
            // Kürenin merkezi ile prizmanın kenarları arasındaki uzaklıklar hesaplanır ve kürenin prizmaya en yakın noktası bulunur.
            if (da1.X + da1.R < pr1.X - pr1.W / 2 ||
                da1.X - da1.R > pr1.X + pr1.W / 2 ||
                da1.Y + da1.R < pr1.Y - pr1.H / 2 ||
                da1.Y - da1.R > pr1.Y + pr1.H / 2)

                return false;      // Küre dikdörtgen prizmanın sınırları dışındadır,çarpışma yok
            else
                return true;
        }

        public static bool Prizma_Prizma(DikdörtgenPrizma pr1, DikdörtgenPrizma pr2)
        {
            // x,y,z koordinatlarının min ve max değerleri hesaplaanır

            float p1_xmin = pr1.X - pr1.W / 2;
            float p1_xmax = pr1.X + pr1.W / 2;
            float p1_ymin = pr1.Y - pr1.H / 2;
            float p1_ymax = pr1.Y + pr1.H / 2;



            float p2_xmin = pr2.X - pr2.W / 2;
            float p2_xmax = pr2.X + pr2.W / 2;
            float p2_ymin = pr2.Y - pr2.H / 2;
            float p2_ymax = pr2.Y + pr2.H / 2;


            //Koordinatların sınırlar içinde olup olmadığı denetlenir

            if (p1_xmin <= p2_xmax && p1_xmax >= p2_xmin &&
                p1_ymin <= p2_ymax && p1_ymax >= p2_ymin)

                return false;
            else
                return true;

        }

    }
}
