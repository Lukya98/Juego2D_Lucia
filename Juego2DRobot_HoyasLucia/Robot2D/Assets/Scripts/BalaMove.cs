using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaMove : MonoBehaviour
{
    PlayerManager scriptplayer;
    // Start is called before the first frame update
    void Start()
    {
        transform.parent = null;
        scriptplayer = GameObject.Find("Robot").GetComponent<PlayerManager>();
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * 10f * Time.deltaTime);

        Destroy(gameObject,10);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Robot" && scriptplayer.alive)
        {
            collision.gameObject.SendMessage("Morir");
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
            print(gameObject);
        }
       
    }
   
      
}
