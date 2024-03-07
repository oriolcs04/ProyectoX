using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaciones : MonoBehaviour
{
    Animator animator;
    private GameObject[] alien;

    void Start()
    {
        alien = new GameObject[4];
        alien = GameObject.FindGameObjectsWithTag("Player");
    }

    public void OnclickButton()
    {
        foreach (var alien in alien)
        {
            if (alien.activeInHierarchy == true)
            {
                animator = alien.GetComponentInChildren<Animator>();
            }
        }
        animator.SetTrigger("Mover");
    }
}

