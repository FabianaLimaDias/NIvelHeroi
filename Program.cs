namespace Desafio2{
    class Program
    {

        static void Main(string[] args) {
            int vitoria;
            int derrota;
            int resultado;
            string nivel = "indefinido";

            Console.WriteLine(" Digite quantidade de vitórias: ");
            vitoria = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Digite quantidade de derrotas: ");
            derrota = Convert.ToInt32(Console.ReadLine());

            resultado = Pontuacao(vitoria, derrota);


            static int Pontuacao(int vitoria, int derrota)
            {
                int saldoFinal = vitoria - derrota;
                return saldoFinal;
            }


            if (resultado <=10)
            {
                nivel = "Ferro";
            }
            else if (resultado >= 11 && resultado <= 20)
            {
                nivel = " Bronze";
            }
            else if (resultado >= 21 && resultado <= 50)
            {
                nivel = " Prata";
            }
            else if (resultado >= 51 && resultado <= 80)
            {
                nivel = " Ouro ";
            }
            else if (resultado >= 81 && resultado <= 90)
            {
                nivel = " Diamante";
            }
            else if (resultado >= 91)
            {
                nivel = "Imortal";
            }



            Console.WriteLine($" O Herói tem de saldo de {resultado} está no nível de {nivel}");
        }
    }
}
