using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;

using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.Exceptions;

public class UIMenu : MonoBehaviour
{
    public CatalogLoader m_CatalogLoader;

    public Text m_InfoLabel;

    public UIField m_SpawnPrefab;
    public UIField m_DownloadDependenciesField;
    public UIField m_LoadSceneField;

    public UIField m_LoadTextureField;
    public UIField m_LoadGameobjectField;

    public UIField m_LoadMeshField;
    public UIField m_LoadMaterialField;

    //console
    public Text m_ConsoleText;

    void Start ()
    {
        string msg = $"Bucket URL:\n{m_CatalogLoader.bucketURL}";
        msg += $"\n\nCatalog path:\n{m_CatalogLoader.catalogPath}";
        //msg += $"\n\nDownload size:\n{m_CatalogLoader.m_CatalogDownloadsize} Bytes";

        m_InfoLabel.text = msg;

        m_SpawnPrefab.Init_UIField(
            "Spawn Prefab", m_CatalogLoader.SpawnPrefab, "SPAWN_PREFAB");

        m_DownloadDependenciesField.Init_UIField(
            "Download dependencies", m_CatalogLoader.DownloadDependencies, "DOWNLOAD_DEP");

        m_LoadSceneField.Init_UIField("Load Scene", m_CatalogLoader.LoadScene, "LOAD_SCENE");

        m_LoadTextureField.Init_UIField("Load texture", m_CatalogLoader.LoadTexture, "LOAD_TEXTURE");

        m_LoadGameobjectField.Init_UIField("Load GameObject", m_CatalogLoader.LoadGameObject, "LOAD_GAMEOBJECT");

        m_LoadMeshField.Init_UIField("Load Mesh", m_CatalogLoader.LoadMesh, "LOAD_MESH");

        m_LoadMaterialField.Init_UIField("Load Material", m_CatalogLoader.LoadMaterial, "LOAD_MATERIAL");

        //ResourceManager.ExceptionHandler = CustomExceptionHandler;
    }

    //Gets called for every error scenario encountered during an operation.
    //A common use case for this is having InvalidKeyExceptions fail silently when a location is missing for a given key.
    void CustomExceptionHandler(AsyncOperationHandle handle, System.Exception exception)
    {
        if (exception.GetType() != typeof(InvalidKeyException))
            Addressables.LogException(handle, exception);

    }

    void AddConsoleMessage(string message)
    {
        m_ConsoleText.text += $"\n\n{message}"; 
    }
}
