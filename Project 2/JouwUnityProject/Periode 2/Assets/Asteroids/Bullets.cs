using UnityEngine;
using System.Collections;

public class Bullets : MonoBehaviour {

    public GameObject bullet;
    public Transform spawnPosition;
    public float kracht;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GameObject newBullet = (GameObject)Instantiate(bullet, spawnPosition.position, bullet.transform.rotation);
            newBullet.GetComponent<Rigidbody>().velocity = transform.forward * kracht;
        }
    }
}
