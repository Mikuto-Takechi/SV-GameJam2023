using UnityEngine;

/// <summary>�e�e����</summary>
public class AirBulletController : MonoBehaviour
{
    [Header("�e�̑���")]
    [SerializeField] float _bulletSpeed;
    [Header("���R���ł���܂ł̎���")]
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

    /// <summary>�e�e�̕��������߂�</summary>
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
