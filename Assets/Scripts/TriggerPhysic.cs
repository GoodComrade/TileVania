using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPhysic : MonoBehaviour {

    public Rigidbody2D physicRb;

    void Start()
    {
        physicRb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        CircleCollider2D proj = col.gameObject.GetComponent<CircleCollider2D>();

        if (proj)
        {
            physicRb.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }

        BoxCollider2D box = col.gameObject.GetComponent<BoxCollider2D>();

        if (box)
        {
            physicRb.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }

        CompositeCollider2D compColl = col.gameObject.GetComponent<CompositeCollider2D>();

        if (compColl)
        {
			//Destroy(gameObject);
			physicRb.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
		}
    }
}
