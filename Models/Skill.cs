namespace PersonalPortfolio.Models;

public class Skill
{

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string IconClass { get; set; } = string.Empty;
    public int ProficiencyLevel { get; set; } = 0;

}

