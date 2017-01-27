using UnityEngine;
using System.Collections;

public class Falling : MonoBehaviour {

    float x;
    float y;
    float z;
    Vector3 position;
    public Rigidbody FallingSphere;


	// Use this for initialization
	void Start () {
        y = 11;
        x= Random.Range (-16, 16);
        z = 4;

        InvokeRepeating("sphere", 1, 5);
        GameObject.Find("FallingSphere");

    }

    // Update is called once per frame
    void Update()
    {
        var newBall = Instantiate(FallingSphere);
    }

  }
