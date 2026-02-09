using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;

// This example shows how to use asset bundles to load assets at runtime 
// In order to this example to work, an asset bundle must be created at the specific path
public class LoadAssetBundle : MonoBehaviour
{
    void Start()
    {
       // We load the asset bundle from the folder
       // This task is performed syncronously, which can impact the performance!
       AssetBundle bundle = AssetBundle.LoadFromFile("Assets/AssetBundles/catbundle");
       
        // We load an specific asset at runtime, a game prefab and create an isntance of it
       GameObject catPrefab = bundle.LoadAsset<GameObject>("CatPrefab");
       Instantiate(catPrefab, this.transform.position, Quaternion.AngleAxis(-90, Vector3.right));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
