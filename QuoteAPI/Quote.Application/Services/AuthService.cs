using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Quote.Application.Dto;
using Quote.Application.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Quote.Application.Services
{
    public class AuthService : IAuthService
    {
        private IConfiguration _config;
        public AuthService(IConfiguration config)
        {
            _config = config;
        }
        public TokenResponseDto GenerateJwtToken()
        {
            try
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                var claims = new[]
                {
                new Claim("AgreegatorId", "211"),
                new Claim(JwtRegisteredClaimNames.Email, "kiansonawane@gmail.com"),
                new Claim("DateOfJoing", $"{DateTime.Now}"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

                var secreteToken = new JwtSecurityToken(_config["Jwt:Issuer"],
                  _config["Jwt:Issuer"],
                  claims,
                  expires: DateTime.Now.AddMinutes(int.Parse(_config["Jwt:ExpiresInMin"])),
                  signingCredentials: credentials);

                return new TokenResponseDto
                {
                    AccessToken = new JwtSecurityTokenHandler().WriteToken(secreteToken),
                    Expires = secreteToken.ValidTo,
                    TokenType = "Bearer"
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
