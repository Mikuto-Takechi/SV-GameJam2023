using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerAnim : MonoBehaviour
{
    Rigidbody m_rb = default;
    Animator m_anim = default;
    //bool m_isGrounded = false;

    void Start()
    {
        m_rb = GetComponent<Rigidbody>();
        m_anim = GetComponent<Animator>();
    }
    private void LateUpdate()
    {
        // �A�j���[�V�����𐧌䂷��
        if (m_anim)
        {
            //X������velocity�̐�Βl
            m_anim.SetFloat("SpeedX", Mathf.Abs(m_rb.velocity.x));
            //Y������velocity
            m_anim.SetFloat("SpeedY", m_rb.velocity.y);
            //m_anim.SetBool("IsGrounded", m_isGrounded);
        }
    }
}
