using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class test : MonoBehaviour
{
  public  GameObject wallPrefab;
  public  GameObject wallPrefab1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown  (KeyCode.Space))
        {
            StartCoroutine(getobject());
        }
    if (Input.GetKeyDown  (KeyCode.W ))
        {
            StartCoroutine(getobject1());
        }
    }

    IEnumerator getobject()
    {
        if (wallPrefab != null)
        {
            Instantiate(wallPrefab);
        }
        else
        {
            string _abPath = Application.dataPath + "/AssetBundles/model";
            AssetBundleCreateRequest request = AssetBundle.LoadFromMemoryAsync(File.ReadAllBytes(_abPath));
            yield return request;
            AssetBundle ab = request.assetBundle;
            wallPrefab = ab.LoadAsset<GameObject>("Sphere.prefab");
       
                Instantiate(wallPrefab);

         
        }
      
      
    }
 IEnumerator getobject1()
    {
        if (wallPrefab1 != null)
        {
            Instantiate(wallPrefab1);
        }
        else
        {
            string _abPath = Application.dataPath + "/AssetBundles/model1.u3d";
            AssetBundleCreateRequest request = AssetBundle.LoadFromMemoryAsync(File.ReadAllBytes(_abPath));
            yield return request;
            AssetBundle ab = request.assetBundle;
            wallPrefab1 = ab.LoadAsset<GameObject>("Cube.prefab");
            Instantiate(wallPrefab);
        }
      
      
    }

}
