using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteMove : MonoBehaviour
{
    [Tooltip("隕石のスピード(行き)")]
    [SerializeField] float _meteoriteSpeed = 1f;
    [Tooltip("隕石のスピード(帰り)")]
    [SerializeField] float _meteoriteSpeedReturn = 1f;
    [Tooltip("往復判定のトリガーを入れる")]
    public ReturnCheck returnCheck;
    Rigidbody _meteoriteRigidbody;
    Vector3 _direction = new Vector3(1, 0, 0);

    void Start()
    {
        _meteoriteRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!returnCheck._return) //行き
        {
            Vector3 _meteoriteVelo = -_direction * _meteoriteSpeed; //左に移動
            _meteoriteRigidbody.velocity = _meteoriteVelo;
        }
        else //帰り
        {
            Vector3 _meteoriteVelo = _direction * _meteoriteSpeedReturn; //右に移動
            _meteoriteRigidbody.velocity = _meteoriteVelo;
        }
    }
}
