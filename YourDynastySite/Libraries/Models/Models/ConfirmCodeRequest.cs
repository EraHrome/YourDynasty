namespace Models.Models
{
    public class ConfirmCodeRequest
    {
        public string Code { get; set; } = null!;

        public ConfirmCodeRequest(string code)
        {
            Code = code;
        }
    }
}
