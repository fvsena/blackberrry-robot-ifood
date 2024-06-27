using Blackberry.Robots.IFood.Response;
using System.Collections.Generic;

namespace Blackberry.Robots.IFood.Result
{
    public class ConsultaProdutosResult : BaseResult
    {
        public List<Item> Produtos { get; set; } = new List<Item>();
    }
}
