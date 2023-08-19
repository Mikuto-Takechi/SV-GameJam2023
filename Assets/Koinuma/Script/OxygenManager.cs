using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// プレイヤーの酸素量を管理する
/// </summary>
public class OxygenManager : MonoBehaviour
{
    [Tooltip("酸素ゲージのスライダー")]
    [SerializeField] Slider _slider;
    [Header("入力による酸素消費量")]
    [Tooltip("横移動で1秒間あたりの消費量")]
    [SerializeField] float _moveOxygenConsumption;
    [Tooltip("ジャンプでの消費量")]
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
