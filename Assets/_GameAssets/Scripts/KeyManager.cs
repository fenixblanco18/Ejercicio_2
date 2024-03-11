using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public GameObject imagenLlave;
    void OnTriggerEnter(Collider c){
        if (c.gameObject.name=="key"){
            //1. Desaparece la llave
            Destroy(c.gameObject);
            //2. Aparece en la interfaz de usuario
            imagenLlave.SetActive(true);
            //3. Añadimos al inventario
            //MAÑANA SERÁ OTRO DÍA
        }
    }
}
