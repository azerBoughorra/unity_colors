using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovngGroun : MonoBehaviour
{
    // Start is called before the first frame update
    public float movSpeed;
    public float y;
    private Vector3 initialPosition;
    private Vector3 movedPosition;

    private bool falling = false;
    void Start()
    {
        initialPosition = transform.position;
        movedPosition = new Vector3(transform.position.x, y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(falling);
        // Debug.Log(transform.position.y);
        // Debug.Log(movedPosition.y);


        if (falling && transform.position.y > movedPosition.y)
        {
            transform.Translate(new Vector2(0, -movSpeed * Time.deltaTime));
        }
        if (!falling && transform.position.y < initialPosition.y)
        {
            transform.Translate(new Vector2(0, movSpeed * Time.deltaTime));
        }
    }

    public void fall()
    {
        Debug.Log("falling");
        falling = true;

    }
    public void rise()
    {
        Debug.Log("rise");

        falling = false;

    }
}
