using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �����m�F�̂��߂̃X�N���v�g
/// ����p�̃g���K�[�ɃA�^�b�`
/// </summary>
public class ReturnCheck : MonoBehaviour
{
    [Tooltip("�s���̏�Q��(�e�I�u�W�F�N�g)")]
    [SerializeField] GameObject _obstacle;
    [Tooltip("�A��̏�Q��(�e�I�u�W�F�N�g)")]
    [SerializeField] GameObject _returnObstacle;
    [Tooltip("��������(�`�F�b�N�ŋA��̔���)")]
    [SerializeField] GameObject _enemyGenerator1;
    [SerializeField] GameObject _enemyGenerator2;

    public bool _return = false; //�����̔���(�s��)
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _return = true; //�����̔���(�A��)
            Destroy(_obstacle);
            _returnObstacle.SetActive(true);
            Destroy(_enemyGenerator1);
            Destroy(_enemyGenerator2);
            AudioManager.instance.PlaySE(5);
        }
    }
}
