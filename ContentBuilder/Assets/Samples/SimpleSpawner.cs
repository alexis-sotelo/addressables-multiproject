using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class SimpleSpawner : MonoBehaviour
{
    public AssetReference spawnReference;

    // Start is called before the first frame update
    void Start()
    {
        Addressables.InitializeAsync();

        //Invoke(nameof(Spawn), 1f);

    }

    public void Spawn()
    {
        Addressables.InstantiateAsync(spawnReference);
    }
}
