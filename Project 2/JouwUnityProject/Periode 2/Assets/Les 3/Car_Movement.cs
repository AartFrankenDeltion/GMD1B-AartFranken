using UnityEngine;
using System.Collections;

public class Car_Movement : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0, 1, 0)*Time.deltaTime*speed);
	}
}
