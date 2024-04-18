using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{

    [HideInInspector] public int ID;

    public enum ItemType
    {

        Part,
        Consumable,
        Key

    }

    public ItemType type;

    [HideInInspector] public int stack;
    public int stackMax;

    public string Name;
    [TextArea(3, 5)]public string Description;

    public bool canUse; //for items that can be used manually in inventory

}
