using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorretaDisparos : MonoBehaviour
{
    [SerializeField] GameObject bala;
    [SerializeField] Transform torreta;
    Animator TorretaAnimator;
    TorretaTrampa script;
   

    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("Trampa").GetComponent<TorretaTrampa>();
        TorretaAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ActivarTorreta();
    }
    public void disparar()
    {
        Instantiate(bala, torreta.transform.position, torreta.transform.rotation);
    }
    public void ActivarTorreta()
    {
        //print(script.estoydentro);
        if (script.estoydentro==true)
        {
            TorretaAnimator.SetBool("Trampa", true);
        }
        else
        {
            TorretaAnimator.SetBool("Trampa", false);
        }
    }
 
}
