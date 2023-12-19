using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContactDamage : MonoBehaviour
{
    private float damage;
    private void Awake()
    {
        damage = GetComponent<Entity>().Attributes.GetAttribute(AttributeType.AttackDamage);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHitPoints>().TakeDamage(damage);
        }
    }
}
