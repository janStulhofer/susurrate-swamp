using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlightTurn : MonoBehaviour
{
    public GameObject flashlight;

    void Start()
    {
        flashlight.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            flashlight.SetActive(!flashlight.activeSelf);
        }
    }
}
