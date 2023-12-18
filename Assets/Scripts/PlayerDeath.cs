using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    private void DestroyPlayer()
    {
        Destroy(gameObject);
    }
}
