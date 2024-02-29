using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargarNivel : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private string escena;

    public void OnCambiarEscena() // On -> Interaccion
    {
        
        if (escena != null) 
        {
            MMSceneLoadingManager.LoadScene(escena);
        }
    }
}
