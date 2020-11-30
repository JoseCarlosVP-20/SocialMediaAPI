﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

using SocialMedia.Core.Entities;

using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SocialMedia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public TokenController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Authenticaton(UserLogin login)
        {
            //If it is a valid user
            if (IsValidUser(login))
            {
                var token = GenerateToken();
                return Ok(new { token });
            }

            return NotFound();
        }

        private string GenerateToken()
        {
            //Header
            var symmmetrySecuryKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Authentication:SecretKey"]));
            var signingCredencial = new SigningCredentials(symmmetrySecuryKey, SecurityAlgorithms.HmacSha256);
            var header = new JwtHeader(signingCredencial);

            //Claims
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, "Jose Carlos Villalba"),
                new Claim(ClaimTypes.Email, "Jose@gmail.com"),
                new Claim(ClaimTypes.Role, "Administrador")
            };

            //Payload
            var payload = new JwtPayload(
                _configuration["Authentication:Issuer"],
                _configuration["Authentication:Audience"],
                claims,
                DateTime.Now,
                DateTime.UtcNow.AddMinutes(2)
                );

            var token = new JwtSecurityToken(header, payload);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public bool IsValidUser(UserLogin login)
        {
            return true;
        }
    }
}