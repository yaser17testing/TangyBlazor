﻿using Microsoft.AspNetCore.Identity;
using Tangy_Models;

namespace TangyWeb_Client.Service.IService
{
    public interface IAuthenticationService
    {

        Task<SignUpResponseDTO> RegisterUser(SignUpRequestDTO signUpRequestDTO);

        Task<SignInResponseDTO>Login(SignInRequestDTO signInRequestDTO);


        Task Logout();





    }
}
