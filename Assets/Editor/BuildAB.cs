using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class BuildAB : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    [MenuItem("Assets/Bulid AssetBundle")]
    static void BuildAssetBundle()
    {
        //创建目录
        string abPath = "Assets/AssetBundles";
        if (!Directory.Exists(abPath))
        {
            Directory.CreateDirectory(abPath);
        }
        //打包 os/win
#if UNITY_STANDALONE_WIN
        BuildPipeline.BuildAssetBundles(abPath ,BuildAssetBundleOptions.None   , BuildTarget.StandaloneWindows64);
#elif UNITY_STANDALONE_OSX
				BuildPipeline.BuildAssetBundles(abPath, BuildAssetBundleOptions.None, BuildTarget.StandaloneOSX);
#endif

    }
}
