using ExemploMVC02.Database;
using ExemploMVC02.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExemploMVC02.Repository
{
    public class RecrutadoraRepository
    {
        public List<Recrutadora> ObterTodos()
        {
            List<Recrutadora> recrutadoras = new List<Recrutadora>();
            SqlCommand command = new BancoDados().ObterConexao();
            command.CommandText = "SELECT id, nome, cpf, tempo_empresa, salario FROM recrutadoras";
            DataTable tabela = new DataTable();
            tabela.Load(command.ExecuteReader());
            foreach (DataRow linha in tabela.Rows) 
            {
                Recrutadora recrutadora = new Recrutadora()
                {
                    Id = Convert.ToInt32(linha[0].ToString()),
                    Nome = linha[1].ToString(),
                    CPF = linha[2].ToString(),
                    TempoEmpresa = Convert.ToByte(linha[3].ToString()),
                    Salario = Convert.ToDecimal(linha[4].ToString())
                };
                recrutadoras.Add(recrutadora);
            }
            return recrutadoras;
        }

        public int Cadastrar(Recrutadora recrutadora)
        {
            SqlCommand command = new BancoDados().ObterConexao();

            command.CommandText = @"INSERT INTO recrutadoras (nome, slario, cpf, tempo_empresa) 
            OUTPUT INSERTED.ID
            VALUES (@NOME, @SALARIO, @CPF, @TEMPO_EMPRESA)";
            command.Parameters.AddWithValue("@NOME", recrutadora.Nome);
            command.Parameters.AddWithValue("@SALARIO", recrutadora.Salario);
            command.Parameters.AddWithValue("@CPF", recrutadora.CPF);
            command.Parameters.AddWithValue("@TEMPO_EMPRESA", recrutadora.TempoEmpresa);
            int id = Convert.ToInt32(command.ExecuteScalar().ToString());
            return 0;
        }

        public bool Alterar(Recrutadora recrutadora)
        {
            return false;
        }

        public bool Excluir(int id)
        {
            return false;
        }

        public Recrutadora ObterPeloId(int id)
        {
            Recrutadora recrutadora = null;
            return recrutadora;
        }
    }
}