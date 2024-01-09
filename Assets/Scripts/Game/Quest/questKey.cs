using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questKey : MonoBehaviour
{
    public GameObject key;
    
    void Start()
    {
    key.SetActive(false);    
    }

    void Update()
    {
        
    }
    public void showKey()
{
    key.SetActive(true);
}
}




