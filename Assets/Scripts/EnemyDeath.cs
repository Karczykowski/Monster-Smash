using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDeath : MonoBehaviour
{
    public float pointsWorth;

    private void Start()
    {
        pointsWorth = GetComponent<Entity>().Attributes.GetAttribute(AttributeType.PointsWorth);
    }

    public void DestroyEnemy()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerPoints>().IncreastePoints(pointsWorth);

        Destroy(gameObject);
    }
}
