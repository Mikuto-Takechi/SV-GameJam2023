using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteMove : MonoBehaviour
{
    //[SerializeField] GameObject _meteorite;
    [Tooltip("覐΂̃X�s�[�h")]
    [SerializeField] float _meteoriteSpeed = 1f;
    GameObject _player;
    Rigidbody _meteoriteRigidbody;
    Rigidbody _playerRigidbody;
    Vector3 _direction = new Vector3(1, 0, 0);
    [Tooltip("��������̃g���K�[������")]
    public ReturnCheck returnCheck;

    void Start()
    {
        _meteoriteRigidbody = GetComponent<Rigidbody>();
        _player = GameObject.Find("Player");
        _playerRigidbody = _player.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!returnCheck._return) //�s��
        {
            Vector3 _meteoriteVelo = _direction * _meteoriteSpeed; //�E�Ɉړ�
            _meteoriteRigidbody.velocity = _meteoriteVelo;
        }
        else //�A��
        {
            Vector3 _meteoriteVelo = -_direction * _meteoriteSpeed; //���Ɉړ�
            _meteoriteRigidbody.velocity = _meteoriteVelo;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _playerRigidbody.AddForce(1, 0, 0, ForceMode.Impulse); //Player���Ԃ����Ă��������ɒ��˕Ԃ���悤�ɂ�����
        }
    }
}
