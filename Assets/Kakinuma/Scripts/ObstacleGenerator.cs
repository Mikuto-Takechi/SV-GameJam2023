using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

/// <summary>
/// 覐ΐ����̂��߂̃X�N���v�g
/// </summary>
public class ObstacleGenerator : MonoBehaviour
{
    [Tooltip("��������覐΂̃v���n�u(������)")]
    [SerializeField] GameObject[] _obstaclePrefab;
    [Tooltip("��������ꏊ(������)")]
    [SerializeField] Transform[] _transform;
    [Tooltip("�V�[����ɂ��铮��覐΂̐��̐���")]
    [SerializeField] int _obstacleLimit = 30;

    void Update()
    {
        if (_obstacleLimit > this.GetComponentsInChildren<MeteoriteMove>().Length) //�V�[�����覐΂���������菭�Ȃ��Ȃ����琶��
        {
            int indexObject = Random.Range(0, _obstaclePrefab.Length);
            int indexPosition = Random.Range(0, _transform.Length);
            Instantiate(_obstaclePrefab[indexObject], _transform[indexPosition].position, _obstaclePrefab[indexObject].transform.rotation);
        }
    }
}
