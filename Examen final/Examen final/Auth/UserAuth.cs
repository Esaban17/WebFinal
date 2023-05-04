﻿using System.ComponentModel;

namespace APP.Auth;

public class UserAuth
{
    [DisplayName("Usuario")]
    public string User { get; set; } = null!;

    [DisplayName("Contraseña")]
    public string Password { get; set; } = null!;
}
