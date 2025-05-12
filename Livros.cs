using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorME
{
    [Serializable]
    public class Livros
    {

            public Livros()
            {
                authors = new List<string>(); //autores init no construtor
            }
            public string title { get; set; }
            public List<string> authors { get; set; }
            public string publishedDate { get; set; }
            public string pageCount { get; set; }
            public string description { get; set; }
            public string blurb { get; set; }

    }
}
