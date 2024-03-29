using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{

    #region Variables

    public Vector3 CameraOffset;

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

        //More smort camera things
        CamTransform = new Vector3(PlayerTransform.position.x + CameraOffset.x, PlayerTransform.position.y + CameraOffset.y, PlayerTransform.position.z + CameraOffset.z);

        Camera.transform.position = Vector3.Lerp(Camera.transform.position, CamTransform, SmoothSpeed * Time.deltaTime);

    }

}
