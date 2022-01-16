using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    public Animator animator;
    private Vector3 checkPoint;
    public GameObject player;
    public GameObject playerPrefab;
    public CinemachineVirtualCamera vc;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Killing Zone")
            die();
        else if(collision.tag == "Checkpoint")
        {
            checkPoint = collision.transform.position;
            Debug.Log("new Checkpoint " + checkPoint.x + " " + checkPoint.y);
        }
    }
    


    private void die()
    {
        animator.SetBool("Dead",true);
        Invoke("respawn",2);

    }

    private void respawn()
    {   
        animator.SetBool("Dead",false);
        player.transform.position = checkPoint;
        Debug.Log("respawn");
    }

}
