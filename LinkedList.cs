using System;

/// <summary>
/// LinkedList class to implement linked list data structure.
/// </summary>
public class LinkedList
{
	Node head;

	/// <summary>
	/// Function to add Node to Linked List
	/// </summary>
	/// <param name="data"></param>
	public void AddNode(Customer data)
	{
		Node node = new Node();
		node.Data = data;
		node.Next = null;
		if (head == null)
		{
			head = node;
		}
		else
		{
			Node temporary = head;
			while (temporary.Next != null)
			{
				temporary = temporary.Next;
			}
			temporary.Next = node;
		}
	}

	/// <summary>
	/// Function to remove node from linked list 
	/// </summary>
	/// <param name="data"></param>
	public void Remove(Customer data)
	{
		if (head.Data == data)
		{
			head = head.Next;
		}
		else
		{ 
			Node temporary = head;
			Node prev = null;
			while (temporary.Next != null)
			{
				if (temporary.Data == data)
				{
					break;
				}
				prev = temporary;
				temporary = temporary.Next;
			}
			prev.Next = temporary.Next;
		}
	}


	public Customer Search(int accountNumber)
	{
		try
		{
			Node temporary = head;
			if (temporary != null)
			{
				while (temporary.Next != null)
				{
					if (temporary.Data.AccountNumber == accountNumber)
					{
						break;
					}
					temporary = temporary.Next;
				}
				if (temporary.Data.AccountNumber == accountNumber)
				{
					return temporary.Data;
				}
			}
			else
			{
				
				return null;
			}
		}
		catch (System.NullReferenceException exception)
		{
			Console.WriteLine(exception.Message);
		}
		return null;
		
	}

	/// <summary>
	/// Show function to show the linked list
	/// </summary>
	public void Show()
	{
		Node temporary = head;
		while (temporary.Next != null)
		{
			Console.WriteLine(temporary.Data.ToString());
			temporary = temporary.Next;
		}
		Console.WriteLine(temporary.Data.ToString());
	}
	
}
