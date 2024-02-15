using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonIrInicio : MonoBehaviour
{
    public void OnClickIrInicio() // On -> Interaccion
    {
        Debug.Log("Ir Inicio");
        MMSceneLoadingManager.LoadScene("Inicio");

    }

}
