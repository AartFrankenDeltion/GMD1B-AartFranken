using UnityEngine;
using System.Collections;

public class Frogger_Movement : MonoBehaviour {

    public Vector3 axis;
    public float hor;
    public float ver;
    public float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        axis.x = hor;
        axis.z = ver;


        transform.Translate(axis * Time.deltaTime * speed);
    }
}
