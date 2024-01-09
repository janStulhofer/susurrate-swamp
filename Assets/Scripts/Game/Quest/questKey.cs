using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questKey : MonoBehaviour
{
    public GameObject key;
    public GameObject txt;

    public bool inRange = false;

    void Start()
    {
    key.SetActive(false);    
    txt.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && inRange)
        {
            key.SetActive(false);
            txt.SetActive(false);
            Debug.Log("Key picked up");
            
        }
    }

    public void showKey()
{
    key.SetActive(true);
    txt.SetActive(true);
}

private void OnTriggerEnter(Collider other)
        {
            if(other.tag == "Player")
            {
                inRange = true;
                Debug.Log("Player in range");
            }
        }

private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            inRange = false;
            Debug.Log("Player out of range");
        }
    }
}




