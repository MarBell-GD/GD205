using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCamera : MonoBehaviour
{

    #region Variables

    [HideInInspector] public float CameraOffset;

    [HideInInspector] public Vector3 CamTransform;

    [HideInInspector] GameObject Camera;

    [Header("Camera stuffs")]
    public Transform PlayerTransform;
    public float SmoothSpeed;

    #endregion

    private void Start()
    {

        Camera = this.gameObject;

    }

    void Update()
    {

        //Smort camera things
        if (Input.GetKeyDown(KeyCode.W))
            CameraOffset = -5f;
        else if (Input.GetKeyDown(KeyCode.S))
            CameraOffset = 5f;

    }

    void FixedUpdate()
    {

        //More smort camera things
        CamTransform = new Vector3(Camera.transform.position.x, Camera.transform.position.y, PlayerTransform.position.z + CameraOffset);

        Camera.transform.position = Vector3.Lerp(Camera.transform.position, CamTransform, SmoothSpeed * Time.deltaTime);

    }

}
