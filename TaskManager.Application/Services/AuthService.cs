using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Application.DTOs;
using TaskManager.Application.Helpers;
using TaskManager.Domain.Interfaces;
using User = TaskManager.Domain.Entities.User;
using TaskManager.Domain.Exceptions;

namespace TaskManager.Application.Services
{
    public class AuthService
    {
        private readonly IUserRepository _userRepo;
        public AuthService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }
        public UserDto Login(string username, string password)
        {
            var user = _userRepo.GetByUsername(username);

            if (user == null)
                throw new DomainException("Usuario no encontrado.");

            if (!PasswordHasher.VerifyPassword(password, user.PasswordHash, user.PasswordSalt))
                throw new DomainException("Contraseña incorrecta.");

            return new UserDto
            {
                Id = user.Id,
                Username = user.Username,
                FullName = user.FullName
            };
        }
        public void Register(RegisterUserDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Username) ||
                string.IsNullOrWhiteSpace(dto.FullName) ||
                string.IsNullOrWhiteSpace(dto.Password))
            {
                throw new DomainException("Todos los campos son obligatorios.");
            }

            if (dto.Password != dto.ConfirmPassword)
                throw new DomainException("contraseña incorrecta.");

            // Check if the user exists
            var existing = _userRepo.GetByUsername(dto.Username);
            if (existing != null)
                throw new DomainException("El usuario ya existe.");

            PasswordHasher.CreatePasswordHash(dto.Password, out string hash, out string salt);

            var user = new User
            {
                Username = dto.Username,
                FullName = dto.FullName,
                PasswordHash = hash,
                PasswordSalt = salt,
                CreatedAt = DateTime.UtcNow
            };

            _userRepo.Add(user);
        }
    }
}
