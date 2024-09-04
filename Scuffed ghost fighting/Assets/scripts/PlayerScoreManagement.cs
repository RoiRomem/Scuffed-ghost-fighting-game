using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScoreManagement : MonoBehaviour
{
    public int score = 0;

    public void AddScore(int ScoreAdded)
    {
        score += ScoreAdded;
    }
}
