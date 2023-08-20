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
                generator.EnemyGenerate(2);
            }
            AudioManager.instance.PlaySE(5);
        }
    }
}
