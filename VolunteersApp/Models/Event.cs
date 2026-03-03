using System;
using System.Collections.Generic;

namespace VolunteersApp.Models;

public partial class Event
{
    public int Id { get; set; }

    public string EventName { get; set; } = null!;

    public int IdCategory { get; set; }

    public DateOnly DateEvent { get; set; }

    public int IdPlace { get; set; }

    public int VolunteersNeed { get; set; }

    public int IdUser { get; set; }

    public int IdStatusEvent { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Place Place { get; set; } = null!;

    public virtual EventStatus EventStatus { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public virtual ICollection<VolunteerRegistration> VolunteerRegistrations { get; set; } = new List<VolunteerRegistration>();
}
