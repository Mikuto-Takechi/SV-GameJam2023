using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Player���Փ˂����Ƃ��ɂ͂������߂̃X�N���v�g
/// </summary>
public class KnockBack : MonoBehaviour
{
    GameObject _player;
    Rigidbody _playerRigidbody;
    [Tooltip("������")]
    [SerializeField] float _repellingPower = 5f;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player");
        _playerRigidbody = _player.GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Vector3 _direction = (_player.transform.position - this.transform.position); //�Փˎ��̌������v�Z
            _playerRigidbody.AddForce(_direction.x * _repellingPower, _direction.y * _repellingPower, 0, ForceMode.Impulse);
        }
    }
}
