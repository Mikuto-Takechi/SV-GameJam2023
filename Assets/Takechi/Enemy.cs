using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UI.Image;

public class Enemy : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 1.0f;
    Vector2 _lineForWall = Vector2.right;
    Vector2 _lineForGround = new Vector2(1f, -1f);
    Rigidbody _rb;
    bool _moveLeft = false;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
    }

    void MoveWithTurn()
    {
        Vector2 start = this.transform.position;
        if (_moveLeft)
        {
            _lineForWall = Vector2.left;//左
        }
        else
        {
            _lineForWall = Vector2.right;//右
        }
        Ray ray = new Ray(start, _lineForWall); // Rayを生成
        Debug.DrawRay(ray.origin, ray.direction *0.5f, Color.red);
        Physics.Raycast(ray, out RaycastHit hitInfo, 0.5f);
        if (hitInfo.collider)
        {
            //if (hitInfo.collider.TryGetComponent(out OxygenManager player))
            //{
            //    player.OxygenConsumption(10);
            //}
            _moveLeft = !_moveLeft;
        }
    }

    void MoveOnFloorWithTurn()
    {
        Vector2 start = this.transform.position;
        if (_moveLeft)
        {
            _lineForGround = new Vector2(-1f, -1f);//左下
        }
        else
        {
            _lineForGround = new Vector2(1f, -1f);//右下
        }
        Ray ray = new Ray(start, _lineForGround); // Rayを生成
        Debug.DrawRay(ray.origin, ray.direction * 2, Color.red);
        Physics.Raycast(ray, out RaycastHit hitInfo, 2);
        // 床の検出を試みる
        if (!hitInfo.collider)
        {
            _moveLeft = !_moveLeft;
        }
    }

    private void Move()
    {
        MoveWithTurn();
        MoveOnFloorWithTurn();
        Vector2 velo = Vector2.zero;
        if (_moveLeft)
        {
            velo = Vector2.left * _moveSpeed;
        }
        else
        {
            velo = Vector2.right * _moveSpeed;
        }
        velo.y = _rb.velocity.y;    // 落下については現在の値を保持する
        _rb.velocity = velo;        // 速度ベクトルをセットする
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out OxygenManager player))
        {
            player.OxygenConsumption(10);
        }
    }
}
