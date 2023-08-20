using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

/// <summary>
/// 隕石生成のためのスクリプト
/// </summary>
public class ObstacleGenerator : MonoBehaviour
{
    [Tooltip("生成する隕石のプレハブ(複数可)")]
    [SerializeField] GameObject[] _obstaclePrefab;
    [Tooltip("生成する場所(複数可)")]
    [SerializeField] Transform[] _transform;
    [Tooltip("シーン上にある動く隕石の数の制限")]
    [SerializeField] int _obstacleLimit = 30;

    void Update()
    {
        if (_obstacleLimit > this.GetComponentsInChildren<MeteoriteMove>().Length) //シーン上の隕石が制限数より少なくなったら生成
        {
            int indexObject = Random.Range(0, _obstaclePrefab.Length);
            int indexPosition = Random.Range(0, _transform.Length);
            Instantiate(_obstaclePrefab[indexObject], _transform[indexPosition].position, _obstaclePrefab[indexObject].transform.rotation);
        }
    }
}
