using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridHazard : MonoBehaviour
{

    #region Variables

    [Header("DANGER DANGER DANGERRRR")]
    public float duration;
    public float lifetime;

    float timeElapsed;
    float lifespan;

    #endregion

    private void Start()
    {

        timeElapsed = 0f;
        lifespan = 0f;

    }

    // Update is called once per frame
    void Update()
    {

        if(timeElapsed >= duration) //Move forward after a bit of time passes
        {

            transform.position += Vector3.forward;
            timeElapsed = 0f;

        }

        if (lifespan >= lifetime)
            Destroy(this.gameObject);

        timeElapsed += Time.deltaTime;
        lifespan += Time.deltaTime;

    }

    private void OnTriggerEnter(Collider other)
    {

        GridPlayer player = other.GetComponent<GridPlayer>();


        if (other.gameObject.tag == "Player")
        {

            Debug.Log("You hit a boulder, try to time your movements! 1 health lost!");
            player.Return();

        }

    }

}
