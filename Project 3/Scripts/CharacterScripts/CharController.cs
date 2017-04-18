using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {
      //Met speed kun je je snelheid veranderen in de inspector
    public float speed = 10.0f;

	// Update is called once per frame
	void Update ()
    {
        float forward = Input.GetAxis("Vertical") * speed;
        float sideways = Input.GetAxis("Horizontal") * speed;
        forward *= Time.deltaTime;
        sideways *= Time.deltaTime;

        transform.Translate(sideways, 0, forward);		
	}
}
