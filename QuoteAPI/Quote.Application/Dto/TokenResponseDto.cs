namespace Quote.Application.Dto
{
    public class TokenResponseDto
    {
        public string AccessToken { get; set; }
        public string TokenType { get; set; }
        public DateTime Expires { get; set; }
    }
}
