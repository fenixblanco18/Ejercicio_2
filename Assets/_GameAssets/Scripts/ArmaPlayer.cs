using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ArmaPlayer : MonoBehaviour
{
    public Arma arma;

    void Update(){
        if (Input.GetButtonDown("Fire1")){
            ApretarGatillo();
        } else if (Input.GetKeyDown(KeyCode.R)){
            arma.Reload();
        }
    }

    public void ApretarGatillo(){
        arma.IntentarDisparo();
    }
}
