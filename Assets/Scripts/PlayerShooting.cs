using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public Camera cam;

    public float fireRate = 0.2f;
    private float nextFireTime = 0f;

    void Update()
    {
        if (Input.GetMouseButton(0) && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
    {
        // Ray ile mouse'un hedeflediði yeri bul
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hitInfo, 100f))
        {
            // Hedef yön
            Vector3 dir = (hitInfo.point - firePoint.position).normalized;

            // O yöne dönük mermi oluþtur
            Quaternion rot = Quaternion.LookRotation(dir);
            Instantiate(bulletPrefab, firePoint.position, rot);
        }
    }
}
