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
                // �擾�����q�I�u�W�F�N�g�̃R���|�[�l���g�ɑ΂��ď������s��
                foreach (Component component in generator.GetComponentsInChildren<Component>())
                {
                    Destroy(component.gameObject);
                }
            }
            AudioManager.instance.PlaySE(5);
        }
    }
}
