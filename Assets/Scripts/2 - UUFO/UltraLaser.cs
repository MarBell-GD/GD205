using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltraLaser : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {

        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();

        if(Physics.Raycast(laser, out hit))
        {

            //Debug.Log("yippee");

            if(Input.GetKeyDown(KeyCode.Mouse0) && hit.collider.gameObject.GetComponent<Rigidbody>() != null)
            {

                hit.collider.gameObject.GetComponent<Rigidbody>().AddExplosionForce(100, hit.point, 10);

            }

        }

    }
}
