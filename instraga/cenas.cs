using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instraga
{
    internal static class cenas
    {
        public struct info
        {
            public string utilizador;
            public string password;
            public string nome;
            public string bio;
            public DateTime data;
            public string imagem;
        }
        public static info user = new info();
        public static List<info> users = new List<info>();
    }
}
