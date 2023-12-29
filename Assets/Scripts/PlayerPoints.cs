using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPoints : MonoBehaviour
{
    private float points;
    [SerializeField] TextMeshProUGUI pointsText;
    void Start()
    {
        points = 0;
    }
    private void Update()
    {
        pointsText.text = "Points: " + points.ToString();
    }

    public void IncreastePoints(float n)
    {
        points += n;
    }
}
