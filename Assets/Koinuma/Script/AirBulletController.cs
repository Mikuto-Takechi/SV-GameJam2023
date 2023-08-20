using UnityEngine;

/// <summary>�e�e����</summary>
public class AirBulletController : MonoBehaviour
{
    [SerializeField] float _bulletSpeed;

    float _xDirection;

    private void Update()
    {
        transform.Translate(Vector3.right * _xDirection * _bulletSpeed * Time.deltaTime);
    }

    /// <summary>�e�e�̕��������߂�</summary>
    public void SetDirection(float sign)
    {
        _xDirection = sign;
    }
}
