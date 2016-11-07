using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour
{

    public float force = 100.0f;
    public float forceRadius = 1.0f;
    public int scoreValue = 100;

    void OnCollisionEnter()
    {
        foreach (Collider col in Physics.OverlapSphere(transform.position, forceRadius))
        {
            if (col.GetComponent<Rigidbody>())
            {
                col.GetComponent<Rigidbody>().AddExplosionForce(force, transform.position, forceRadius);
            }
        }

        ScoreManager.score += scoreValue;
    }
}
