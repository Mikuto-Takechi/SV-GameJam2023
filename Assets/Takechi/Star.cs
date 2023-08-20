using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Star : MonoBehaviour
{
    EnemyGenerator[] _generators = null;
    private void Start()
    {
        _generators = FindObjectsOfType<EnemyGenerator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            foreach(EnemyGenerator generator in _generators)
            {
                // 取得した子オブジェクトのコンポーネントに対して処理を行う
                foreach (Component component in generator.GetComponentsInChildren<Component>())
                {
                    Destroy(component.gameObject);
                }
            }
            AudioManager.instance.PlaySE(5);
        }
    }
}
