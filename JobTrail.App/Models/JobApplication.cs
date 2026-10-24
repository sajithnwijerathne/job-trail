using System;

namespace JobTrail.App.Models;

public class JobApplication
{
    public required string Company { get; init; }
    public required string Role { get; init; }
    public string Location { get; init; } = "";
    public DateOnly AppliedOn { get; init; }
    public ApplicationStatus Status { get; init; }
    public string Notes { get; init; } = "";
}