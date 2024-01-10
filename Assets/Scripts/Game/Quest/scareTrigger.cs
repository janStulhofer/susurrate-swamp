using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scareTrigger : MonoBehaviour
{
    public questKey colliderFunkce;
    public GameObject jScare; //Model / Animace

    void Start()
    {

    }

    void Update()
    {
        if(colliderFunkce.OnTriggerEnter(Collider other) && colliderFunkce.questDone == true)
        
        colliderFunkce.OnTriggerExit(Collider other);
    }
}
