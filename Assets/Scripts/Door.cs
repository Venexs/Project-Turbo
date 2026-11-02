using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator anim;
    public GameObject AudioSource;

    public void OnTriggerEnter(Collider other)
    {
        anim.SetInteger("Condition", 1);
        AudioSource.SetActive(true);
    }
}
