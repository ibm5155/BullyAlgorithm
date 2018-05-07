using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullyAlg
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
             * Criado por Lucas Zimerman
             * 
             * Implementação do Algoritmo Bully para eleição de um líder em um grupo de n processos 
             * distribuídos. Os processos podem entrar e sair (voluntária ou involuntariamente)
             *  a qualquer momento do grupo. A comunicação entre os processos deve ser implementada 
             *  com uso do protocolo UDP. Equipes de 2 a 4 alunos. Prazo: 17/05.
             * 
             */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
