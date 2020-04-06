using System;

/// <summary>
/// QNode Class Used as Node For Implemeting Queue
/// </summary>
public class QNode
{	//Variables for netx node reference and data.
	int data;
	QNode next;

	//Setters and Getters for the next and Data Variables
	public int Data { get => data; set => data = value; }
	public QNode Next { get => next; set => next = value; }
}
