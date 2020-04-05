using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Customer
{
	private string name;
	private int accountNumber;
	private int balance=500;
	
	public string Name { get => name; set => name = value; }
	public int AccountNumber { get => accountNumber; set => accountNumber = value; }
	public int Balance { get => balance; set => balance = value; }
}
