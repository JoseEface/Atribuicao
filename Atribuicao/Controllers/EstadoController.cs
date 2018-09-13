using Atribuicao.Models;
using Atribuicao.Models.Atribuicao;
using Atribuicao.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Atribuicao.Controllers
{
    public class EstadoController : Controller
    {
        // GET: Estado
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult BuscaEstado(string nome, string sigla)
        {            
            List<Estado> listaEstados = new List<Estado>();
            IQueryable<Estado> lista;
            StatusRetorno listaRetorno = new StatusRetorno();

            using (AtribDBContext contexto = new AtribDBContext())
            {
                lista = contexto.Estado;
                if (nome != null && nome.Length != 0)
                    lista = lista.Where(p => p.nome.Contains(nome));
                if (sigla != null && sigla.Length != 0)
                    lista = lista.Where(p => p.sigla.Contains(sigla));
                var listaGenerica = lista.Select(p => new { id = p.idEstado, nome = p.nome, sigla = p.sigla }).ToList();
                
                listaRetorno.Sucesso = true;
                listaRetorno.ListaRetorno = Json(listaGenerica);
                listaRetorno.MensagemExtra = "Consultado com sucesso";
            }

            return Json(listaRetorno);
        }

        [HttpPost]
        public JsonResult GetEstado(int id)
        {            
            StatusRetorno listaRetorno = new StatusRetorno();

            using (AtribDBContext contexto = new AtribDBContext())
            {
                var estado = contexto.Estado.Where(p => p.idEstado == id).Select(p => new {id = p.idEstado, nome = p.nome, sigla = p.sigla }).SingleOrDefault();
                if(estado == null)
                {
                    listaRetorno.MensagemExtra = "Nenhum resultado encontrado";
                    listaRetorno.ListaRetorno = null;
                    listaRetorno.Sucesso = false;
                }
                else
                {
                    listaRetorno.MensagemExtra = "Estado carregado com sucesso.";
                    listaRetorno.ListaRetorno = Json(estado);
                    listaRetorno.Sucesso = true;
                }
            }

            return Json(listaRetorno);
        }

        public JsonResult SalvarEstado(Estado e)
        {
            StatusRetorno retorno = new StatusRetorno();
            Estado procurado = null;
            bool erroAlteracao = false;

            retorno.Sucesso = true;
            retorno.ListaRetorno = Json("");
            retorno.MensagemExtra = "Novo estado gravado com sucesso";

            if (TryValidateModel(e))
            {
                using(AtribDBContext contexto=new AtribDBContext())
                { 
                    if (e.idEstado != 0)
                    {
                        procurado = contexto.Estado.Find(e.idEstado);
                        if(procurado != null)
                        {
                            if (TryUpdateModel(procurado))
                                contexto.SaveChanges();
                            else
                                erroAlteracao = false;
                        }
                    }
                    else
                    {
                        contexto.Estado.Add(e);
                        contexto.SaveChanges();
                    }
                }
            }
            else
            {
                ModelStateDictionary dicionario = ModelState;
                var lista = dicionario.Select(p => new { campo = p.Key, valor = p.Value});

                retorno.Sucesso = false;
                retorno.ListaRetorno = Json(lista);
                retorno.MensagemExtra = "Falha ao registrar os dados";
            }
            
            if(erroAlteracao)
            {
                retorno.Sucesso = false;
                retorno.MensagemExtra = "Falha ao inserir dados. Erro interno.";
                retorno.ListaRetorno = null;
            }
            /***TODO: Receber Estado da edicao e validar 
             * 
             * */

            return Json(retorno);
        }
    }
}