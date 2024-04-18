using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemDatabase : ScriptableObject
{

    public List<Item> items;

    // Update is called once per frame
    void Update()
    {
        
        for(int i = 0; i < items.Count; i++)
        {

            items[i].ID = i;

        }

    }

}
