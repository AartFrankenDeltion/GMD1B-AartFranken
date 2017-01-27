using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

    public Vector3 axis;
    public float hor;
    public float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");

        axis.x = hor;


        transform.Translate(axis * Time.deltaTime * speed);
    }
}