using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Declencheur : MonoBehaviour
{
    private int compteur=0;       // Déclaration du compteur 
    private void OnTriggerEnter(Collider other)  // Incrémentation du compteur 
    {
        Debug.Log("Declenché");
        compteur=compteur+1;
    }
    private void OnTriggerExit(Collider other)   // Décrémentation du compteur
    {
        compteur=compteur-1;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){         // Affichage du compteur avec la touche R
            Debug.Log("Compteur : " +compteur);
        }
    }
}
