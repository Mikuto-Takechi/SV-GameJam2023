using UnityEngine;

/// <summary>��C�C�̃R���g���[���[</summary>
public class AirCannonController : MonoBehaviour
{
    [Tooltip("�}�Y���̈ʒu")]
    [SerializeField] Transform _muzzleTransform;
    [Tooltip("�e�̃Q�[���I�u�W�F�N�g")]
    [SerializeField] GameObject _airBullet;
    [Tooltip("�A�ˊԊu")]
    [SerializeField] float _interval;

    float _timer = 10;

    OxygenManager _oxygenManager;

    private void Start()
    {
        _oxygenManager = GetComponent<OxygenManager>();
    }

    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > _interval && Input.GetButton("Fire1"))
        {
            AudioManager.instance.PlaySE(10);
            GameObject bullet = Instantiate(_airBullet);
            bullet.transform.position = _muzzleTransform.position;
            bullet.GetComponent<AirBulletController>().SetDirection(Mathf.Sign(transform.localScale.x));
            _oxygenManager.AirCannonOxygenConsumption();
            _timer = 0;
        }
    }
}
