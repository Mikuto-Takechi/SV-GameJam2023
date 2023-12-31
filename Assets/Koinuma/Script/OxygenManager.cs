using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// プレイヤーの酸素量を管理する
/// </summary>
public class OxygenManager : MonoBehaviour
{
    [Tooltip("酸素ゲージのスライダー")]
    [SerializeField] Slider _slider;
    [Header("酸素量最大酸素量割合(%)")]
    [Tooltip("横移動で1秒間あたりの消費量")]
    [SerializeField] float _moveOxygenConsumption;
    [Tooltip("ジャンプでの消費量")]
    [SerializeField] float _jumpOxygenConsumption;
    [Tooltip("空気砲での酸素消費量")]
    [SerializeField] float _airCannonOxygenConsumption;
    [Tooltip("チェックポイントで回復する酸素量")]
    [SerializeField] float _CheckPointOxygen;

    /// <summary>移動での酸素消費</summary>
    public void MoveOxygenConsumption()
    {
        _slider.value -= _slider.maxValue * _moveOxygenConsumption / 100 * Time.deltaTime;
        OxygenLevelCheck();
    }

    /// <summary>ジャンプでの酸素消費</summary>
    public void JumpOxygenConsumption()
    {
        _slider.value -= _slider.maxValue * _jumpOxygenConsumption / 100;
        OxygenLevelCheck();
    }

    /// <summary>空気砲での酸素消費</summary>
    public void AirCannonOxygenConsumption()
    {
        _slider.value -= _slider.maxValue * _airCannonOxygenConsumption / 100;
        OxygenLevelCheck();
    }

    /// <summary>引数で酸素を減らせる</summary>
    public void OxygenConsumption(int consumption)
    {
        _slider.value -= _slider.maxValue * consumption / 100;
        OxygenLevelCheck();
    }

    /// <summary>チェックポイントでの酸素増加と値を返す</summary>
    public float GetAmountOfOxygenOnCheckPoint()
    {
        _slider.value += _slider.maxValue * _CheckPointOxygen / 100;
        return _slider.value;
    }

    /// <summary>酸素量チェック</summary>
    public void OxygenLevelCheck()
    {
        if (_slider.value <= 0)
        {
            GameManager.instance.GameOver();
        }
    }
}
