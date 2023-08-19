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
            _lineForWall = Vector2.left;//��
        }
        else
        {
            _lineForWall = Vector2.right;//�E
        }
        Ray ray = new Ray(start, _lineForWall); // Ray�𐶐�
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
            _lineForGround = new Vector2(-1f, -1f);//����
        }
        else
        {
            _lineForGround = new Vector2(1f, -1f);//�E��
        }
        Ray ray = new Ray(start, _lineForGround); // Ray�𐶐�
        Debug.DrawRay(ray.origin, ray.direction * 2, Color.red);
        Physics.Raycast(ray, out RaycastHit hitInfo, 2);
        // ���̌��o�����݂�
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
        velo.y = _rb.velocity.y;    // �����ɂ��Ă͌��݂̒l��ێ�����
        _rb.velocity = velo;        // ���x�x�N�g�����Z�b�g����
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out OxygenManager player))
        {
            player.OxygenConsumption(10);
        }
    }
}
