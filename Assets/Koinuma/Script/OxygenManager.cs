using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// プレイヤーの酸素量を管理する
/// </summary>
public class OxygenManager : MonoBehaviour
{
    [Tooltip("酸素ゲージのスライダー")]
    [SerializeField] Slider _slider;
    [Header("酸素消費量最大酸素量割合(%)")]
    [Tooltip("横移動で1秒間あたりの消費量")]
    [SerializeField] float _moveOxygenConsumption;
    [Tooltip("ジャンプでの消費量")]
    [SerializeField] float _jumpOxygenConsumption;
    [Tooltip("空気砲での酸素消費量")]
    [SerializeField] float _airCannonOxygenConsumption;
    [SerializeField] float _CheckPointOxygen;

    /// <summary>移動での酸素消費</summary>
    public void MoveOxygenConsumption()
    {
        _slider.value -= _slider.maxValue * _moveOxygenConsumption / 100 * Time.deltaTime;
    }

    /// <summary>ジャンプでの酸素消費</summary>
    public void JumpOxygenConsumption()
    {
        _slider.value -= _slider.maxValue * _jumpOxygenConsumption / 100;
    }

    /// <summary>空気砲での酸素消費</summary>
    public void AirCannonOxygenConsumption()
    {
        _slider.value -= _slider.maxValue * _airCannonOxygenConsumption / 100;
    }

    public void OxygenConsumption(int consumption)
    {
        _slider.value -= _slider.maxValue * consumption / 100;
    }

    public float GetAmountOfOxygenOnCheckPoint()
    {
        _slider.value += _slider.maxValue * _CheckPointOxygen / 100;
        return _slider.value;
    }
}
