using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Void : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        


    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Thought you could fly, huh? Try again!");
        other.GetComponent<GridPlayer>().health = 0;

    }

}
