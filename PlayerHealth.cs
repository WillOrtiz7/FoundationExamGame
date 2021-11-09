using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public bool hasDied;
    
    void Start()
    {
        hasDied = false;
    }

    void Update()
    {
        if (gameObject.transform.position.y < -9)
        {
            Debug.Log("Player has died!");
            hasDied = true;
        }
        if (hasDied == true)
        {
            StartCoroutine("Die");
        }
    }

    IEnumerator Die()
    {
        SceneManager.LoadScene("Prototype1");
        yield return null;
    }
}
