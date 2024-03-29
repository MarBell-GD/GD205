using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UUFOLazor : MonoBehaviour
{

    LineRenderer laserRender;
    public Material laserColor;

    public GameObject expParticles;

    // Start is called before the first frame update
    void Start()
    {

        laserRender = gameObject.GetComponent<LineRenderer>();

        laserRender.startWidth = 0.5f;
        laserRender.endWidth = 0.5f;

    }

    // Update is called once per frame
    void Update()
    {

        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();

        laserRender.SetPosition(0, transform.position);

        if (Physics.Raycast(laser, out hit))
        {

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {

                laserRender.SetPosition(1, hit.point);
                Instantiate(expParticles, hit.point, Quaternion.identity);

            }

        }

    }

}
