using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;

// This example load a set of textures at runtime in Unity using the Resources utility class. 
public class LoadTexture : MonoBehaviour
{
    Texture2D[] textures = new Texture2D[5];
    float changeInterval = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        // We load textures from the resources folder and store them in a array
        // This load is performed synchronously, something that can impact the performance!
        for (int i = 0; i < 5; i++)
            textures[i] = Resources.Load<Texture2D>("Textures/wood" + i);
    }

    // Update is called once per frame
    void Update()
    {
        // We change the texture at runtime every two secods and assign the material to the main texture (albedo)
        int index = (int) (Time.time / changeInterval) % textures.Length;
        this.GetComponent<Renderer>().material.SetTexture("_MainTex", textures[index]);
    }
}
