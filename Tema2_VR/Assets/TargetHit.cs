using UnityEngine;

public class TargetHit : MonoBehaviour
{
    public ScoreManager scoreManager;

    private void OnCollisionEnter(Collision collision)
    {
        scoreManager.AddPoint();
    }
}