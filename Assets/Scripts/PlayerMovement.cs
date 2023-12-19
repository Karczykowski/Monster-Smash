using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private Vector2 _movementInput;

    private float moveSpeed;
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        moveSpeed = GetComponent<Entity>().Attributes.GetAttribute(AttributeType.WalkSpeed);
    }

    void FixedUpdate()
    {
        _rigidbody.velocity = _movementInput * moveSpeed;
    }

    private void OnMove(InputValue inputvalue)
    {
        _movementInput = inputvalue.Get<Vector2>();
    }
}
