using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listador.Entities
{
        public class Linha
        {
                public string FullLine { get; set; }
                public int Num { get; set; }
                public int Ligacao { get; set; }
                public double Valor { get; set; }
                public DateTime DtRecebimento { get; set; }
                public DateTime DtRepasse { get; set; }
                public DateTime DtRefFat { get; set; }
                public double Tarifa { get; set; }
                public int CodFormaPagamento { get; set; }
                public int CodFormaArrecadacao { get; set; }
                public string Agencia { get; set; }

                public Linha(string fullLine)
                {
                        FullLine = fullLine;
                }

                public Linha() { }

                public Linha(int num, int ligacao, double valor, DateTime dtRecebimento, DateTime dtRepasse, DateTime dtRefFat, double tarifa, int codFormaPagamento, string agencia)
                {
                        Num = num;
                        Ligacao = ligacao;
                        Valor = valor;
                        DtRecebimento = dtRecebimento;
                        DtRepasse = dtRepasse;
                        DtRefFat = dtRefFat;
                        Tarifa = tarifa;
                        CodFormaPagamento = codFormaPagamento;
                        Agencia = agencia;
                }
        }
}
