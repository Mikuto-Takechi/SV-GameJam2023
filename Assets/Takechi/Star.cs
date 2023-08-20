using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Star : MonoBehaviour
{
    EnemyGenerator[] _generators = null;
    bool _toggle = true;
    private void Start()
    {
        _generators = FindObjectsOfType<EnemyGenerator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && _toggle)
        {
            foreach(EnemyGenerator generator in _generators)
            {
                generator.EnemyGenerate(2);
            }
            AudioManager.instance.PlaySE(6);
            AudioManager.instance.StopBGM();
            AudioManager.instance.PlayBGM(2);
            _toggle = false;
            gameObject.SetActive(false);
        }
    }
}
