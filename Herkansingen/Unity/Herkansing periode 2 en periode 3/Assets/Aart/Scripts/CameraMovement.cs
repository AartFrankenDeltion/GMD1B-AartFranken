using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    /*public Quaternion q;
    public GameObject player;*/



    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        /*q = new Quaternion(90, this.transform.rotation.y, this.transform.rotation.z, this.transform.rotation.w);
        player.transform.rotation = q;*/
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);    
    }
}