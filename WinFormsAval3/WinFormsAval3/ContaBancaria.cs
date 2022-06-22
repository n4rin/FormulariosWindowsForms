using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAval3
{
    class ContaBancaria
    {
        private String codigoConta;
        private int tipo; //0 = simples; 1 = especial
        private double saldo;
        private double limite;

        public ContaBancaria()
        {
        }

        public ContaBancaria(string codigoConta, int tipo, double saldo, double limite)
        {
            this.codigoConta = codigoConta;
            this.tipo = tipo;
            this.saldo = saldo;
            this.limite = limite;
        }

        public int Tipo { get => tipo; set => tipo = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public double Limite { get => limite; set => limite = value; }
        public string CodigoConta { get => codigoConta; set => codigoConta = value; }

        public static List<ContaBancaria> geraContas()
        {
            List<ContaBancaria> _listContas = new List<ContaBancaria>();
            _listContas.Add(new ContaBancaria("1-123", 0, 1000, 0));
            _listContas.Add(new ContaBancaria("1-321", 0, 5500, 0));
            _listContas.Add(new ContaBancaria("2-500", 1, 58900, 1500));
            _listContas.Add(new ContaBancaria("2-501", 1, 103400, 3500));
            return _listContas;
        }

    }
}
