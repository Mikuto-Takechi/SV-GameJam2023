using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.Experimental.GraphView.GraphView;

/// <summary>
/// 覐ΐ����̂��߂̃X�N���v�g
/// </summary>
public class ObstacleGenerator : MonoBehaviour
{
    [Tooltip("��������覐΂̃v���n�u(������)")]
    [SerializeField] GameObject[] _obstaclePrefab;
    [Tooltip("��������ꏊ(������)")]
    [SerializeField] Transform[] _transform;
    [Tooltip("�V�[����ɂ��铮��覐΂̐��̐���(�g�p�s�̂��߃C���^�[�o���ő���)")]
    [SerializeField] int _obstacleLimit = 30;
    [Tooltip("�����̎��ԊԊu")]
    [SerializeField] float _interval = 3f;
    float _timer;
    GameObject _obstacles;

    void Start()
    {
        _obstacles = GameObject.FindWithTag("MeteoriteParent");
    }

    void Update()
    {
        if (_obstacleLimit > _obstacles.GetComponentsInChildren<MeteoriteMove>().Length) //�V�[�����覐΂���������菭�Ȃ��Ȃ����琶��
        {
            _timer += Time.deltaTime;
            if (_timer > _interval)
            {
                _timer = 0;
                int indexObject = Random.Range(0, _obstaclePrefab.Length);
                int indexPosition = Random.Range(0, _transform.Length);
                Instantiate(_obstaclePrefab[indexObject], _transform[indexPosition].position, _obstaclePrefab[indexObject].transform.rotation);
            }
        }
    }
}
