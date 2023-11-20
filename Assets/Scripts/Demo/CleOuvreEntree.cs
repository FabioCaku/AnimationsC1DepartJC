using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleOuvreEntree : MonoBehaviour
{
    
    [SerializeField] GameObject _porteEntree;

    [SerializeField] GameObject _joueur;

    [SerializeField] GameObject _cle;

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            _cle.SetActive(false);
            _porteEntree.GetComponent<Animator>().SetBool("Ouvre",true);
            Debug.Log("collision");
        }


        
}
    
}
