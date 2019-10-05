using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tarafas.repositories.Repositories.Interfaces;
using tarefas.business.Models.Payloads;
using tarefas.business.Models.Proxies;
using tarefas.webbase.Extension;

namespace tarefas.business.Business
{
    public class UserBusiness
    {
        private readonly IUserRepository _userRepository;

        public UserBusiness(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserProxy> Login(LoginPayload payload)
        {
            var user = await _userRepository.GetByUsernameAsync(payload.Username);

            if (user == null)
                throw new Exception("Usuário não encontrado.");

            if (user.Password != payload.Password.CalculateMd5Hash())
                throw new Exception("Senha inválida.");

            return new UserProxy().EntityToProxy(user);
        }

        public async Task Create(UserPayload payload)
        {
            if (await _userRepository.HasUsername(payload.Username))
                throw new InvalidProgramException("Esse usuário já é registrado.");

            var entity = payload.PayloadToEntity(payload);
            
            await _userRepository.Create(entity);
        }
    }
}
