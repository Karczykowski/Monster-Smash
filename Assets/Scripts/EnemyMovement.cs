using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float speed;
    private Transform playerLocation;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        speed = GetComponent<Entity>().Attributes.GetAttribute(AttributeType.WalkSpeed);
    }
    private void Start()
    {
        playerLocation = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        if (playerLocation != null)
        {
            Vector2 direction = playerLocation.position - transform.position;
            direction.Normalize();
            _rigidbody.velocity = direction * speed;
        }
        else
        {
            _rigidbody.velocity = Vector2.zero;
        }
    }
}
