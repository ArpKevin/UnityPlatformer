using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] private float projectileSpeed = 15;

    private Rigidbody2D rigidbody2d;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        rigidbody2d.AddForce(new(
            x: transform.rotation.z == 0
            ? projectileSpeed
            : -projectileSpeed,
            y: 0), ForceMode2D.Impulse);
    }
}