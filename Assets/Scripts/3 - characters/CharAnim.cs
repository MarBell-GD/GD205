using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Animations;

public class CharAnim : MonoBehaviour
{

    Animator anim;
    CharacterController ctrl;

    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        ctrl = GetComponent<CharacterController>();

        anim.SetFloat("movement", 0);

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        //Vector3 trueMove = new Vector3(Input.GetAxisRaw("Horizontal") * 0.005f, 0f, Input.GetAxisRaw("Vertical") * 0.005f);
        Vector3 trueMove = new Vector3(0f, 0f, Input.GetAxisRaw("Vertical") * 0.005f);

        if (move.z == 1 || move.z == -1)
        {

            anim.SetFloat("movement", Mathf.Abs(Input.GetAxisRaw("Vertical")));
            ctrl.Move(trueMove);
            
        }
        else
        {

            anim.SetFloat("movement", 0);

        }

        /*
         
        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1)
        {

            

        }

        */

    }

}
