using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] GameObject _enemy = null;
    void Start()
    {
        var enemy = Instantiate(_enemy,transform);
    }

    void Update()
    {
        
    }
}
