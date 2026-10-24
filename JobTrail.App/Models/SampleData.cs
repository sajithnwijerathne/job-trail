using System;
using System.Collections.Generic;

namespace JobTrail.App.Models;

public static class SampleData
{
    public static IReadOnlyList<JobApplication> Applications { get; } =
    [
        new()
        {
            Company = "Nordlys Software",
            Role = ".NET Developer",
            Location = "Stockholm",
            AppliedOn = new DateOnly(2026, 10, 2),
            Status = ApplicationStatus.Interviewing,
            Notes = "First interview went well. Technical round next week.",
        },
        new()
        {
            Company = "Fjällvind Systems",
            Role = "Desktop Application Developer (WPF)",
            Location = "Göteborg (hybrid)",
            AppliedOn = new DateOnly(2026, 9, 24),
            Status = ApplicationStatus.Applied,
        },
        new()
        {
            Company = "Skärgård Logistics",
            Role = "Backend Engineer",
            Location = "Remote",
            AppliedOn = new DateOnly(2026, 9, 15),
            Status = ApplicationStatus.Rejected,
            Notes = "Looking for more Kubernetes experience.",
        },
        new()
        {
            Company = "Malmö Medtech",
            Role = "C# Developer",
            Location = "Malmö",
            AppliedOn = new DateOnly(2026, 8, 30),
            Status = ApplicationStatus.Offer,
            Notes = "Offer received. Reply due end of month.",
        },
    ];
}