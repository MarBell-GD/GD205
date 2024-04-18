using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactTest : MonoBehaviour, SUPERCharacter.IInteractable
{

    public ItemDatabase database;
    public Item targetItem;
    Item actualItem;

    ItemInventory inv;

    public bool Interact()
    {

        inv.AddItem(actualItem);
        Destroy(this.gameObject);
        Debug.Log("I think you collected this");
        return true;

    }

    // Start is called before the first frame update
    void Start()
    {

        inv = FindObjectOfType<ItemInventory>();

        foreach(Item item in database.items)
        {

            if (item == targetItem)
                actualItem = item;

        }

        if (actualItem == null)
            Debug.LogError("Item not found!");

    }

    // Update is called once per frame
    void Update()
    {

        

    }
}
