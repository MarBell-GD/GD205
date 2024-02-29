using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoulder : MonoBehaviour
{

    #region Variables

    [Header("Info")]
    [HideInInspector] Transform location;
    [Tooltip("What the entity is")] public GameObject entity;
    [Tooltip("you get it")] public float interval;
    public float delay; //Usually = 2x the interval

    float timeElapsed;

    #endregion

    // Start is called before the first frame update
    void Start()
    {

        location = this.GetComponent<Transform>();
        timeElapsed = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        
        if(timeElapsed >= interval)
        {

            Instantiate(entity, location.position, location.rotation);
            interval = interval + delay;

        }

        timeElapsed += Time.deltaTime;

    }
}
