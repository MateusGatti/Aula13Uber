namespace Aula13Uber
{
    public class Passageiro : Usuario
    {

        public string solicitarMotorista(){
            return "Procurando motorista...";
        }

        public bool Pagar(string statusCorrida){

            if(statusCorrida == "Finalizada"){
                return true;
            }

            return false;
        }

    }
} 