using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

// This example shows how to use Addressables to load an asset asynchronously from an path or address
// In order to work this example, you have to install the Addressable package and create an addresable group in Window/AssetManagement/Addressables
public class LoadAddressable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // We load the asset from the provided address, this task is performed asynchronously
       AsyncOperationHandle handler = Addressables.LoadAssetAsync<GameObject>("Assets/Tree/TreePrefab.prefab");
	   // We create a handler for the complete event, the method will be triggered onece the load of the asset has been completed 
        handler.Completed += Handler_Completed;
    }

	private void Handler_Completed(AsyncOperationHandle handle)
	{
        if(handle.Status == AsyncOperationStatus.Succeeded)
        {
			GameObject catPrefab = (GameObject) handle.Result;
			Instantiate(catPrefab);
		}
	}

	// Update is called once per frame
	void Update()
    {
         
    }
}
