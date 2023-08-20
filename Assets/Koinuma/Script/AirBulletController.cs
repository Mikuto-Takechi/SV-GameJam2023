using UnityEngine;

/// <summary>e’e§Œä</summary>
public class AirBulletController : MonoBehaviour
{
    [SerializeField] float _bulletSpeed;

    float _xDirection;

    private void Update()
    {
        transform.Translate(Vector3.right * _xDirection * _bulletSpeed * Time.deltaTime);
    }

    /// <summary>e’e‚Ì•ûŒü‚ğŒˆ‚ß‚é</summary>
    public void SetDirection(float sign)
    {
        _xDirection = sign;
    }
}
