using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackberry.Robots.IFood.Teste
{
    class Program
    {
        public static void Main(string[] args)
        {
            var result = new Blackberry.Robots.IFood.Interface.BlackberryIFoodInterfaceConsultaProdutos()
                .ConsultaProdutos("https://www.ifood.com.br/delivery/sao-paulo-sp/blackberry---doces-importados-conjunto-habitacional-santa-etelvina-ii/52e40f9d-52f4-4fe7-aabe-d63282c89c3f?UTM_Medium=share");

            var itens = result.Produtos.Where(x => x.Description.ToUpper().Contains("NUTELLA&GO")).ToList();
        }
    }
}
