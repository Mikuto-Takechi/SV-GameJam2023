using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoriteMove : MonoBehaviour
{
    //[SerializeField] GameObject _meteorite;
    [Tooltip("隕石のスピード")]
    [SerializeField] float _meteoriteSpeed = 1f;
    GameObject _player;
    Rigidbody _meteoriteRigidbody;
    Rigidbody _playerRigidbody;
    Vector3 _direction = new Vector3(1, 0, 0);
    [Tooltip("往復判定のトリガーを入れる")]
    public ReturnCheck returnCheck;

    void Start()
    {
        _meteoriteRigidbody = GetComponent<Rigidbody>();
        _player = GameObject.Find("Player");
        _playerRigidbody = _player.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!returnCheck._return) //行き
        {
            Vector3 _meteoriteVelo = _direction * _meteoriteSpeed; //右に移動
            _meteoriteRigidbody.velocity = _meteoriteVelo;
        }
        else //帰り
        {
            Vector3 _meteoriteVelo = -_direction * _meteoriteSpeed; //左に移動
            _meteoriteRigidbody.velocity = _meteoriteVelo;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _playerRigidbody.AddForce(1, 0, 0, ForceMode.Impulse); //Playerがぶつかってきた向きに跳ね返せるようにしたい
        }
    }
}
