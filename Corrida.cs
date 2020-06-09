namespace Aula13Uber
{
    public class Corrida
    {
        
        private string localInicio { get; set; }

        private string localChegada { get; set; }

        private string statusCorrida { get; set; }

        private string motorista { get; set; }

        private string passageiro { get; set; }


        public string cancelar(){
            return "Corrida cancelada";
        }
    
    }
}