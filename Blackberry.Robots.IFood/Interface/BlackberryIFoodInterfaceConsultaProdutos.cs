using Blackberry.Robots.IFood.Request;
using Blackberry.Robots.IFood.Result;

namespace Blackberry.Robots.IFood.Interface
{
    public class BlackberryIFoodInterfaceConsultaProdutos
    {
        public ConsultaProdutosResult ConsultaProdutos(string url)
        {
            var result = new ConsultaProdutosRequest().ConsultaProdutos(url);
            return result;
        }
    }
}
