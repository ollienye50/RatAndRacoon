using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wipe : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
        {
      
        if (other.gameObject.name == "player")
        {
            Debug.Log("ew player, go away");

        }
    }
}
