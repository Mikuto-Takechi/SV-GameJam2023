using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �X�e�[�W�[�ŃI�u�W�F�N�g���������߂̃X�N���v�g
/// ����p�̃g���K�[�ɃA�^�b�`
/// </summary>
public class DestroyObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject); //�g���K�[�ɓ��������������
    }
}
