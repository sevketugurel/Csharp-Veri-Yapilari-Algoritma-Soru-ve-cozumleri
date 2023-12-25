using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postfix_infix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Postfix infix kodu sonuç bulma.
            #region
            //string s = "1234+**";
            //Stack<int> st = new Stack<int>();
            //string op = "/*+-";
            //int result = 0;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (op.IndexOf(s[i]) == -1)
            //    {
            //        st.Push(s[i] - '0'); continue;
            //    }
            //    int op2 = st.Pop();
            //    int op1 = st.Pop();
            //    if (s[i] == '*') result = op1 * op2;
            //    if (s[i] == '/') result = op1 / op2;
            //    if (s[i] == '+') result = op1 + op2;
            //    if (s[i] == '-') result = op1 - op2;
            //    st.Push(result);
            //}
            //Console.WriteLine(st.Pop());
            //Console.WriteLine(result);
            //return;
            #endregion
            //string içerisinde en fazla kullanılan karakteri bulma
            //string st = "atilla erguzen akhisar";
            //int ebs = 0;
            //int[] dz = new int[50];
            //for (int i = 0; i < st.Length; i++)
            //{
            //    dz[st[i] - 'a']++;
            //    if (dz[st[i] - 'a'] > ebs)
            //        ebs = dz[st[i] - 'a'];
            //    //değişken isimleri bir değil de çok karakterli olursa postfix infix nasıl çözeriz.
            //    //Postfix te operatörler dışında bir işaret(soru işareti, ünlem vb.) ile birden fazla karakter barındıran değişkenleri ayırabiliriz.
            //    //en? boy?yukseklik * +Buradan sonra bunları bir string diziye ata
            //    //enboyyukseklikdegeralanhacim
            //    //en,boy,yukseklik,deger,alan hacim
            //    s[0] = "en"; s[1] = "boy; s[2]="yukseklik; s[3] = "alan"; s[4] = "hacim"; olarak tanımlanmıştır.
            //}

            //s1ve s2 için en çok kullanılan değişkeni bulma (normal çözüm ve recursive çözüm yap.)
            //string s1 = "alanenboyyukseklikalanenboyboy";
            //string s2 = "alan-en-boy-yukseklik";
            //string s3 = "abc;def;gef;hjk;"; //noktalı virgülle ayrılmış kelimeleri ekrana yazdır.
            //string kelime = "";
            //for (int i = 0; i < s3.Length; i++)
            //{
            //    if (s3[i] == ';')
            //    {
            //        Console.WriteLine(kelime);
            //        kelime = ""; continue;
            //    }
            //    kelime = kelime + s3[i];

            //}
            //string içinde ab var mı diye arama yapan.
            //string st3 = "kgfdllfdgkfdlgkfablgkfg";
            //int state = 0;
            //for (int j = 0; j < st3.Length; j++)
            //{
            //    if (st3[j] == 'a') state = 1;
            //    else if (st3[j] == 'b' && state == 1) Console.WriteLine("ab içeriyor");
            //    else state = 0;

            //}
        }
    }
}
