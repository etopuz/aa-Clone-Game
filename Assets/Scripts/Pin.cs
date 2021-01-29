using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{

    private bool isPinned = false; // for checking is spear pinned to rotator.
    private float speed = 20f;

    public Rigidbody2D rb;
    private Rotator rotatorScript;

    private void Awake()
    {
        GameObject rotatorObj = GameObject.FindGameObjectWithTag("Rotator");
        rotatorScript = rotatorObj.GetComponent<Rotator>();
    }

    void FixedUpdate()
    {
        if(!isPinned)
        rb.MovePosition(rb.position+ Vector2.up * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Rotator"))
        {
            transform.SetParent(other.transform); // making pin object child of Rotator so pins can rotate with rotator
            isPinned = true;
            rotatorScript.updateSpeed();
            Score.PinCount++;
        }
        else if (other.CompareTag("Pin"))
        {
            GameManager.Instance.EndGame();
        }
    }


}


