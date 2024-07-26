namespace autenticacao_api.Models
{
    public class AddUserRequest
    {
        public string email { get; set; }
        public string password { get; set; }
        public string rg { get; set; }
    }
}
