using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �v���C���[�̎_�f�ʂ��Ǘ�����
/// </summary>
public class OxygenManager : MonoBehaviour
{
    [Tooltip("�_�f�Q�[�W�̃X���C�_�[")]
    [SerializeField] Slider _slider;
    [Header("�_�f����ʍő�_�f�ʊ���(%)")]
    [Tooltip("���ړ���1�b�Ԃ�����̏����")]
    [SerializeField] float _moveOxygenConsumption;
    [Tooltip("�W�����v�ł̏����")]
    [SerializeField] float _jumpOxygenConsumption;
    [Tooltip("��C�C�ł̎_�f�����")]
    [SerializeField] float _airCannonOxygenConsumption;

    /// <summary>�ړ��ł̎_�f����</summary>
    public void MoveOxygenConsumption()
    {
        _slider.value -= _slider.maxValue * _moveOxygenConsumption / 100 * Time.deltaTime;
    }

    /// <summary>�W�����v�ł̎_�f����</summary>
    public void JumpOxygenConsumption()
    {
        _slider.value -= _slider.maxValue * _jumpOxygenConsumption / 100;
    }

    /// <summary>��C�C�ł̎_�f����</summary>
    public void AirCannonOxygenConsumption()
    {
        _slider.value -= _slider.maxValue * _airCannonOxygenConsumption / 100;
    }

    public void OxygenConsumption(int consumption)
    {
        _slider.value -= _slider.maxValue * consumption / 100;
    }
}
