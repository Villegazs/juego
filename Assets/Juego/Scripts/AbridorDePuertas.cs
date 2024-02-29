using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbridorDePuertas : MonoBehaviour, MMEventListener<PickableItemEvent> // Interfaz con el evento de pickable item event que tiene las monedas de corgi
{
    [SerializeField]
    private GameObject puerta;

    void Start()
    {
        if (puerta != null)
        {
            puerta.SetActive(false);
        }
    }

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
        Debug.Log(e.PickedItem.name + ""+e.PickedItem.tag);
        if (e.PickedItem.tag == "Llave")
        {
            puerta.SetActive(true);
        }
        
    }
}

