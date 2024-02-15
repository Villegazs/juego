using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonReiniciar : MonoBehaviour
{
    public void OnClickReiniciar() // On -> Interaccion
    {
        Debug.Log("Reiniciar");
        MMSceneLoadingManager.LoadScene("Nivel_1");
    }

}
