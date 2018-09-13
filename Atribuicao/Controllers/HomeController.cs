using Atribuicao.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
//using Atribuicao.Models.Atribuicao;

namespace Atribuicao.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            /*
            List<estado> listaEstado = new List<estado>();
            using (AtribuicaoDBContext atdb = new AtribuicaoDBContext())
            {
                listaEstado = atdb.estado.ToList();
            }  
            */
                /*
                 MySqlConnection conexao = new MySqlConnection("Server=localhost;Database=sakila;Uid=root;Pwd=DeNit_01;");
                 conexao.Open();
                 MySqlCommand comando = new MySqlCommand("select * from actor", conexao);
                 MySqlDataReader leitor=comando.ExecuteReader();
                 List<Ator> lista = new List<Ator>();

                 while(leitor.Read())
                 {
                     Ator novo = new Ator();
                     novo.idAtor=1;
                     novo.firstName=leitor["first_name"].ToString();
                     novo.lastName = leitor["last_name"].ToString();
                     novo.lastUpdate = DateTime.Now;
                     lista.Add(novo);
                 }

                 leitor.Close();
             conexao.Close();*/

                return View(/*listaEstado*/);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}