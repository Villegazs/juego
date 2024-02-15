using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonInstrucciones : MonoBehaviour
{
    public void OnClickInstrucciones() // On -> Interaccion
    {
        Debug.Log("Instrucciones");
        MMSceneLoadingManager.LoadScene("Instrucciones");
    }

}
