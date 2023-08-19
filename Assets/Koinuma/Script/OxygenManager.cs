using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// プレイヤーの酸素量を管理する
/// </summary>
public class OxygenManager : MonoBehaviour
{
    [Tooltip("酸素ゲージのスライダー")]
    [SerializeField] Slider _slider;
    [Header("酸素消費量")]
    [Tooltip("横移動で1秒間あたりの消費量")]
    [SerializeField] float _moveOxygenConsumption;
    [Tooltip("ジャンプでの消費量")]
    [SerializeField] float _jumpOxygenConsumption;
    [Tooltip("空気砲での酸素消費量")]
    [SerializeField] float _airCannonOxygenConsumption;

    /// <summary>移動での酸素消費</summary>
    public void MoveOxygenConsumption()
    {
        _slider.value -= _moveOxygenConsumption * Time.deltaTime;
    }

    /// <summary>ジャンプでの酸素消費</summary>
    public void JumpOxygenConsumption()
    {
        _slider.value -= _jumpOxygenConsumption;
    }

    /// <summary>空気砲での酸素消費</summary>
    public void AirCannonOxygenConsumption()
    {
        _slider.value -= _airCannonOxygenConsumption;
    }
}
