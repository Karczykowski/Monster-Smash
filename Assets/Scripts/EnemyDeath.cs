using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDeath : MonoBehaviour
{
    public void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}
