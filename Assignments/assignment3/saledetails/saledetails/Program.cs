using System;

public class Saledetails
{
    // Data members/fields
    private int salesNo;
    private int productNo;
    private double price;
    private DateTime dateOfSale;
    private int qty;
    private double totalAmount;

    // Constructor to initialize sale details
    public Saledetails(int salesNo, int productNo, double price, int qty, DateTime dateOfSale)
    {
        this.salesNo = salesNo;
        this.productNo = productNo;
        this.price = price;
        this.qty = qty;
        this.dateOfSale = dateOfSale;

        // Calculate total amount initially
        CalculateTotalAmount();
    }

    // Method to calculate total amount based on quantity and price
    private void CalculateTotalAmount()
    {
        totalAmount = qty * price;
    }

    // Method to display sale data
    public void ShowData()
    {
        Console.WriteLine($"Sales Number: {salesNo}");
        Console.WriteLine($"Product Number: {productNo}");
        Console.WriteLine($"Price per unit: {price}");
        Console.WriteLine($"Quantity sold: {qty}");
        Console.WriteLine($"Date of Sale: {dateOfSale.ToShortDateString()}");
        Console.WriteLine($"Total Amount: {totalAmount}");
        Console.ReadLine();
    }
}

class Program
{
    static void Main()
    {
        // Example usage:
        DateTime date1 = new DateTime(2024, 7, 05); // Example date of sale
        Saledetails sale1 = new Saledetails(1001, 101, 50.0, 5, date1);
        sale1.ShowData(); // Display sale1 details

        Console.WriteLine();
        Console.ReadLine();

        DateTime date2 = new DateTime(2024, 6, 23); // Example date of sale
        Saledetails sale2 = new Saledetails(1002, 102, 75.0, 3, date2);
        sale2.ShowData(); // Display sale2 details
    }
}