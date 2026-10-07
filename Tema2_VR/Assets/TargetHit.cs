using UnityEngine;

public class TargetHit : MonoBehaviour
{
    public ScoreManager scoreManager;

    private Renderer targetRenderer;

    void Start()
    {
        targetRenderer = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.contactCount == 0)
            return;

        Vector3 hitPoint = collision.contacts[0].point;

        Bounds bounds = targetRenderer.bounds;
        Vector3 center = bounds.center;

        
        float dx = hitPoint.x - center.x;
        float dy = hitPoint.y - center.y;

        float radiusX = bounds.extents.x;
        float radiusY = bounds.extents.y;

        float nx = dx / radiusX;
        float ny = dy / radiusY;

        float distance = Mathf.Sqrt(nx * nx + ny * ny);

        int points;

        if (distance <= 0.20f)
            points = 10;
        else if (distance <= 0.40f)
            points = 8;
        else if (distance <= 0.60f)
            points = 6;
        else if (distance <= 0.80f)
            points = 4;
        else if (distance <= 1.00f)
            points = 2; 
        else
            return;

        Debug.Log("Collider hit: " + gameObject.name);
        Debug.Log("Hit: " + hitPoint);
        Debug.Log("Center: " + center);
        Debug.Log("Distance: " + distance);
        Debug.Log("Points: " + points);

        scoreManager.AddPoints(points);
    }
}