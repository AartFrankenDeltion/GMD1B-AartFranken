using UnityEngine;
using System.Collections;

public class Armor : MonoBehaviour {

    public float damage = 100.0f;
    public float armor;
    public float reduction;
    public float maximum = 8000.0f;

    void Start()
    {
        reduction = Reduced(damage, armor);
    } 


    public float Reduced(float damage, float armor)
    {
        damage *= (1 - (armor/maximum));
        return damage;
    }
}


// overload function die returned hoeveel damage er nog overblijft nadat het armor ervanaf is gehaald