using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorretaTrampa : MonoBehaviour
{
    //Animator TorretaAnimator;
    
    //[SerializeField] GameObject[] torretas;

    public bool patata;


    // Start is called before the first frame update 
    void Start()
    {
        //busca el animator de la torreta
        //TorretaAnimator = GameObject.Find("turret_01").GetComponent<Animator>();
        //torretas = GameObject.FindGameObjectsWithTag("Torreta");
        //print(torretas.Length);
    }


    // Update is called once per frame 
    void Update()
    {

    }


    //Robot toca la trampa y dispara mientras esta dentro 
    public void OnTriggerEnter2D(Collider2D other)
    {
        print("Colision");
        if (other.gameObject.name == "Robot")
        {
            patata=true;
        }
        else
        {
            patata=false;
        }

        /* print("Colision");
         if (other.gameObject.name == "Robot")
         {
             TorretaAnimator.SetBool("Trampa", true);
         }
         else
         {
             TorretaAnimator.SetBool("Trampa", false);
         }*/

    }
     public void OnTriggerExit2D(Collider2D other)
      {
        if (other.gameObject.name == "Robot")
        {
            patata=false;
        }
        /* if (other.gameObject.name == "Robot")
         {
             TorretaAnimator.SetBool("Trampa", false);
         }*/

    }
    



}
