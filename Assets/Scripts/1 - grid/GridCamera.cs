using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCamera : MonoBehaviour
{

    [HideInInspector] public float CameraOffset;

    [HideInInspector] public Vector3 CamTransform;

    public Transform PlayerTransform;

    [HideInInspector] GameObject Camera;

    public float SmoothSpeed;

    private void Start()
    {

        Camera = this.gameObject;

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
            CameraOffset = -4f;
        else if (Input.GetKeyDown(KeyCode.S))
            CameraOffset = 4f;

    }

    void FixedUpdate()
    {

        CamTransform = new Vector3(Camera.transform.position.x, Camera.transform.position.y, PlayerTransform.position.z + CameraOffset);

        Camera.transform.position = Vector3.Lerp(Camera.transform.position, CamTransform, SmoothSpeed * Time.deltaTime);

    }

}
