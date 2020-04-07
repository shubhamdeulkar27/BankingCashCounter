using System;


/// <summary>
/// HashTable class to implement HashTable Using array.
/// </summary>
public class Hashtable
{
	//Array and Variable.
	static int[] hashtable = new int[10];
	private static int size = hashtable.Length;

	/// <summary>
	/// function to get array index by creating hashcode of given data.
	/// </summary>
	/// <param name="data"></param>
	/// <returns></returns>
	protected static int GetArrayPossition(int data)
	{
		int position = data.GetHashCode() % size;
		return Math.Abs(position);
	}

	/// <summary>
	/// Function to add value into hashtable.
	/// </summary>
	/// <param name="data"></param>
	public void Add(int data)
	{
		int index=GetArrayPossition(data);
		hashtable[index] = data;
	}

	/// <summary>
	/// Function to remove value form hashtable.
	/// </summary>
	/// <param name="data"></param>
	public void Remove(int data)
	{
		for (int i = 0; i < size; i++)
		{
			if (hashtable[i] == data)
			{
				hashtable[i] = 0;
			}	
		}
		
	}
}