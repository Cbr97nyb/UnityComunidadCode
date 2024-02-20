using UnityEngine;

public class BulletProjectileRayCast : MonoBehaviour
{
    [SerializeField] private Transform vfxHitGreen;
    [SerializeField] private Transform vfxHitRed;

    private Vector3 targetPosition;

    public void Setup(Vector3 targetPosition)
    {
        this.targetPosition = targetPosition;
    }

    void Update()
    {
        float distanceBefore = Vector3.Distance(transform.position, targetPosition);

        Vector3 moveDir = (targetPosition - transform.position).normalized;
        float moveSpeed = 200f;
        transform.position += moveDir * moveSpeed * Time.deltaTime;

        float ditanceAfter = Vector3.Distance(transform.position, targetPosition);

        if (distanceBefore < ditanceAfter)
        {
            Instantiate(vfxHitRed, targetPosition, Quaternion.identity);
            transform.Find("Trail").SetParent(null);
            Destroy(gameObject);
        }
    }
}
