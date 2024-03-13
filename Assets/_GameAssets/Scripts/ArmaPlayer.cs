using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ArmaPlayer : MonoBehaviour
{
    public Arma arma;

    public AudioClip audioReload;//variable publica fichero de audio

    void Update(){
        if (Input.GetButtonDown("Fire1")){
            ApretarGatillo();
        } else if (Input.GetKeyDown(KeyCode.R)){
            GetComponent<AudioSource>().PlayOneShot(audioReload);
            arma.Reload();
        }
    }

    public void ApretarGatillo(){
        arma.IntentarDisparo();
    }
}
