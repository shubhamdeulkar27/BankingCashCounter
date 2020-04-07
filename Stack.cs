using System;

/// <summary>
/// Stack class for implementing Stack Data Structure.
/// </summary>
public class Stack
{
	QNode head;

	public void Push(int data)
	{
		QNode node = new QNode();
		node.Data = data;
		node.Next = null;
		if (head == null)
		{
			head = node;
		}
		else
		{
			node.Next = head;
			head = node;
		}
	}

	public void Pop()
	{
		if (head == null)
		{
			return;
		}
		else
		{
			head.Next = head;
		}
	}
}
