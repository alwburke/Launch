﻿using UnityEngine;
using System.Collections;

/// <summary>
/// Holds a list of item names and descriptions that have been saved to the log
/// </summary>
public class ItemLogScript : MonoBehaviour {

	private ArrayList logItems = new ArrayList();

	//Adds an item to the log and returns the index
	public int addItem(string title, string description)
	{
		string[] newItem = new string[2](title, description);
		logItems.Add(newItem);
		return (logItems.Count - 1);
	}

	public ArrayList[] logArray()
	{
		return logItems;
	}

	public void deleteByIndex(int index)
	{
		logItems.RemoveAt(index);
	}
}
