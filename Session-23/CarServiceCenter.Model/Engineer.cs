namespace CarServiceCenter.Model;

public class Engineer
{
    public Engineer(string name, string surname, int salaryPerMonth)
    {
        Name = name;
        Surname = surname;
        SalaryPerMonth = salaryPerMonth;

        TransactionLines = new List<TransactionLine>();
    }

    public Engineer() {
        TransactionLines = new List<TransactionLine>();
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int SalaryPerMonth { get; set; }

    // Relations
    public int ManagerId { get; set; }
    public Manager Manager { get; set; } = null!;

    public List<TransactionLine> TransactionLines { get; set; }
}

public class EngineerCreateDto {
    public string Name { get; set; }
    public string Surname { get; set; }
    public int SalaryPerMonth { get; set; }
    //selector theloume kai mia lista 
    public int ManagerId { get; set; }
    //public List<SelectListItem> Managers { get; } = new List<SelectListItem>();
}
public class EngineerDeleteDto {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int SalaryPerMonth { get; set; }
    public int ManagerId { get; set; }

}
public class EngineerEditDto {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int SalaryPerMonth { get; set; }
    public int ManagerId { get; set; }

}