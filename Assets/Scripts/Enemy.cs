using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 3f;
    private Transform target;

    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (target != null)
        {
            Vector3 dir = (target.position - transform.position).normalized;
            transform.position += dir * moveSpeed * Time.deltaTime;

            // Ýsteðe baðlý: hedefe doðru dön
            transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            Destroy(other.gameObject); // Mermiyi yok et
            Destroy(gameObject);       // Kendini yok et
        }
    }
}
