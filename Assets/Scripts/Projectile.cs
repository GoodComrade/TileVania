using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collider)
    {
        CompositeCollider2D compColl = collider.gameObject.GetComponent<CompositeCollider2D>();
        BoxCollider2D boxColl = collider.gameObject.GetComponent<BoxCollider2D>();

        if (compColl || boxColl)
        {
            Hit();
        }
    }

    public void Hit()
    {
        Destroy(gameObject);
    }

}
