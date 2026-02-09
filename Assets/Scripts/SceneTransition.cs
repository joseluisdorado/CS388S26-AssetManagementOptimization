using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This example shows how to use the Scene Manager utility class to apply scenes transitions at runtime
public class SceneTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.Invoke("LoadScene", 2.0f);
        this.Invoke("CreateScene", 3.0f);
        this.Invoke("UnloadScene", 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadScene()
    {
        // Load a scene to the current scene
        SceneManager.LoadScene("Scene2", LoadSceneMode.Additive);        
    }

    void CreateScene()
    {
        // Crates a scene at runtime and move the current obejct to that scene
        Scene newScene = SceneManager.CreateScene("Scene3");
        SceneManager.MoveGameObjectToScene(this.gameObject, newScene);
    }

    void UnloadScene()
    {
        // Unload a scene and free its memory
        SceneManager.UnloadSceneAsync("Scene3");
    }
}
