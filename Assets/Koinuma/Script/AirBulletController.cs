using UnityEngine;

/// <summary>e’e§Œä</summary>
public class AirBulletController : MonoBehaviour
{
    [Header("’e‚Ì‘¬‚³")]
    [SerializeField] float _bulletSpeed;
    [Header("©‘RÁ–Å‚·‚é‚Ü‚Å‚ÌŠÔ")]
    [SerializeField] float _naturalExtinctionTime;

    float _xDirection;

    private void Start()
    {
        Destroy(gameObject, _naturalExtinctionTime);
    }

    private void Update()
    {
        transform.Translate(Vector3.right * _xDirection * _bulletSpeed * Time.deltaTime);
    }

    /// <summary>e’e‚Ì•ûŒü‚ğŒˆ‚ß‚é</summary>
    public void SetDirection(float sign)
    {
        _xDirection = sign;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
}
