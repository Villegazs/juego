using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManejadorMonedas : MonoBehaviour, MMEventListener<PickableItemEvent> // Interfaz con el evento de pickable item event que tiene las monedas de corgi
{

    private int monedas_recolectadas;

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
        Debug.Log(e.PickedItem.name);
    }
}
