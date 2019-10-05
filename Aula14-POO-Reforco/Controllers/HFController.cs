using System;
using Aula14_POO_Reforco.Models;

namespace Aula14_POO_Reforco.Controllers
{
    public class HFController : BaseController
    {

        HFModel hfmodel = new HFModel();

        public string Voar()
        {
            return "Homem de Ferro voando";
        }

        public string Atirar()
        {
            return "Homem de Ferro está atirando";
        }

        public ConsoleColor MudaCor()
        {
            return ConsoleColor.Red;
        }
    }
}