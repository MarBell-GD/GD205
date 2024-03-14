using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtifactCollect : MonoBehaviour
{

    [HideInInspector] public bool beingMagnetized;
    Rigidbody rb;

    public Transform magnetTarget;
    public float magSpd;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        beingMagnetized = false;

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 magnetDistance = magnetTarget.position - this.gameObject.transform.position;
        Vector3 magnetDirection = Vector3.Normalize(magnetDistance);

        float trueDistance = Vector3.Distance(magnetTarget.position, this.gameObject.transform.position);

        if (trueDistance <= 15)
            beingMagnetized = true;

        if (beingMagnetized)
        {

            //rb.AddForce(magnetDirection * magSpd); <== da old method
            transform.position = Vector3.MoveTowards(transform.position, magnetTarget.position, magSpd * Time.deltaTime);

        }

    }

}
