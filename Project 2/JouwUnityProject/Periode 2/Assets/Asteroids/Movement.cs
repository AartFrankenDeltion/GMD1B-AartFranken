using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

    public Vector3 axis;
    public float ver;
    public float speed;
    
    public Vector3 draai;
    public float draaiSpeed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // forward movement
        ver = Input.GetAxis("Vertical");
        axis.z = ver;
        transform.Translate(axis * Time.deltaTime * speed);

        // draai movement y-as
        draai.y = Input.GetAxis("Horizontal");
        transform.Rotate(draai * Time.deltaTime * draaiSpeed);
    }
}
