﻿using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Runtime.CompilerServices;
using TangyWeb_Client.Service.IService;

namespace TangyWeb_Client.Pages.Authentication
{
    public partial class Logout
    {




        [Inject]
        public IAuthenticationService _authService { get; set; }

        [Inject]
        public NavigationManager _navigationManager { get; set; }







        protected async override Task OnInitializedAsync()
        {

            await _authService.Logout();
            _navigationManager.NavigateTo("/");

        }



    }
}
