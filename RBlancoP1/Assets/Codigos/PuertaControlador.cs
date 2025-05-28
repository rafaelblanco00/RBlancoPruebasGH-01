using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaControlador : MonoBehaviour
{

    public Animator animator;

    private void Awake()
    {
        animator.SetBool("Abrir",false);
    }

    public void AbrirCerrarPuerta()
    {
        animator.SetBool("Abrir", !animator.GetBool("Abrir"));
    }

}
