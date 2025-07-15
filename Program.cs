using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace EduCSProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string alf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            
            Console.Write("Ваше сообщение: ");
            string SMess = Console.ReadLine();
            Console.Write("Сдвиг: ");
            int sdvg = Convert.ToInt32(Console.ReadLine());
            string neoMess = "";

            string neoAlf = SdvgReform(alf,sdvg);
            char[] messBuf = new char[SMess.Length];
            
            
            for (int i=0; i < SMess.Length; i++)
            {
                if (!" ,.?-_:;!".Contains(SMess[i]))
                {
                    neoMess += neoAlf[alf.IndexOf(SMess[i])];
                }
                else
                {
                    neoMess += SMess[i];
                }
            }
            Console.WriteLine(neoMess);
        }
        private static string SdvgReform(string alfavit, int sdvg)
        {
            string realf = "";
            for (int j= (alfavit.Length) - sdvg; j < (alfavit.Length); j++)
            {
                realf += alfavit[j];
            }
            for (int i=0; i < alfavit.Length-sdvg; i++)
            {
                realf += alfavit[i];
            }
            
            return realf;
        }
    }
}
