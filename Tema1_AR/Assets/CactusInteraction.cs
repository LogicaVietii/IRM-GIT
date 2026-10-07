using UnityEngine;

public class CactusFight : MonoBehaviour
{
    public Transform cactus1;
    public Transform cactus2;

    public Animator animator1;
    public Animator animator2;

    public float distanceToAttack = 100f;

    void Update()
    {
        float distance = Vector3.Distance(cactus1.position, cactus2.position);

        Debug.Log("Distance: " + distance);

        if (distance < distanceToAttack)
        {
            Debug.Log("ATTACK");
            animator1.SetBool("Attack", true);
            animator2.SetBool("Attack", true);
        }
        else
        {
            Debug.Log("IDLE");
            animator1.SetBool("Attack", false);
            animator2.SetBool("Attack", false);
        }
    }
}