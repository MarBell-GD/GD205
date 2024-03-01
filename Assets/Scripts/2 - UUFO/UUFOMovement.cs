using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UUFOMovement : MonoBehaviour
{

    Rigidbody rb;
    public float spd;

    float initspd;

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        initspd = spd;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if(Input.GetKey(KeyCode.RightShift)) 
        {

            spd = initspd + 10;
            
        }
        else
        {

            spd = initspd;

        }

        if(Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {

            rb.AddForce(Vector3.forward * Input.GetAxisRaw("Vertical") * spd);

        }

        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1)
        {

            rb.AddForce(Vector3.right * Input.GetAxisRaw("Horizontal") * spd);

        }

    }
}
