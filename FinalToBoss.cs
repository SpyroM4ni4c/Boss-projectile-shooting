using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalToBoss : MonoBehaviour
{
    public GameObject player;
    public Animator chandelier;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            
            chandelier.SetBool("isMoving", true);
        }
    }


}
