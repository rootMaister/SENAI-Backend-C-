using Aula14_POO_Reforco.Models;

namespace Aula14_POO_Reforco.Controllers
{
    public class BaseController
    {
        BaseModel baseModel = new BaseModel();
        

        public string MostraInfo()
        {
            return $"Info do Personagem: \n Vida: {baseModel.Vida}";
        }

        public string Pular()
        {
            return "Personagem pulando";
        }




    }
}