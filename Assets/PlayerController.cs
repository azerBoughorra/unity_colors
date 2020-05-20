using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;
    public int colorLayerToIgnore;
    public KeyCode jump;
    public KeyCode moveLeft;
    public KeyCode moveRight;




    private bool canJump;

    void Start()
    {
        canJump = true;
    }

    void Update()
    {
        transform.rotation = Quaternion.identity;
        transform.rotation = new Quaternion(transform.rotation.x, 0, transform.rotation.z, transform.rotation.w);

        if (Input.GetKeyDown(jump) && canJump)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
            canJump = false;
        }

        if (Input.GetKey(moveRight))
        {
            transform.Translate(new Vector2(this.moveSpeed * Time.deltaTime, 0));
        }

        if (Input.GetKey(moveLeft))
        {
            transform.Translate(new Vector2(-this.moveSpeed * Time.deltaTime, 0));
        }
    }
    private void resetJump(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            Debug.Log("ground");
            canJump = true;
        }
    }
    // private void ignoreColition(Collision2D other)
    // {
    //     if (other.gameObject.tag == "player")
    //     {
    //         Physics2D.IgnoreCollision(other.collider, GetComponent<Collider2D>());
    //     }
    //     if (other.gameObject.layer == colorLayerToIgnore)
    //     {
    //         Debug.Log("sd");
    //         Physics2D.IgnoreCollision(other.collider, GetComponent<Collider2D>());
    //     }
    // }

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionEnter2D(Collision2D other)
    {
        // ignoreColition(other);
        resetJump(other);


    }

}