using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inmunidad : MonoBehaviour, MMEventListener<PickableItemEvent>
{

    [SerializeField]
    private float tiempo_inmunidad;
    private GameObject _fadeObject;
    private Health salud_personaje;

    [Header("Inmunidad")]
    [MMInspectorButton("ControlInmunidad")]
    public bool ControlInmunidadButton;

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
        if(e.PickedItem.name == "Estrella")
        {
            ControlInmunidad();
        }
    }

    public Health GetHealth()
    {

        _fadeObject = LevelManager.Instance.Players[0].gameObject;
         return _fadeObject.GetComponent<Health>();

    }

    public void ControlInmunidad()
    {
        Debug.Log(GetHealth().ToString());
        salud_personaje = GetHealth();
        salud_personaje.Invulnerable = true;
        StartCoroutine(DesactivarInmunidad());
        
    }

    public IEnumerator DesactivarInmunidad()
    {
        Debug.Log("Cambio");
        yield return new WaitForSeconds(tiempo_inmunidad);
        Debug.Log("Tiempo!");
        salud_personaje.Invulnerable = false;

    }


}
