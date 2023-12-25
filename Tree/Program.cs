using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bt = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            TreeSoldanSagaOkuma(bt, 0);
            Console.WriteLine("-------------------------- node adedi --------------------");
            Console.WriteLine(TreeNodelarınSayısınıBulmak(bt, 0));
            Console.WriteLine("------------------------ Search işlemi ----------------------");
            Console.WriteLine(TreeSearchİslemi(bt,0,7));
            Console.WriteLine("------------------------ Max Node Data Değeri ----------------------");
            Console.WriteLine(TreeMaxNodeDataDegeri(bt,0));
            Console.WriteLine("------------------------ Max Node Data Değeri ----------------------");           
            int[] sıralıbt = { 55,23,100,12,28,60,110,5,13,26,29,70,105 };
            Console.WriteLine(TreeSıralıDatadaSearch(sıralıbt,0,7));
            Console.WriteLine("------------------------ Tree Eleman ekleme ----------------------");
            int[] bt2 = new int[10];
            TreeElemanEkleme(bt2,0,11);
            TreeElemanEkleme(bt2,1,12);
            TreeElemanEkleme(bt2,2,13);
            TreeElemanEkleme(bt2,3,14);
            TreeElemanEkleme(bt2,4,15);
            TreeElemanEkleme(bt2,5,16);
            TreeElemanEkleme(bt2,6,17);
            TreeSoldanSagaOkuma(bt2, 0); // boş olan yerler 0 olarak okundu
            Console.WriteLine("------------------------ Tree sıraya Eleman ekleme ----------------------");
            TreeDatayıSırayaEklemek(bt2, 0, 20);

            foreach (int item in bt2)
            {
                if (item != 0)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("------------------------ Tree sag sol yazdırma ----------------------");
            TreeSagSolYazdırma(bt, 0);
            Console.WriteLine("------------------------ binary tree'ye çevirme yazdırma ----------------------");

            int[] array = { 1, 2, 3, 4, 5, 6, 7 };

            MyBinaryTree binaryTree = null;

            TreeConvertToBinaryTree(array, 0, ref binaryTree);

            // Oluşturulan ikili ağacı yazdırma
            BinaryTreeYazdırma(binaryTree);


            Console.ReadLine();
            Console.ReadKey();

        }
        static void TreeSoldanSagaOkuma(int[] bt, int indis) // atilla hocanının ders1 dediği
        {
            if (indis >= bt.Length) return;

            Console.WriteLine(bt[indis]);
            TreeSoldanSagaOkuma(bt, indis * 2 + 1);
            TreeSoldanSagaOkuma(bt, indis * 2 + 2);
        }
        static int TreeNodelarınSayısınıBulmak(int[] bt, int indis) // atilla hocanın ders2 dediği
        {

            int a = 0;
            int b = 0;
            int c = indis * 2 + 1;
            if (c < bt.Length)
                a = 1 + TreeNodelarınSayısınıBulmak(bt, c);
            if (c + 1 < bt.Length)
                b = 1 + TreeNodelarınSayısınıBulmak(bt, c + 1);
            if (indis == 0) a++;
            return a + b;

        }
        static int TreeSearchİslemi(int[] bt, int indis, int data) // Atilla hocanın ders3 dediği
        { // search yapalım
            if (indis >= bt.Length) return 0;
            if (bt[indis] == data) return 1;
            // if (seviye==2)   return bt[indis]
            return TreeSearchİslemi(bt, indis * 2 + 1, data) +
                   TreeSearchİslemi(bt, indis * 2 + 2, data);

        }
        static int TreeMaxNodeDataDegeri(int[] bt, int indis) // Atilla hocanın ders4 dediği
        {//  max değer bul
            if (indis >= bt.Length) return 0;

            int a = TreeMaxNodeDataDegeri(bt, indis * 2 + 1);
            int b = TreeMaxNodeDataDegeri(bt, indis * 2 + 2);
            int c = 0;
            if (a > b) c = a; else c = b;
            if (bt[indis] > c) c = bt[indis];
            return c;
        }
        static int TreeSıralıDatadaSearch(int[] bt, int indis, int data) // Atilla hocanın ders5 dediği
        {
            if (indis >= bt.Length) return 0;
            if (bt[indis] == data) return 1;
            int a = 0;
            if (data > bt[indis])
                a = TreeSıralıDatadaSearch(bt, indis * 2 + 2, data);
            else a = TreeSıralıDatadaSearch(bt, indis * 2 + 1, data);

            return a;
        }

        static void TreeElemanEkleme(int[] bt, int indis, int data) // atilla hocanın ders6 dediği
        {
            if (indis >= bt.Length) return;
            int a = indis * 2 + 1;
            if (bt[indis] == 0) { bt[indis] = data; return; }

            if (bt[indis] < data) a++;
            if (a >= bt.Length) return;
            if (bt[a] == 0) { bt[a] = data; return; }
            else TreeElemanEkleme(bt, a, data);

            //if (bt[indis] >= data)
            //{ if (a >= bt.Length) return;
            //    if (bt[a] == 0) { bt[a] = data; return; }
            //    else ders6(bt, a, data);
            //}
            //else { a++;
            //    if (a >= bt.Length) return;
            //    if (bt[a] == 0) { bt[a] = data; return; }
            //    else ders6(bt, a, data);
            //}
        }
        static void TreeDatayıSırayaEklemek(int[] bt,int indis, int data) // ders6 daki yorum satırı olan yer BUNA BAKACAĞIM TAM ÇALIŞMIYOR
        {
            int a = indis * 2 + 1;

            if (bt[indis] >= data)
            {
                if (a >= bt.Length) return;
                if (bt[a] == 0) { bt[a] = data; return; }
                else TreeDatayıSırayaEklemek(bt, a, data);
            }
            else
            {
                a++;
                if (a >= bt.Length) return;
                if (bt[a] == 0) { bt[a] = data; return; }
                else TreeDatayıSırayaEklemek(bt, a, data);
            }

        }
        static void TreeSagSolYazdırma(int[] bt, int indis) // atilla hoca buna ders7 demiş
        {
            if (indis >= bt.Length) return;

            TreeSagSolYazdırma(bt, 2 * indis + 2);
            if (bt[indis] != 0) Console.WriteLine(bt[indis]);
            TreeSagSolYazdırma(bt, 2 * indis + 1);
        }
        class MyBinaryTree
        {
            public int data;
            public MyBinaryTree left;
            public MyBinaryTree right;
        }
        static MyBinaryTree TreeConvertToBinaryTree(int[] bt, int indis, ref MyBinaryTree btl) // atilla hoca ders8 dediği
        {
            if (indis >= bt.Length) return null;
            MyBinaryTree tmp = new MyBinaryTree();
            tmp.data = bt[indis];
            if (btl == null) btl = tmp;
            tmp.left = TreeConvertToBinaryTree(bt, indis * 2 + 1, ref btl);
            tmp.right = TreeConvertToBinaryTree(bt, indis * 2 + 2, ref btl);
            return tmp;
        }
        static void BinaryTreeYazdırma(MyBinaryTree mbt)
        {
            if (mbt == null) return;

            BinaryTreeYazdırma(mbt.right);
            if (mbt.data != 0) Console.WriteLine(mbt.data);
            BinaryTreeYazdırma(mbt.left);
        }

    }
}
