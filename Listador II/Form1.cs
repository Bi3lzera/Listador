using Listador.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listador_II
{
        public partial class Form1 : Form
        {
                public Form1()
                {
                        InitializeComponent();
                }

                private void Form1_Load(object sender, EventArgs e)
                {
                        Arquivo a = new Arquivo();
                        a.ReadFile();

                        foreach (Linha l in a.Linhas)
                        {
                                dataGridView1.Rows.Add(l.Num,
                                        l.Ligacao,
                                        l.Valor,
                                        l.DtRecebimento.ToString("dd/MM/yyyy"),
                                        l.DtRepasse.ToString("dd/MM/yyyy"),
                                        l.DtRefFat.ToString("MM/yyyy"),
                                        l.Tarifa,
                                        l.CodFormaPagamento,
                                        l.CodFormaArrecadacao,
                                        l.Agencia);
                        }
                }
        }
}
