using System;

/// <summary>
/// Node for Linked List
/// </summary>
public class Node
{
	Customer data;
	Node next;

	public Customer Data { get => data; set => data = value; }
	public Node Next { get => next; set => next = value; }
}
