using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPlayer : MonoBehaviour
{

    public Transform start;

    public int health;

    void Start()
    {

        health = 3;

    }

    // Update is called once per frame
    void Update()
    {
        
        //Movement
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {

            transform.position += new Vector3((Input.GetAxisRaw("Horizontal") * -1), 0, (Input.GetAxisRaw("Vertical") * -1)); //This is definitely my record for how small I made movement code :D

        }

    }

    public void Return()
    {

        transform.position = start.position;

    }

}
