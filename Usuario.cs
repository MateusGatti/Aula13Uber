namespace Aula13Uber
{
    public class Usuario
    {

        
        private string login = "mateus";
        private string senha = "1234";
        private string Nome { get; set; }
        private string Foto { get; set; }

        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; } 
        public string TipoAcesso { get; set; }

        public bool Login(string login, string senha){

            if( this.login == login && this.senha == senha ){
                TokenLogin = "5f9430f09756y329807f256f278f56798fb56fryewrut";
                return true;
            }

            return false;
        }

        public void Logout(){
            TokenLogin = "";
        }


    }
} 