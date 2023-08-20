using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.Experimental.GraphView.GraphView;

/// <summary>
/// 隕石生成のためのスクリプト
/// </summary>
public class ObstacleGenerator : MonoBehaviour
{
    [Tooltip("生成する隕石のプレハブ(複数可)")]
    [SerializeField] GameObject[] _obstaclePrefab;
    [Tooltip("生成する場所(複数可)")]
    [SerializeField] Transform[] _transform;
    [Tooltip("シーン上にある動く隕石の数の制限(使用不可のためインターバルで操作)")]
    [SerializeField] int _obstacleLimit = 30;
    [Tooltip("生成の時間間隔")]
    [SerializeField] float _interval = 3f;
    float _timer;
    GameObject _obstacles;

    void Start()
    {
        _obstacles = GameObject.FindWithTag("MeteoriteParent");
    }

    void Update()
    {
        if (_obstacleLimit > _obstacles.GetComponentsInChildren<MeteoriteMove>().Length) //シーン上の隕石が制限数より少なくなったら生成
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
