using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 4.0f;
    public float jumpForce = 400.0f;

    private Rigidbody2D _rigidbody2D;



    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D =  GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMove(InputValue input)
    {
        Debug.Log("OnMove");
        Vector2 velocity = input.Get<Vector2>() * speed;
        //_rigidbody2D.AddForce(velocity, ForceMode2D.Impulse);
        _rigidbody2D.velocity = velocity;
    }


    private void OnJump()
    {
        Debug.Log("OnJump");
        _rigidbody2D.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }

    private void OnTeleport(InputValue input)
    {
        Debug.Log("OnTeleport");
        Vector2 position = Camera.main.ScreenToWorldPoint(input.Get<Vector2>());
        transform.position = position;
    }

}
