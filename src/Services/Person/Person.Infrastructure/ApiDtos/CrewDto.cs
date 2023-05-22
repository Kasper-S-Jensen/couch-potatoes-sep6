﻿namespace Person.Infrastructure.ApiDtos;

public class CrewDto
{
    public string BackdropPath { get; set; } = default!;
    public string OriginalTitle { get; set; } = default!;
    public string Department { get; set; } = default!;
    public string Job { get; set; } = default!;
    public int MovieId { get; set; }
}