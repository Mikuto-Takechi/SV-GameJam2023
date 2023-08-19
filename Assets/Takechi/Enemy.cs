using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 1.0f;
    [SerializeField] Vector2 _lineForWall = Vector2.right;
    [SerializeField] Vector2 _lineForGround = new Vector2(1f, -1f);
    [SerializeField] LayerMask _tileMapLayer = 0;
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
        Debug.DrawLine(start, start + _lineForWall);
        RaycastHit2D hit = Physics2D.Linecast(start, start + _lineForWall, _tileMapLayer);

        if (hit.collider)
        {
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
        Debug.DrawLine(start, start + _lineForGround);    // ray を Scene 上に描く
        // 床の検出を試みる
        RaycastHit2D hit = Physics2D.Linecast(start, start + _lineForGround, _tileMapLayer);

        if (!hit.collider)
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
}
