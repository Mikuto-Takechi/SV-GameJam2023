using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteMove : MonoBehaviour
{
    [Tooltip("覐΂̃X�s�[�h(�s��)")]
    [SerializeField] float _meteoriteSpeed = 1f;
    [Tooltip("覐΂̃X�s�[�h(�A��)")]
    [SerializeField] float _meteoriteSpeedReturn = 1f;
    [Tooltip("��������̃g���K�[������")]
    public ReturnCheck returnCheck;
    Rigidbody _meteoriteRigidbody;
    Vector3 _direction = new Vector3(1, 0, 0);

    void Start()
    {
        _meteoriteRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!returnCheck._return) //�s��
        {
            Vector3 _meteoriteVelo = -_direction * _meteoriteSpeed; //���Ɉړ�
            _meteoriteRigidbody.velocity = _meteoriteVelo;
        }
        else //�A��
        {
            Vector3 _meteoriteVelo = _direction * _meteoriteSpeedReturn; //�E�Ɉړ�
            _meteoriteRigidbody.velocity = _meteoriteVelo;
        }
    }
}
