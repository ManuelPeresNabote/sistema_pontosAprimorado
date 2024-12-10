using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entidades
{
    public class EntPontos
    {
        public int PONTO_ID {  get; set; }
        public int FUNCIONARIO_ID { get; set; }
        public DateTime DATA {  get; set; }
        public TimeSpan HORA_ENTRADA { get; set; }
        public TimeSpan HORA_SAIDA { get; set; }
        public string NOME { get; set; }
        public object[] Linha()
        {
            return new object[] { PONTO_ID, FUNCIONARIO_ID, DATA,HORA_ENTRADA,HORA_SAIDA,NOME};
        }

    }
}
