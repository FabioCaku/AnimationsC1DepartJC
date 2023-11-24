using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleOuvreEntree : MonoBehaviour
{
    
    [SerializeField] GameObject _porteEntree;

    [SerializeField] GameObject _joueur;

    [SerializeField] GameObject _cle;

    void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            _cle.SetActive(false);
            _porteEntree.GetComponent<Animator>().SetTrigger("Ouvre");
            Debug.Log("collision");
        }


        
}
    
}
