using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tb_cep.TextLength != 8)
            {
                lb_aviso.Text = "CEP INVALIDO";
            }
            else
            {
                lb_aviso.Text = "";
                tb_resultado.Text = Formatar(Requisicao(tb_cep.Text));
            }
        }


        //Requisição para a viacep
        public static string Requisicao(string cep)
        {
            var requisicao = WebRequest.CreateHttp($"https://viacep.com.br/ws/{cep}/json/");
            requisicao.Method = "GET";
            var resposta = requisicao.GetResponse();
            var streamDados = resposta.GetResponseStream();
            StreamReader reader = new StreamReader(streamDados);
            string objResposta = reader.ReadToEnd().ToString();
            return objResposta;
        }

        //Modelo de exibição da tela
        public class Modelo
        {
            public string cep { get; set; }
            public string logradouro { get; set; }
            public string bairro { get; set; }
            public string localidade { get; set; }
            public string uf { get; set; }
        }

        //Formatação para o modelo
        public static string Formatar(string Json)
        {
            Modelo modelo = JsonConvert.DeserializeObject<Modelo>(Json);
            string resultado = ($"CEP: {modelo.cep} \r\n" +
                $"Rua: {modelo.logradouro} \r\n" +
                $"Bairro: {modelo.bairro} \r\n" +
                $"Cidade: {modelo.localidade} \r\n" +
                $"Estado: {modelo.uf}");
            return resultado;
        }

    }
}
