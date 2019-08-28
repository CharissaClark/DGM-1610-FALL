using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyChoice : MonoBehaviour
{
    string name = "Solid Snake";
    int age  = 43;
    float height = 5.11f;
    bool alive = true; 




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("First Name: " + name);
        Debug.Log("Age: " + age);
        Debug.Log("Height: " + height);
        Debug.Log("Alive: " + alive);
    }

    
}
