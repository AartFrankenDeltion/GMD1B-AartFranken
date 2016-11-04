using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {
    void OnCollisionEnter (Collision collision)
    {
        Destroy (collision.gameObject);
        GameObject.Find("GameData").GetComponent<GameManager>().lives -= 1;
    }

}
