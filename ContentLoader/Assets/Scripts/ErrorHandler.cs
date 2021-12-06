using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using System;

public class ErrorHandler : MonoBehaviour
{
    void Start()
    {
        ResourceManager.ExceptionHandler = CustomExceptionHandler;
    }

    void CustomExceptionHandler(AsyncOperationHandle handle, Exception exception)
    {
        //if (exception.GetType() == typeof(InvalidKeyException))
        //{
        //    Debug.LogError(exception.Message);
        //    Addressables.LogException(handle, exception);
        //}
    }
}
