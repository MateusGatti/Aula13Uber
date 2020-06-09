namespace Aula13Uber
{
    public class Motorista : Usuario
    {
        
        private string Carro { get; set; }

        private string Placa { get; set; }



        public string aceitarPassageiro(){
            return "Passageiro aceito!";
        }

        public bool receberPagamento(bool pagar){
            if(pagar != false){
                return true;

            }
            return false;

        }

    }
}