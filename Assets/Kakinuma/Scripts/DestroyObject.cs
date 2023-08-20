using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ステージ端でオブジェクトを消すためのスクリプト
/// 判定用のトリガーにアタッチ
/// </summary>
public class DestroyObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject); //トリガーに入った相手を消す
    }
}
