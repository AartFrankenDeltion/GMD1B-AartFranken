using UnityEngine;
using System.Collections;

public class Targets : MonoBehaviour
{

    public float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //dit zorgt voor de zijwaartse beweging
        transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * speed);
    }
}
