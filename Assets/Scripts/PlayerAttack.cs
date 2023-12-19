using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private Transform meleeAttackChild;
    [SerializeField] private ParticleSystem _attackPartile;
    [SerializeField] private LayerMask _enemiesLayer;

    private float range = 0.75f;
    private float damage;

    private void Awake()
    {
        Entity entity = GetComponent<Entity>();

        damage = entity.Attributes.GetAttribute(AttributeType.AttackDamage);
        range = entity.Attributes.GetAttribute(AttributeType.AttackRange);
    }
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            SwingAttack();
        }
    }

    void SwingAttack()
    {
        Instantiate(_attackPartile, meleeAttackChild.position, Quaternion.identity);

        Collider2D[] enemiesHit = Physics2D.OverlapCircleAll(meleeAttackChild.position, range, _enemiesLayer);

        foreach (Collider2D hit in enemiesHit)
        {
            hit.GetComponent<EnemyHitPoints>().TakeDamage(damage);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(meleeAttackChild.position, range);
    }
}
