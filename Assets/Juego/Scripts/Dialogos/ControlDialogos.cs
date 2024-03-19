using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlDialogos : MonoBehaviour
{
    //private Queue <string> colaDialogo;
    //Textos texto;
    string texto;
    [SerializeField] TextMeshProUGUI textoPantalla;
    [SerializeField] float timerDialogo;
    private bool timerOn=false;


    public void ActivarCartel(string textoObjeto){
        texto=textoObjeto;
        timerOn=true;
        StartCoroutine(MostrarCaracteres(texto));
    }

    public void CierraCartel(){
        gameObject.SetActive(false);
    }

    IEnumerator MostrarCaracteres(string textoAMostrar)
    {
        textoPantalla.text="";
        foreach (char caracter in textoAMostrar.ToCharArray()){
            textoPantalla.text += caracter;
            yield return new WaitForSeconds(0.08f);
        } 
    }
    private void Update() {
        if(timerOn){
        timerDialogo-=Time.deltaTime;}

        if (timerDialogo<0){
            CierraCartel();
            timerOn=false;
        }
    }



}
