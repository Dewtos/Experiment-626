using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{   
    [SerializeField] Color32 hasPizzaColor = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 noPizzaColor = new Color32 (1, 1, 1, 1);
    
    [SerializeField] float destroyDelay = 0.2f;
    bool hasPizza;

    SpriteRenderer spriteRenderer;

     void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("shit!");
    }  
        
        void OnTriggerEnter2D(Collider2D other) 
        {
            if (other.tag == "Pizza" && !hasPizza)
            {
                Debug.Log("Pizza time");
                hasPizza = true;
                spriteRenderer.color = hasPizzaColor;
                Destroy(other.gameObject, destroyDelay);
            }

            if (other.tag == "Customer" && hasPizza)
            {
                Debug.Log("Happy Birthday!");
                hasPizza = false;
                spriteRenderer.color = noPizzaColor;
            }
        }
}
