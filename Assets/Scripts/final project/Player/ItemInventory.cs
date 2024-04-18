using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInventory : MonoBehaviour
{

    [HideInInspector] public List<Item> inventoryKey;
    [HideInInspector] public List<Item> inventory;

    public void AddItem(Item item)
    {

        if (inventory.Count < 10 && item.type != Item.ItemType.Key)
        {

            inventory.Add(item);
            Debug.Log("Item obtained! You got a " + item.Name + "! ID: " + item.ID);

        }
        else
            Debug.Log("No good, your inventory is full!");

    }
    public void AddKeyItem(Item item)
    {

        if (item.type == Item.ItemType.Key)
            inventoryKey.Add(item);

    }


}
