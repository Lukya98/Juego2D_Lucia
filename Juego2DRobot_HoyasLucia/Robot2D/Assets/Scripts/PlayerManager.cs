using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private float m_MaxSpeed = 10f;                    // Velocidad max en eje X
    [SerializeField] private float m_JumpForce = 400f;                  // Fuerza de salto
    [Range(0, 1)] [SerializeField] private float m_CrouchSpeed = .36f;  // max velocidad agachado
    [SerializeField] private bool m_AirControl = false;                 // Si el jugador puede controlarse en el aire
    [SerializeField] private LayerMask m_WhatIsGround;                  // Mask que determina que es el suelo

    



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

}
