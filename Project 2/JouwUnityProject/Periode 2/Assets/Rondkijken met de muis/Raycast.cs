using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour {
    
    private RaycastHit hit;
    
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 100f))
            {
                if (hit.transform.tag == "vierkantje")
                {
                    Destroy(hit.transform.gameObject); 
                }                             
            }
        }
       
	}
}
