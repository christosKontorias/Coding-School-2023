﻿namespace CarServiceCenter.Model;

public class ServiceTask
{
    public ServiceTask(string code, string description, decimal hours)
    {
        Code = code;
        Description = description;
        Hours = hours;

        TransactionLines = new List<TransactionLine>();
    }

    public ServiceTask() {

    }

    public int Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public decimal Hours { get; set; }

    public List<TransactionLine> TransactionLines { get; set; }
}

public class ServiceTaskCreateDto {
    public string Code { get; set; }
    public string Description { get; set; }
    public decimal Hours { get; set; }

}

public class ServiceTaskEditDto {
    public int Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public decimal Hours { get; set; }
}