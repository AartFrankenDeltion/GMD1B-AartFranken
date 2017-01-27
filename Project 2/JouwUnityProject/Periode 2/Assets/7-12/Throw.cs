using UnityEngine;
using System.Collections;

public class Throw : MonoBehaviour {

    public GameObject ball;
    public Vector3 werp;
    public Transform spawnPosition;


    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            GameObject newBall = (GameObject)Instantiate(ball, spawnPosition.position, ball.transform.rotation);
            newBall.GetComponent<Rigidbody>().velocity = werp;
        }
	
	}
}
