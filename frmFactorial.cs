using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialParallel_Tasks
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private async void btnCalcular_Click(object sender, EventArgs e)
        {
            string input = txtNumero.Text;
            var numeros = input.Split(',')
                                .Select(numStr => int.Parse(numStr.Trim()));

            // Usamos Task.WhenAll para calcular el factorial en paralelo
            Task<long>[] tasks = numeros.Select(num => Task.Run(() => CalcularFactorial(num)))
                                         .ToArray();

            long[] resultados = await Task.WhenAll(tasks);

            // Mostrar resultados
            lblResultados.Text = "Resultados:\n";
            for (int i = 0; i < numeros.Count(); i++)
            {
                lblResultados.Text += $"{numeros.ElementAt(i)}! = {resultados[i]}\n";
            }
        }

        private long CalcularFactorial(int num)
        {
            long factorial = 1;
            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
    
}
