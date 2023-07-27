using System;
using System.Collections.Generic;

namespace test_application.Models;

public partial class Credential
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public long MobileNumber { get; set; }

    public string Password { get; set; } = null!;

    public long Role { get; set; }

    public bool IsBlock { get; set; }
}
