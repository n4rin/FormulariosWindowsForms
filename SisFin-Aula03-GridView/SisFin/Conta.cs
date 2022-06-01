using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFin
{
    class Conta
    {
        private int id;
        private string nome;
        private string descricao;
        private int categoria;
        private int status;

        private static List<Conta> _lstContas = new List<Conta>();

        public Conta()
        {

        }

        public Conta(int id, string nome, string descricao, int categoria, int status)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Categoria = categoria;
            this.Status = status;
        }

        public static List<Conta> GeraContas()
        {
            Conta cont1 = new Conta(1, "Combustível", "500 litros de gasosa", 1, 1);
            Conta cont2 = new Conta(2, "Salário", "Salário do Matioli", 2, 1);
            _lstContas.Add(cont1);
            _lstContas.Add(cont2);
            return _lstContas;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public int Status { get => status; set => status = value; }
    }
}
