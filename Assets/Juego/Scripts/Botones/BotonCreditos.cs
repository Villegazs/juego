using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonCreditos : MonoBehaviour
{
    public void OnClickCreditos() // On -> Interaccion
    {
        Debug.Log("Creditos");
        MMSceneLoadingManager.LoadScene("Creditos");
    }

}
