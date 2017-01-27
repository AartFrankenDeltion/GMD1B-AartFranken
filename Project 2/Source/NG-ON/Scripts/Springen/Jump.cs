using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

    //force is hoeveel wind er in de zeilen van het schip waait
    //velocity de snelheid van het schip
    //velocity is het resultaat van een force op een object

    public Vector3 spring;
    public Rigidbody bertus;
    public int kracht = 3;


	// Use this for initialization
	void Start ()
    {
	}
	
    //cubus op de grond
    void OnCollisionEnter()
    {
        kracht = 3;
    }


	// Update is called once per frame
	void Update ()
    {
        if(kracht > 0)
        {
            if (Input.GetButtonDown("Jump"))
            {
                kracht = kracht - 1;
                bertus.velocity = spring;
            }    
        } 
        
    }
}
