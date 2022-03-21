using Microsoft.AspNetCore.Mvc;
using ControleDeCadastro.Models;
using ControleDeCadastro.Repositorio;

namespace ControleDeCadastro.Controllers
{
    public class CadastroController : Controller
    {
        private readonly IContratoRepositorioA _contratoRepositorioA;
        private readonly IContratoRepositorioE _contratoRepositorioE;
        private readonly IContratoRepositorioEA _contratoRepositorioEA;

        public CadastroController(IContratoRepositorioA contratoRepositorioA, IContratoRepositorioE contratoRepositorioE, IContratoRepositorioEA contratoRepositorioEA)
        {
            _contratoRepositorioA = contratoRepositorioA;
            _contratoRepositorioE = contratoRepositorioE;
            _contratoRepositorioEA = contratoRepositorioEA;

        }

        public IActionResult Associado()
        {
            List<ControleAssociadosModel> associados = _contratoRepositorioA.BuscarTodos();

            return View(associados);
        }

        public IActionResult Vincular()
        {
            return View();
        }

        public IActionResult Empresa()
        {
            List<ControleEmpresasModel> empresas = _contratoRepositorioE.BuscarTodos();
            return View(empresas);
        }
        public IActionResult CadastrarEmpresa()
        {
            return View();
        }
        public IActionResult CadastrarAssociado()
        {
            return View();
        }
        public IActionResult AlterarAssociado(int id)
        {
            ControleAssociadosModel associado = _contratoRepositorioA.ListarPorId(id);
            return View(associado);
        }
        public IActionResult AlteraEmpresa(int id)
        {
            ControleEmpresasModel empresa = _contratoRepositorioE.ListarPorId(id);
            return View(empresa);
        }
        public IActionResult ConsultarAssociado()
        {
            List<ControleAEModel> associados = _contratoRepositorioEA.BuscarTodos();

            return View(associados);
        }
        public IActionResult ConsultarEmpresa()
        {
            return View();
        }
        public IActionResult ConsultaIdAssociado()
        {
            return View();
        }
        public IActionResult ApagarAssociado(int id)
        {
            ControleAssociadosModel associado = _contratoRepositorioA.ListarPorId(id);
            return View(associado);
        }
        public IActionResult DeletaAssociado(int id)
        {
            try
            {
                _contratoRepositorioA.Apagar(id);
                TempData["MensagemSucesso"] = "Associado deletado com sucesso.";
                return RedirectToAction("Associado");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possivel deletar , detalhes do erro: {erro.Message}";
                throw;
            }
        }
        public IActionResult ApagarEmpresa(int id)
        {
            ControleEmpresasModel empresa = _contratoRepositorioE.ListarPorId(id);
            return View(empresa);
        }
        public IActionResult DeletaEmpresa(int id)
        {
            try
            {
                _contratoRepositorioE.Apagar(id);
                TempData["MensagemSucesso"] = "Empresa deletada com sucesso.";
                return RedirectToAction("Empresa");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possivel deletar , detalhes do erro: {erro.Message}";
                throw;
            }
        }

        [HttpPost]
        public IActionResult CadastrarAssociado(ControleAssociadosModel controle)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contratoRepositorioA.Adicionar(controle);
                    TempData["MensagemSucesso"] = "Associado cadastrado com sucesso.";
                    return RedirectToAction("Associado");
                }
                return View(controle);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possivel cadastrar, detalhes do erro: {erro.Message}";
                throw;
            }
        }

        [HttpPost]
        public IActionResult AlterarAssociado(ControleAssociadosModel controle)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contratoRepositorioA.Alterar(controle);
                    TempData["MensagemSucesso"] = "Associado alterado com sucesso.";
                    return RedirectToAction("Associado");
                }
                return View(controle);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possivel alterar, detalhes do erro: {erro.Message}";
                throw;
            }
        }

        [HttpPost]
        public IActionResult CadastrarEmpresa(ControleEmpresasModel controle)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contratoRepositorioE.Adicionar(controle);
                    TempData["MensagemSucesso"] = "Empresa cadastrada com sucesso.";
                    return RedirectToAction("Empresa");
                }
                return View(controle);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possivel cadastrar, detalhes do erro: {erro.Message}";
                throw;
            }
        }

        [HttpPost]
        public IActionResult AlteraEmpresa(ControleEmpresasModel controle)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contratoRepositorioE.Alterar(controle);
                    TempData["MensagemSucesso"] = "Empresa alterada com sucesso.";
                    return RedirectToAction("Empresa");
                }
                return View(controle);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possivel alterar, detalhes do erro: {erro.Message}";
                throw;
            }
        }

        [HttpPost]
        public IActionResult Vincular(ControleAEModel controle)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contratoRepositorioEA.Adicionar(controle);
                    TempData["MensagemSucesso"] = "Vinculação obteve sucesso.";
                    return RedirectToAction("Vincular");
                }
                return View(controle);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possivel cadastrar, detalhes do erro: {erro.Message}";
                throw;
            }

            
        }
    }
}
