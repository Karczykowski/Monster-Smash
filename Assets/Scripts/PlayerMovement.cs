using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private Vector2 _movementInput;

    [SerializeField] private float moveSpeed = 5;
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
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
