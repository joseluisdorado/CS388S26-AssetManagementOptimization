using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

// This example load a set of textures asynchronously at runtime in Unity using the Resources utility class. 
public class LoadTexturAsync : MonoBehaviour
{
    Texture2D[] textures = new Texture2D[5];
    float changeInterval = 2.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        // We start a coroutine
        this.StartCoroutine(LoadTexturesCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        // We change the texture at runtime every two seconds and assign the material to the main texture (albedo)
        int index = (int) (Time.time / changeInterval) % textures.Length;
        this.GetComponent<Renderer>().material.SetTexture("_MainTex", textures[index]);
    }

    IEnumerator LoadTexturesCoroutine()
    {
        //We load a texure and wait to the end of the frame to load the next one (frame-sliced)
        for (int i = 0; i < 5; i++)
        {
            textures[i] = Resources.Load<Texture2D>("Textures/wood" + i);
            yield return new WaitForEndOfFrame();
        }
    }
}
