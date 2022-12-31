/**
 * @author: Adriana Gomes a23151 | Joana Pereira a23153
 * @email: a23151@alunos.ipca.pt | a23153@alunos.ipca.pt
 * @ date: 04/12/2022
 **/
namespace projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilizador u1 = new Utilizador(001, "a");
            Utilizador u2 = new Utilizador(002, "b");

            Modelo m1 = new Modelo(Tipo.BICICLETA);
            Modelo m2 = new Modelo(Tipo.BICIELETRICA);

            MeioMobilidade mm1 = new MeioMobilidade(1, m1);
            MeioMobilidade mm2 = new MeioMobilidade(2,m2);
           

            Pedido p1 = new Pedido(1, mm1, u1, new DateTime(2022, 11, 11), new DateTime(2022, 11, 12)); //Adiciona
            Pedido p2 = new Pedido(2, mm1, u1, new DateTime(2022, 11, 17), new DateTime(2022, 11, 20)); //Adiciona
            Pedido p3 = new Pedido(3, mm1, u2, new DateTime(2022, 11, 13), new DateTime(2022, 11, 16)); //Adiciona 
            Pedido p4 = new Pedido(4, mm1, u2, new DateTime(2022, 11, 19), new DateTime(2022, 11, 25)); //Não 
            Pedido p5 = new Pedido(5, mm1, u2, new DateTime(2022, 11, 5), new DateTime(2022, 11, 8)); //Adiciona
                                                                                                      //

            //Pedido p4 = new Pedido(4, mm2, u1, new DateTime(2022, 11, 12), new DateTime(2022, 11, 14)); 
            //Pedido p5 = new Pedido(5, mm1, u1, new DateTime(2022, 11, 12), new DateTime(2022, 11, 14));

            // Console.WriteLine(p1);

            double divida1 = p1.ValorPagamento();

            Pedidos listaP = new Pedidos();

            listaP.InserirPedido(p1);
            listaP.InserirPedido(p2);
            listaP.InserirPedido(p3);
            //listaP.InserirPedido(p4);
            //listaP.InserirPedido(p5);

            listaP.MostraPedidos();

            //listaP.GuardaFicheiro("C:\\Temp\\poo.bin");




        }
    }
}