using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {
    //Met speed kun je je snelheid veranderen in de inspector
    public float speed = 10.0f;
    public bool gotLighter = false;

    // Update is called once per frame
    void Update()
    {
        float forward = Input.GetAxis("Vertical") * speed;
        float sideways = Input.GetAxis("Horizontal") * speed;
        forward *= Time.deltaTime;
        sideways *= Time.deltaTime;

        transform.Translate(sideways, -forward, 0);
    }

    public void OnCollisionEnter(Collision c)
    {
        // Checks if the GameObject that its colliding with if it has the following tag, if so it picks up the object and destroys the physical appearance.
        if(c.transform.tag == "Lighter")
        {
            Destroy(c.gameObject);
            gotLighter = true;
        }
    }
}
