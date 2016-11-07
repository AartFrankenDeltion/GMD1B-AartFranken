using UnityEngine;
using System.Collections;

public class Spinner : MonoBehaviour
{

    [Range(0,360)]
    public float degreesBeforeReward = 10f;
    public int pointsToReward = 100;

    float lastRotation;

    void Start()
    {
        lastRotation = transform.localRotation.eulerAngles.z;
    }

    void Update()
    {

        if (transform.localRotation.eulerAngles.z > lastRotation + degreesBeforeReward || transform.localRotation.eulerAngles.z < lastRotation - degreesBeforeReward)
        {
            ScoreManager.score += pointsToReward;
            lastRotation = transform.localRotation.eulerAngles.z;
        }

    }
}