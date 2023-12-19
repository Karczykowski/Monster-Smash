using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitPoints : MonoBehaviour
{
    private float hitPoints;

    private void Awake()
    {
        hitPoints = GetComponent<Entity>().Attributes.GetAttribute(AttributeType.HitPoints);
    }
    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        if (hitPoints <= 0)
            KillEnemy();
    }

    public void KillEnemy()
    {
        GetComponent<EnemyDeath>().DestroyEnemy();
    }
}
