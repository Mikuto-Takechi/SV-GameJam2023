using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 往復確認のためのスクリプト
/// 判定用のトリガーにアタッチ
/// </summary>
public class ReturnCheck : MonoBehaviour
{
    [Tooltip("行きの障害物(親オブジェクト)")]
    [SerializeField] GameObject _obstacle;
    [Tooltip("帰りの障害物(親オブジェクト)")]
    [SerializeField] GameObject _returnObstacle;
    [Tooltip("往復判定(チェックで帰りの判定)")]
    public bool _return = false; //往復の判定(行き)
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _return = true; //往復の判定(帰り)
            Destroy(_obstacle);
            _returnObstacle.SetActive(true);
        }
    }
}
