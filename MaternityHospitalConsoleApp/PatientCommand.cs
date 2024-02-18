
public class PatientCommand
{
    public int Id { get; set; }
    public Name? Name { get; set; }
    public int Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public bool Active { get; set; }
}

public class Name
{
    public int Id { get; set; }
    public string? Use { get; set; }
    public string? Family { get; set; }
    public string? Given { get; set; }
}
