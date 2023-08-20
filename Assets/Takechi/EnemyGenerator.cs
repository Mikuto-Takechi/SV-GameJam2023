using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] GameObject _enemy = null;
    void Start()
    {
        Instantiate(_enemy,transform);
    }
    public void EnemyGenerate(int max)
    {
        StartCoroutine(EnemyGenerateDelay(max));
    }
    IEnumerator EnemyGenerateDelay(int max)
    {
        int generateCount = 0;
        while (generateCount < max)
        {
            generateCount++;
            Instantiate(_enemy, transform);
            yield return new WaitForSeconds(2);
        }
        yield break;
    }
}
