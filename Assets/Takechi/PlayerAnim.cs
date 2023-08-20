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
        // アニメーションを制御する
        if (m_anim)
        {
            //X方向のvelocityの絶対値
            m_anim.SetFloat("SpeedX", Mathf.Abs(m_rb.velocity.x));
            //Y方向のvelocity
            m_anim.SetFloat("SpeedY", m_rb.velocity.y);
            //m_anim.SetBool("IsGrounded", m_isGrounded);
        }
    }
}
