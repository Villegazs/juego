using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonJugar : MonoBehaviour
{
    public void OnClickJugar() // On -> Interaccion
    {
        Debug.Log("Jugar");
        MMSceneLoadingManager.LoadScene("Nivel_1");
    }
}
