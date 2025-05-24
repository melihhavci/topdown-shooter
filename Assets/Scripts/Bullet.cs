using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public float lifeTime = 2f;

    void Start()
    {
        Destroy(gameObject, lifeTime); // S�re dolunca kendini yok et
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        // Buraya d��man �arp��mas� ekleyece�iz
        Destroy(gameObject); // �imdilik her �eye �arp�nca yok ol
    }
}
