using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szokartya
{
    static class ExtensionsClass
    {
        private static Random rng = new Random();

        /// <summary>
        /// Ez úgy működik, hogy random számú list index value-iket helycserél egy segédváltozó segítségével.
        /// Kiválaszt egy random számmal egy indexet ez a "k". 
        /// 
        /// List<string> lista = new List<string>() { "A", "B", "C", "D", "E" };
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;     // 5db van benne
            while (n > 1)
            {
                n--;    // 5 -1 akkor 4
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
