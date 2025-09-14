using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextActive : MonoBehaviour
{
    [SerializeField] private GameObject textObject;
    private void Update()
    {
        if (GManager.instance.Start==true)
        {
            textObject.SetActive(false);
        }
        else
        {
            textObject.SetActive(true);
        }
    }
}

