using UnityEngine;

/// <summary>
/// �v���C���[�𓮂����R���|�[�l���g
/// </summary>
[RequireComponent (typeof(Collider))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [Header("�ړ��̃X�s�[�h")]
    [SerializeField] float _moveSpeed;
    [SerializeField] float _jumpPower;
    [Tooltip("�󒆈ړ��̑��x����")]
    [SerializeField, Range(0, 1)] float _airMoveRate;
    [Tooltip("������ő�p�x(�x)")]
    [SerializeField] int _walkingAngle;
    [Tooltip("�ڒn����̒���")]
    [SerializeField] float _isGroundLength;
    [Space()]
    [Tooltip("GameOver�ɂȂ鍂��(Y)")]
    [SerializeField] float _gameOverHeight;

    OxygenManager _oxygenManager;
    Rigidbody _rb;
    Vector3 _planeNormalVector; // �G��Ă�n�ʂ̖@���x�N�g��

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
            float scaleX = transform.localScale.x;
            if (Mathf.Sign(scaleX) != h)
            {
                scaleX *= -1;
                transform.localScale = new Vector3(scaleX, transform.localScale.y, transform.localScale.z);
            }
            _oxygenManager.MoveOxygenConsumption(); // �ړ��ł̎_�f����
        }
        if (IsGround()) // �ڒn������
        {
            // �������̈ړ�
            _rb.AddForce(Vector3.ProjectOnPlane(Vector3.right, _planeNormalVector) * h * _moveSpeed * Time.deltaTime * 100, ForceMode.Force);

            // �W�����v����
            if (Input.GetButtonDown("Jump"))
            {
                _rb.AddForce(Vector3.up * _jumpPower, ForceMode.Impulse);
                _oxygenManager.JumpOxygenConsumption(); // �W�����v�ł̎_�f����
            }
        }
        else // �󒆏���
        {
            _rb.AddForce(Vector3.right * h * _moveSpeed * Time.deltaTime * 100 * _airMoveRate, ForceMode.Force);
        }

        if (transform.position.y < _gameOverHeight)
        {
            GameManager.instance.GameOver();
        }
    }

    /// <summary>�ڒn����</summary>
    bool IsGround()
    {
        Vector3 start = gameObject.transform.position;
        Vector3 end = start + Vector3.down * _isGroundLength;
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

    private void OnCollisionStay(Collision collision)
    {
        float angle = Vector3.Angle(Vector3.up, collision.contacts[0].normal);
        if (angle < _walkingAngle)
        {
            _planeNormalVector = collision.contacts[0].normal;
        }
    }
}
