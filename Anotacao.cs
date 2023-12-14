using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor_Texto
{
    public class Anotacao
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public FontStyle Fonte { get; set; }
        public HorizontalAlignment Alinhamento { get; set; }
        public Color CorTexto { get; set; }
    }
}
