using UnityEngine;

/// <summary>銃弾制御</summary>
public class AirBulletController : MonoBehaviour
{
    [Header("弾の速さ")]
    [SerializeField] float _bulletSpeed;
    [Header("自然消滅するまでの時間")]
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

    /// <summary>銃弾の方向を決める</summary>
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
