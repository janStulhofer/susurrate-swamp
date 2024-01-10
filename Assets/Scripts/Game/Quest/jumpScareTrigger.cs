using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpScareTrigger : MonoBehaviour
{
    public GameObject jumpScare;
    public questKey scriptQ;
    public bool inRangeJS = false;
        
    void Start()
    {
        jumpScare.SetActive(false);    
    }

    void Update()
    {
        if(inRangeJS && scriptQ.questDone)
        {
            jumpScare.SetActive(true);
        }
    }

private void OnTriggerEnter(Collider other)
        {
            if(other.tag == "Player")
            {
                inRangeJS = true;
            }
        }

private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            inRangeJS = false;
        }
    }
}