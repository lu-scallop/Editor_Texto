using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;

namespace Editor_Texto
{
    internal class Banco
    {
        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "bd_editor-texto.db";
        public static string caminhoBanco = @"C:\Users\Pichau\source\repos\Editor_Texto\banco\";

        private static SQLiteConnection conexao;

        public static SQLiteConnection Conexao()
        {
            if (!System.IO.Directory.Exists(caminhoBanco))
            {
                System.IO.Directory.CreateDirectory(caminhoBanco);
                
            }            
            var caminhoCompletoBanco = System.IO.Path.Combine(caminhoBanco, nomeBanco);
            conexao = new SQLiteConnection("Data Source=" + caminhoCompletoBanco);
            conexao.Open();
            return conexao;
        }
        public static void NovaNota(Anotacao a)
        {
            try
            {
                var vcon = Conexao();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_anotacao (T_TEXTO_ANOTACAO, T_FONTE_ANOTACAO, T_ALINHAMENTO_ANOTACAO, T_CORTEXTO_ANOTACAO) VALUES (@texto, @fonte, @alinhamento, @cor)";
                cmd.Parameters.AddWithValue("@texto", a.Texto);
                cmd.Parameters.AddWithValue("@fonte", (Enum)a.Fonte);
                cmd.Parameters.AddWithValue("@alinhamento", a.Alinhamento);
                cmd.Parameters.AddWithValue("@cor", ColorTranslator.ToHtml(a.CorTexto));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Texto salvo!");
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ////FUNÇÕES DO FORM CARREGAR ANOTAÇÕES
        public static DataTable ObterNotas()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = Conexao();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT N_ID_ANOTACAO as 'ID', T_TEXTO_ANOTACAO as 'Seu texto', T_FONTE_ANOTACAO as 'Fonte', T_ALINHAMENTO_ANOTACAO as 'Alinhamento', T_CORTEXTO_ANOTACAO as 'CorTexto' FROM tb_anotacao";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable DeletarNotas(int i)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = Conexao();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_anotacao WHERE N_ID_ANOTACAO=" + i;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
