using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamAsmaca
{
    public class AdamAsmacaOperations
    {
        List<string> dictionary = new List<string>
        {
            "araba","anahtar","kestane","davul","balıkçı","yazılım","bilgisayar","televizyon","kararlılık","alçakgönüllülük"
        };
        public string ChooseWord() 
        {
            Random r = new Random();
            return dictionary[r.Next(0, 9)];
        }
        
        public string Transform(string s)
        {
            string gösterilen = "";
            for (int i = 0; i < s.Length; i++)
            {
                gösterilen += "-";
            }
            return gösterilen;
        }

        public string HarfAcma(string kelime,string sifreli, char c)
        {
            if (kelime.Contains(c))
            {
                sifreli = sifreli.Trim();
                for (int i = 0; i < kelime.Length; i++)
                {
                    if (kelime[i]==c)
                    {
                        StringBuilder sb = new StringBuilder(sifreli);
                        sb[i] = c;
                        sifreli = sb.ToString();
                    }    
                }
            }
            return sifreli;
        }
        public string BoslukKoyma(string d)
        {
            string result = "";
            for (int i = 0; i < d.Length; i++)
            {
                result += d[i] + " ";
            }
            return result;
        }

    }
}
