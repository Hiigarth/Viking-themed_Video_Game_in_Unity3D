using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public interface IInventoryItem
{
    string Name { get; }
    
    Sprite Image { get; }

    void OnPickup();
}

public class InventoryEventArgs : EventArgs
{
    public InventoryEventArgs(IInventoryItem item)
    {
        item = item;
    }

    public IInventoryItem Item;
}