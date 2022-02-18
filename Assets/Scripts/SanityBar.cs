using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SanityBar : MonoBehaviour
{
    public Slider healthBar;
    public float playerHealth;
    public bool insane = true;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Slider>();
        playerHealth = 0;
    }

    void InsaneFill()
    {
        playerHealth += (float)0.0001;
        healthBar.value = playerHealth;
        if(playerHealth >= 1)
        {
            
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
            insane = false;
        if(insane)
            InsaneFill();   
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "saneSpace")
        {
            insane = false;
        }
    }
}
