﻿using Listador.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listador_II
{
        public static class Program
        {
                /// <summary>
                /// Ponto de entrada principal para o aplicativo.
                /// </summary>
                [STAThread]
                static void Main()
                {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new Form1());
                        Arquivo a = new Arquivo();
                        a.ReadFile();
                }
        }
}
