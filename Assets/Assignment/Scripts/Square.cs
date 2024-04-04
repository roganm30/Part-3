using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class Square : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    bool isActive;
    bool onSelf;
    protected Vector2 destination;
    Vector2 movement;
    protected float speed = 4;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        destination = transform.position;
        Chosen(false);
    }

    public void Chosen(bool value)
    {
        isActive = value;
    }

    private void OnMouseUp()
    {
        onSelf = false;
    }

    protected virtual void Update()
    {
        // move to chosen location
        if (Input.GetMouseButtonDown(0) && isActive && !onSelf)
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

    }

    private void FixedUpdate()
    {
        movement = destination - (Vector2)transform.position;

        //stop moving if close to the chosen location
        if (movement.magnitude < 0.1)
        {
            movement = Vector2.zero;
            speed = 4;
        }

        rigidbody2d.MovePosition(rigidbody2d.position + movement.normalized * speed * Time.deltaTime);
    }

    public virtual WhichItem Collect()
    {
        return WhichItem.Square; //here there is no item which will reference only to square
                                 //in this situation, i am using square as the "default" and thus will make specific changes for the individual squares if needed
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        speed = 0;
    }

}
