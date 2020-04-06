using System;

/// <summary>
/// Class Queue for implemeting Queue Data Structure.
/// </summary>
public class Queue
{
	QNode head;

	/// <summary>
	/// Enque function to add data to Queue.
	/// </summary>
	/// <param name="data"></param>
	public void Enque(int data)
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

	/// <summary>
	/// Deque function to remove data from dequeu.
	/// </summary>
	/// <param name="data"></param>
	public void Deque()
	{
		if (head == null)
		{
			return;
		}
		else
		{
			try
			{
				QNode temporary = head;
				QNode prev = null;
				while (temporary.Next != null)
				{
					prev = temporary;
					temporary = temporary.Next;
				}
				prev.Next = null;
			}
			catch (System.NullReferenceException exception)
			{
				Console.WriteLine("Account Is Not Present");
			}
		}
	}
}
