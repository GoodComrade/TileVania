using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public Rigidbody2D projectile;              // Prefab of the rocket.
    public float speed = 20f;               // The speed the rocket will fire at.

    private PlayerController playerCtrl;       // Reference to the PlayerControl script.
    private Animator anim;

    void Awake()
    {
        playerCtrl = transform.root.GetComponent<PlayerController>();
    }

    void Update()
    {
        // If the fire button is pressed...
        if (Input.GetButtonDown("Fire1"))
        {

            // If the player is facing right...
            if (playerCtrl.facingRight)
            {
                Rigidbody2D bulletInstance = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as Rigidbody2D;
                bulletInstance.velocity = new Vector2(speed, 15f);
            }
            else
            {
                Rigidbody2D bulletInstance = Instantiate(projectile, transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as Rigidbody2D;
                bulletInstance.velocity = new Vector2(-speed, 15f);
            }

            
        }
    }
}
