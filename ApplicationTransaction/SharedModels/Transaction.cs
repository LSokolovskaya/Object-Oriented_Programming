using System;

namespace AppTransaction.SharedModels;

public class Transaction
{
    public int ID { get; }
    public string Comment { get; set; }
    public decimal Value { get; set; }
    public DateTime Date { get; set; }
    public int UserId { get; }

    public Transaction(int id, int userId)
    {
        ID = id;
        UserId = userId;
    }
    public Transaction(int id, int userId, string comment, decimal value, DateTime date) : this(id, userId)
    {
        Comment = comment;
        Value = value;
        Date = date;
    }

    public override string ToString()
    {
        return $"{ID} {Date:dd/MM/yyyy} {Value:N2}Br {Comment}";
    }
}
