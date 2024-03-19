using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aparecerVentana : MonoBehaviour, MMEventListener<PickableItemEvent>
{

    [SerializeField] private GameObject ventana;
    //public Textos textos;
    [SerializeField] private string dialogo;
  // Interfaz con el evento de pickable item event que tiene las monedas de corgi


    void OnEnable()
    {
        this.MMEventStartListening<PickableItemEvent>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<PickableItemEvent>();
    }

    public virtual void OnMMEvent(PickableItemEvent e)
    {
        Debug.Log(e.PickedItem.name + "" + e.PickedItem.tag);
        if (e.PickedItem.tag == "Dialogo")
        {
            ventana.SetActive(true);
            FindObjectOfType<ControlDialogos>().ActivarCartel(dialogo);
        }
    }
}

