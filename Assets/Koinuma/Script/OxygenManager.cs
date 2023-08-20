using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �v���C���[�̎_�f�ʂ��Ǘ�����
/// </summary>
public class OxygenManager : MonoBehaviour
{
    [Tooltip("�_�f�Q�[�W�̃X���C�_�[")]
    [SerializeField] Slider _slider;
    [Header("�_�f�ʍő�_�f�ʊ���(%)")]
    [Tooltip("���ړ���1�b�Ԃ�����̏����")]
    [SerializeField] float _moveOxygenConsumption;
    [Tooltip("�W�����v�ł̏����")]
    [SerializeField] float _jumpOxygenConsumption;
    [Tooltip("��C�C�ł̎_�f�����")]
    [SerializeField] float _airCannonOxygenConsumption;
    [Tooltip("�`�F�b�N�|�C���g�ŉ񕜂���_�f��")]
    [SerializeField] float _CheckPointOxygen;

    Animator _animator;

    /// <summary>�ړ��ł̎_�f����</summary>
    public void MoveOxygenConsumption()
    {
        _slider.value -= _slider.maxValue * _moveOxygenConsumption / 100 * Time.deltaTime;
        OxygenLevelCheck();
        _animator = GetComponent<Animator>();
    }

    /// <summary>�W�����v�ł̎_�f����</summary>
    public void JumpOxygenConsumption()
    {
        _slider.value -= _slider.maxValue * _jumpOxygenConsumption / 100;
        OxygenLevelCheck();
    }

    /// <summary>��C�C�ł̎_�f����</summary>
    public void AirCannonOxygenConsumption()
    {
        _slider.value -= _slider.maxValue * _airCannonOxygenConsumption / 100;
        OxygenLevelCheck();
    }

    /// <summary>�����Ŏ_�f�����点��</summary>
    public void OxygenConsumption(int consumption)
    {
        _slider.value -= _slider.maxValue * consumption / 100;
        OxygenLevelCheck();
        _animator.SetTrigger("Hit");
    }

    /// <summary>�`�F�b�N�|�C���g�ł̎_�f�����ƒl��Ԃ�</summary>
    public float GetAmountOfOxygenOnCheckPoint()
    {
        _slider.value += _slider.maxValue * _CheckPointOxygen / 100;
        return _slider.value;
    }

    /// <summary>�_�f�ʃ`�F�b�N</summary>
    public void OxygenLevelCheck()
    {
        if (_slider.value <= 0)
        {
            GameManager.instance.GameOver();
        }
    }
}
