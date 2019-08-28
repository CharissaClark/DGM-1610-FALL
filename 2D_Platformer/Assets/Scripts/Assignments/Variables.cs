using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    string name = "Charissa";
    int age  = 18;
    float height = 5.4f;
    bool married = false; 




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("First Name: " + name);
        Debug.Log("Age: " + age);
        Debug.Log("Height: " + height);
        Debug.Log("Married: " + married);
    }

    
}
