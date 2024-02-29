using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPlayer : MonoBehaviour
{

    #region Variables

    [Header("Player stuffs")]
    public Transform start;
    [HideInInspector] public int health;

    #endregion

    void Start()
    {

        health = 3; //Doesn't really do anything atm

    }

    // Update is called once per frame
    void Update()
    {
        
        //Movement
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D)) //it's WASD, movement still works the same lol
        {

            transform.position += new Vector3((Input.GetAxisRaw("Horizontal") * -1), 0, (Input.GetAxisRaw("Vertical") * -1)); //This is definitely my record for how small I made movement code :D

        }

        if (health <= 0) //game over :(
            GameOver();

    }

    public void Return() //bye bye
    {

        transform.position = start.position;
        health--;

    }

    public void GameOver() //Will do more in da futureeeee
    {

        Debug.Log("Game Over. You did well, don't sweat it.");
        Destroy(this.gameObject);

    }

}
