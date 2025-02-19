using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class playerwalking : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speeed = 5f;
    private Vector2 walkdirection = Vector2.zero;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
    void direction(Vector2 inptvect)
    {
        walkdirection = inptvect;
    }
    private void FixedUpdate()
    {
        controlmovement();
    }

    void controlmovement()
    {
      rb.MovePosition(rb.position + (walkdirection * speeed * Time.fixedDeltaTime));
    }
    

    private void OnEnable()
    {
        Actions.moving += direction;
    }

    private void OnDisable()
    {
        Actions.moving -= direction;

    }
}
