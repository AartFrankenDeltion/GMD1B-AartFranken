using UnityEngine;
using System.Collections;

public class Headlights : MonoBehaviour {
    public Color colorStart = Color.white;
    public Color colorClicked = Color.yellow;
    public Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            {
            rend.material.color = colorClicked;
            }

        if (Input.GetButtonUp("Fire1"))
            {
            rend.material.color = colorStart;
            }
    }
}
