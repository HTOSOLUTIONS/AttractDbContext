using System;
using System.Collections.Generic;

namespace AttractDbContext.Models;

public partial class UserNotificationPreference
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public int? EventId { get; set; }

    public bool? DoSms { get; set; }

    public bool? DoEmail { get; set; }

    public bool? DoSystem { get; set; }
}
