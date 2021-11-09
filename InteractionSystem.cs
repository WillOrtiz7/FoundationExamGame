using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSystem : MonoBehaviour
{

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Interact"))
        {
            Debug.Log("COLLISION");
        }
    }
    
    void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("NO COLLISION");
    }
}
