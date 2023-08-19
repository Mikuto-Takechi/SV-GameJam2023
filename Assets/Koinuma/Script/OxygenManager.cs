using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ƒvƒŒƒCƒ„[‚Ì_‘f—Ê‚ğŠÇ—‚·‚é
/// </summary>
public class OxygenManager : MonoBehaviour
{
    [Tooltip("_‘fƒQ[ƒW‚ÌƒXƒ‰ƒCƒ_[")]
    [SerializeField] Slider _slider;
    [Header("_‘fÁ”ï—Ê")]
    [Tooltip("‰¡ˆÚ“®‚Å1•bŠÔ‚ ‚½‚è‚ÌÁ”ï—Ê")]
    [SerializeField] float _moveOxygenConsumption;
    [Tooltip("ƒWƒƒƒ“ƒv‚Å‚ÌÁ”ï—Ê")]
    [SerializeField] float _jumpOxygenConsumption;
    [Tooltip("‹ó‹C–C‚Å‚Ì_‘fÁ”ï—Ê")]
    [SerializeField] float _airCannonOxygenConsumption;

    /// <summary>ˆÚ“®‚Å‚Ì_‘fÁ”ï</summary>
    public void MoveOxygenConsumption()
    {
        _slider.value -= _moveOxygenConsumption * Time.deltaTime;
    }

    /// <summary>ƒWƒƒƒ“ƒv‚Å‚Ì_‘fÁ”ï</summary>
    public void JumpOxygenConsumption()
    {
        _slider.value -= _jumpOxygenConsumption;
    }

    /// <summary>‹ó‹C–C‚Å‚Ì_‘fÁ”ï</summary>
    public void AirCannonOxygenConsumption()
    {
        _slider.value -= _airCannonOxygenConsumption;
    }
}
