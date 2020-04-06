using System;

/// <summary>
/// Class Customer for Encapsulate Customer Data.
/// </summary>
public class Customer
{
	//Variables
	private string name;
	private int accountNumber;
	private int balance=500;
	
	//Getters and Setter to Set Data.
	public string Name { get => name; set => name = value; }
	public int AccountNumber { get => accountNumber; set => accountNumber = value; }
	public int Balance { get => balance; set => balance = value; }
}
