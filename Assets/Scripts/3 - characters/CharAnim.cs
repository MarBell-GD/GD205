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

        Vector3 move = new Vector3(Input.GetAxisRaw("Vertical"), 0f, Input.GetAxisRaw("Horizontal"));
        Vector3 trueMove = new Vector3(Input.GetAxisRaw("Vertical") * 0.1f, 0f, Input.GetAxisRaw("Horizontal") * 0.1f);

        if (move.x == 1 || move.x == -1)
        {

            anim.SetFloat("movement", Input.GetAxisRaw("Vertical"));
            ctrl.Move(move);
            
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
