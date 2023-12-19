using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHitPoints : MonoBehaviour
{
    private float hitPoints;
    private float minHitPoints;
    private float maxHitPoints;
    [SerializeField] TextMeshProUGUI hpText;
    Entity entity;

    private void Awake()
    {
        entity = GetComponent<Entity>();
        hitPoints = entity.Attributes.GetAttribute(AttributeType.HitPoints);
        minHitPoints = entity.Attributes.GetMinimum(AttributeType.HitPoints);
        maxHitPoints = entity.Attributes.GetMaximum(AttributeType.HitPoints);
    }
    private void Start()
    {
        hpText.text = "HP: " + hitPoints.ToString();
    }
    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        hitPoints = Mathf.Clamp(hitPoints, minHitPoints, maxHitPoints);
        hpText.text = "HP: " + hitPoints.ToString();
        if(hitPoints <= minHitPoints)
            KillPlayer();
    }

    public void KillPlayer()
    {
        GetComponent<PlayerDeath>().DestroyPlayer();
    }
}
