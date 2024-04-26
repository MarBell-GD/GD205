using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Gear : ScriptableObject
{

    [HideInInspector] public int ID;

    public string Name;
    [TextArea(3, 5)] public string Description;

}
