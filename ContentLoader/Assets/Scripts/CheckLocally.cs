using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class CheckLocally : MonoBehaviour
{
    public string assetbundleName = "localbutupdatable_assets_all_94855bac33f212e1aa7147379c6385cc.bundle";

    public string assetName = "pig-texture";

    IEnumerator Start()
    {
        //CachedAssetBundle cachedBundle = new CachedAssetBundle(assetName, Hash128.Parse(m_Options.Hash));


        //var handleDownloadSize = Addressables.GetDownloadSizeAsync(assetName);

        //yield return handleDownloadSize;

        //Debug.Log("Must download: " + handleDownloadSize.Result);

        //Addressables.LoadAssetAsync<AssetBundle>(assetName);

        yield return null;
    }
}
