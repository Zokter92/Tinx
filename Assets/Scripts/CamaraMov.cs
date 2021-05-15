using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMov : MonoBehaviour
{
    //Declaracion de variables
    public GameObject Main_CH;
    void Update()
    {
        Vector3 position = transform.position;
        position.x = Main_CH.transform.position.x;
        transform.position = position; 
    }
}
