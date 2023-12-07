using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private Transform meleeAttackChild;
    [SerializeField] private ParticleSystem _attackPartile;
    [SerializeField] private LayerMask _enemiesLayer;

    [SerializeField] private float range = 0.75f;
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
            Destroy(hit.gameObject);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(meleeAttackChild.position, range);
    }
}
