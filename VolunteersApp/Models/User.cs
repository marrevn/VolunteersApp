using System;
using System.Collections.Generic;

namespace VolunteersApp.Models;

public partial class User
{
    public int Id { get; set; }

    public string Fio { get; set; } = null!;

    public short IdRole { get; set; }

    public string Email { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<VolunteerRegistration> VolunteerRegistrations { get; set; } = new List<VolunteerRegistration>();
}
