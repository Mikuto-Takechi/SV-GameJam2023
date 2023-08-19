using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �v���C���[�̎_�f�ʂ��Ǘ�����
/// </summary>
public class OxygenManager : MonoBehaviour
{
    [Tooltip("�_�f�Q�[�W�̃X���C�_�[")]
    [SerializeField] Slider _slider;
    [Header("���͂ɂ��_�f�����")]
    [Tooltip("���ړ���1�b�Ԃ�����̏����")]
    [SerializeField] float _moveOxygenConsumption;
    [Tooltip("�W�����v�ł̏����")]
    [SerializeField] float _jumpOxygenConsumption;

    public void MoveOxygenConsumption()
    {
        _slider.value -= _moveOxygenConsumption * Time.deltaTime;
    }

    public void JumpOxygenConsumption()
    {
        _slider.value -= _jumpOxygenConsumption;
    }
}
