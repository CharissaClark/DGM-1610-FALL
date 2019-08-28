using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villian : MonoBehaviour
{
    string name = "Thanos";
    int age  = 1000;
    float height = 8.2f;
    bool powers = false; 




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("First Name: " + name);
        Debug.Log("Age: " + age);
        Debug.Log("Height: " + height);
        Debug.Log("Powers: " + powers);
    }

    
}
