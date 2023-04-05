using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTPSController : MonoBehaviour
{
    public Camera cam;
    private InputData input;
    private CharacterAnimBasedMovement characterMovement;
    public AudioSource pasos;
    private bool Hactivo;
    private bool Vactivo;

    void Start()
    {
        characterMovement = GetComponent<CharacterAnimBasedMovement>();
       
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Get input from player
        input.getInput();

        // Apply input to character
        characterMovement.moveCharacter(input.hMovement, input.vMovement, cam, input.jump, input.dash, input.golpe());

        if (Input.GetButtonDown("Horizontal"))
        {
            Hactivo = true;
            pasos.Play();
        }
        if (Input.GetButtonDown("Vertical"))
        {
            Vactivo = true;
            pasos.Play();
        }
        if (Input.GetButtonUp("Horizontal"))
        {
            Hactivo = false;
            if(Vactivo == false)
            {
                pasos.Pause();
            }
        }
        if (Input.GetButtonUp("Vertical"))
        {
            Vactivo = false;
            if(Hactivo == false)
            {
                pasos.Pause();
            }
        }

    }

    
}