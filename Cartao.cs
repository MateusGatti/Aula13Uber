namespace Aula13Uber
{
    public class Cartao
    {

        private string Numero { get; set; }

        private string Titular { get; set; }

        private string Bandeira { get; set; }

        private string Cvv { get; set; }


        public string cadastrar(){
            return "Cartão cadastrado!";
        }

        public void excluir(){
            
        }
    }
}