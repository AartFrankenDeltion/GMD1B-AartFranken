using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

    public GameObject spawned;
    public Vector3 plek;
    public float timer;

    

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
    {
        Autospawn();                   
	}

    void Autospawn()
    {
        timer += Time.deltaTime;

        if (timer >= 1)
        {
            Instantiate(spawned, plek, Quaternion.identity);
            timer = 0;
        }
    }
}
