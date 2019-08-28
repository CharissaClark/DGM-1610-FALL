using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cartoon : MonoBehaviour
{
    string name = "Rick Sanchez";
    int age  = 70;
    float height = 6.4f;
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
