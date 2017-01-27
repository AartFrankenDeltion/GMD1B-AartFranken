using UnityEngine;
using System.Collections;

public class FirstPerson : MonoBehaviour {

    public Vector3 kijken;
    public Vector3 looking;
   

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //links en rechts
        kijken.x = -Input.GetAxis("Mouse Y");
        GameObject.Find("Body").transform.Rotate(kijken);
        //omhoog en omlaag
        looking.y = Input.GetAxis("Mouse X");
        GameObject.Find("Camera").transform.Rotate(looking);
	}
}
