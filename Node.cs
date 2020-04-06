using System;

/// <summary>
/// Node for Linked List.
/// </summary>
public class Node
{	//Variables for storing next node reference and data.
	Customer data;
	Node next;

	//Setters and Getters for next and data variables
	public Customer Data { get => data; set => data = value; }
	public Node Next { get => next; set => next = value; }
}
