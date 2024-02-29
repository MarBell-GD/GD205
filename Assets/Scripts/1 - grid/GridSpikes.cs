using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpikes : MonoBehaviour
{

    private void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {

       

    }

    private void OnTriggerEnter(Collider other)
    {

        GridPlayer player = other.GetComponent<GridPlayer>();


        if (other.gameObject.tag == "Player")
        {

            Debug.Log("You hit spikes, be careful! 1 health lost!");
            player.Return();

        }

    }

}
