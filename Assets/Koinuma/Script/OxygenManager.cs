using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ƒvƒŒƒCƒ„[‚Ì_‘f—Ê‚ğŠÇ—‚·‚é
/// </summary>
public class OxygenManager : MonoBehaviour
{
    [Tooltip("_‘fƒQ[ƒW‚ÌƒXƒ‰ƒCƒ_[")]
    [SerializeField] Slider _slider;
    [Header("_‘fÁ”ï—ÊÅ‘å_‘f—ÊŠ„‡(%)")]
    [Tooltip("‰¡ˆÚ“®‚Å1•bŠÔ‚ ‚½‚è‚ÌÁ”ï—Ê")]
    [SerializeField] float _moveOxygenConsumption;
    [Tooltip("ƒWƒƒƒ“ƒv‚Å‚ÌÁ”ï—Ê")]
    [SerializeField] float _jumpOxygenConsumption;
    [Tooltip("‹ó‹C–C‚Å‚Ì_‘fÁ”ï—Ê")]
    [SerializeField] float _airCannonOxygenConsumption;

    /// <summary>ˆÚ“®‚Å‚Ì_‘fÁ”ï</summary>
    public void MoveOxygenConsumption()
    {
        _slider.value -= _slider.maxValue * _moveOxygenConsumption / 100 * Time.deltaTime;
    }

    /// <summary>ƒWƒƒƒ“ƒv‚Å‚Ì_‘fÁ”ï</summary>
    public void JumpOxygenConsumption()
    {
        _slider.value -= _slider.maxValue * _jumpOxygenConsumption / 100;
    }

    /// <summary>‹ó‹C–C‚Å‚Ì_‘fÁ”ï</summary>
    public void AirCannonOxygenConsumption()
    {
        _slider.value -= _slider.maxValue * _airCannonOxygenConsumption / 100;
    }

    public void OxygenConsumption(int consumption)
    {
        _slider.value -= _slider.maxValue * consumption / 100;
    }
}
