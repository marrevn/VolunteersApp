using System;
using System.Collections.Generic;

namespace VolunteersApp.Models;

public partial class RegistrationStatus
{
    public int Id { get; set; }

    public string RegistrStatusName { get; set; } = null!;

    public virtual ICollection<VolunteerRegistration> VolunteerRegistrations { get; set; } = new List<VolunteerRegistration>();
}
