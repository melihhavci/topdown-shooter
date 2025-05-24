using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public float lifeTime = 2f;

    void Start()
    {
        Destroy(gameObject, lifeTime); // Süre dolunca kendini yok et
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        // Buraya düþman çarpýþmasý ekleyeceðiz
        Destroy(gameObject); // Þimdilik her þeye çarpýnca yok ol
    }
}
