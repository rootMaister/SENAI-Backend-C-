using System;
using Aula14_POO_Reforco.Models;

namespace Aula14_POO_Reforco.Controllers
{
    public class CapController : BaseController
    {
        CapModel capModel = new CapModel();

        public string LancarEscudo()
        {
            return "Capitão América lançou o escudo";
        }

        public string DefenderComEscudo()
        {
            return "Capitão América defendeu-se";
        }

        public ConsoleColor MudaCor()
        {
            return ConsoleColor.Blue;
        }
    }
}