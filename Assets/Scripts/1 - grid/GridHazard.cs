using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridHazard : MonoBehaviour
{

    public GameObject player;
    public float duration;

    float timeElapsed;

    private void Start()
    {

        timeElapsed = 0f;

    }

    // Update is called once per frame
    void Update()
    {

        GridPlayer stats = player.GetComponent<GridPlayer>();


        if (player.transform.position == this.transform.position)
        {

            Debug.Log("You hit something!");
            stats.Return();
            Destroy(this.gameObject);

        }

        if(timeElapsed >= duration)
        {

            transform.position += Vector3.forward;
            timeElapsed = 0f;

        }

        timeElapsed += Time.deltaTime;

    }
}
