using UnityEngine;
using System.Collections;

public class CharacterJump : MonoBehaviour
{

    /*force is hoeveel wind er in de zeilen van het schip waait
      velocity de snelheid van het schip
      velocity is het resultaat van een force op een object */ 

    public Vector3 direction;    // waarheen moet hij springen
    public Rigidbody jumper;     // wat moet springen
    public int sk = 2;           //springkracht

    //cubus op de grond
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "grond")
        {
            sk = 2;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (sk > 0)
        {
            if (Input.GetButtonDown("Jump"))
            {
                sk -= 1;
                jumper.velocity = direction;
            }
        }

    }
}
