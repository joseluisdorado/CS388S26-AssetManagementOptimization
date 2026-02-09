using UnityEditor;
using System.IO;

// This example show how to compile and compress the asset bunldes using the BuildPipeline utility class
public class CreateAssetBundles
{
    //This decorator creates a menu or tool to Unity Editor in the Menu Assets
    [MenuItem("Assets/Build AssetBundles")]
    static void BuildAllAssetBundles()
    {
        // Build all AssetBundles and place them in the specified directory.
        BuildPipeline.BuildAssetBundles("Assets/AssetBundles", 
            BuildAssetBundleOptions.ChunkBasedCompression, 
            BuildTarget.Android);
    }
}