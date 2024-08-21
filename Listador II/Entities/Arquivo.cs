using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Listador.Entities
{
        public class Arquivo
        {
                public string Path { get; set; }
                public List<Linha> Linhas { get; set; } = new List<Linha>();
                public string Header { get; private set; }
                public string Trailer { get; private set; }

                public Arquivo(string path, string header, string trailer)
                {
                        Path = path;
                        Header = header;
                        Trailer = trailer;
                }

                public Arquivo()
                {
                        Path = @"C:\Users\bielm\Documents\VS\Listador\CEP851608.txt";
                }

                public void ReadFile()
                {
                        string[] tempLines = File.ReadAllLines(Path);
                        foreach (string line in tempLines)
                        {
                                Linha l = new Linha(line);
                                Linhas.Add(l);
                        }
                        FillDataLines();
                }

                private void FillDataLines()
                {
                        DataSet Positions = new DataSet();
                        Positions.ReadXml("C:\\Users\\bielm\\source\\repos\\Listador II\\Listador II\\Utils\\CodigoDeBarras_Positions.xml");

                        foreach (Linha l in Linhas)
                        {
                                if (l.FullLine.Substring(0, 1) != "G") continue;

                                int tInt;
                                double tDouble;
                                DateTime tDateTime;
                                string tString;

                                int.TryParse(l.FullLine.Substring(int.Parse(Positions.Tables["Num"].Rows[0][0].ToString()),
                                                                  int.Parse(Positions.Tables["Num"].Rows[0][1].ToString())),
                                                                  out tInt);
                                l.Num = tInt;

                                int.TryParse(l.FullLine.Substring(int.Parse(Positions.Tables["CodFormaArrecadacao"].Rows[0][0].ToString()),
                                                                  int.Parse(Positions.Tables["CodFormaArrecadacao"].Rows[0][1].ToString())),
                                                                  out tInt);
                                l.CodFormaArrecadacao = tInt;

                                if (l.CodFormaArrecadacao == 9)
                                {
                                        int.TryParse(l.FullLine.Substring(int.Parse(Positions.Tables["Ligacao_Pix"].Rows[0][0].ToString()),
                                                                          int.Parse(Positions.Tables["Ligacao_Pix"].Rows[0][1].ToString())),
                                                                          out tInt);
                                }
                                else
                                {
                                        int.TryParse(l.FullLine.Substring(int.Parse(Positions.Tables["Ligacao_Cod_Barras"].Rows[0][0].ToString()),
                                                                          int.Parse(Positions.Tables["Ligacao_Cod_Barras"].Rows[0][1].ToString())),
                                                                          out tInt);
                                }

                                l.Ligacao = tInt;

                                double.TryParse(l.FullLine.Substring(int.Parse(Positions.Tables["Valor"].Rows[0][0].ToString()),
                                                                  int.Parse(Positions.Tables["Valor"].Rows[0][1].ToString())),
                                                                  out tDouble);
                                l.Valor = tDouble / 100;

                                tString = l.FullLine.Substring(int.Parse(Positions.Tables["DtRecebimento"].Rows[0][0].ToString()),
                                                                  int.Parse(Positions.Tables["DtRecebimento"].Rows[0][1].ToString()));
                                l.DtRecebimento = AdjustDate(tString, true);

                                tString = l.FullLine.Substring(int.Parse(Positions.Tables["DtRepasse"].Rows[0][0].ToString()),
                                                                  int.Parse(Positions.Tables["DtRepasse"].Rows[0][1].ToString()));
                                l.DtRepasse = AdjustDate(tString, true);

                                tString = l.FullLine.Substring(int.Parse(Positions.Tables["DtRefFat"].Rows[0][0].ToString()),
                                                                  int.Parse(Positions.Tables["DtRefFat"].Rows[0][1].ToString()));
                                tString = "01/" + tString.Substring(0, 2) + "/" + tString.Substring(2, 4);
                                DateTime.TryParse(tString, out tDateTime);
                                l.DtRefFat = tDateTime;

                                double.TryParse(l.FullLine.Substring(int.Parse(Positions.Tables["Tarifa"].Rows[0][0].ToString()),
                                  int.Parse(Positions.Tables["Tarifa"].Rows[0][1].ToString())),
                                  out tDouble);
                                l.Tarifa = tDouble / 100;

                                tString = l.FullLine.Substring(int.Parse(Positions.Tables["Agencia"].Rows[0][0].ToString()),
                                                                  int.Parse(Positions.Tables["Agencia"].Rows[0][1].ToString()));
                                l.Agencia = tString;
                        }
                }

                private DateTime AdjustDate(string date, bool inverse = false)
                {

                        if (!inverse)
                        {
                                DateTime dt = new DateTime(int.Parse(date.Substring(4, 4)),
                                        int.Parse(date.Substring(2, 2)), 
                                        int.Parse(date.Substring(0, 2)));

                                return dt;
                        }
                        else
                        {
                                DateTime dt = new DateTime(int.Parse(date.Substring(0, 4)),
                                        int.Parse(date.Substring(4, 2)),
                                        int.Parse(date.Substring(6, 2)));

                                return dt;
                        }

                }
        }
}
