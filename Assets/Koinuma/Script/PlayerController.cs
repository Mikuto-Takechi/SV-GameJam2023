using UnityEngine;

/// <summary>
/// プレイヤーを動かすコンポーネント
/// </summary>
[RequireComponent (typeof(Collider))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [Header("移動のスピード")]
    [SerializeField] float _moveSpeed;
    [SerializeField] float _jumpPower;
    OxygenManager _oxygenManager;
    Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _oxygenManager = GetComponent<OxygenManager>();
    }

    private void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        if (h != 0)
        {
            _oxygenManager.MoveOxygenConsumption(); // 移動での酸素減少
        }
        if (IsGround()) // 接地中処理
        {
            // 横方向の移動
            _rb.AddForce(Vector3.right * h * _moveSpeed * Time.deltaTime * 100, ForceMode.Force);

            // ジャンプ処理
            if (Input.GetButtonDown("Jump"))
            {
                _rb.AddForce(Vector3.up * _jumpPower, ForceMode.Impulse);
                _oxygenManager.JumpOxygenConsumption(); // ジャンプでの酸素減少
            }
        }
        else // 空中処理
        {
            _rb.AddForce(Vector3.right * h * _moveSpeed * Time.deltaTime * 50, ForceMode.Force);
        }
    }

    bool IsGround()
    {
        Vector3 start = gameObject.transform.position;
        Vector3 end = gameObject.transform.position + Vector3.down * 1.1f;
        Debug.DrawLine(start, end);
        if (Physics.Linecast(start, end))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
