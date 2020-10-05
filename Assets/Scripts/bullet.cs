using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class bullet : MonoBehaviour
{
    float m_Speed = 25.0f;
    Rigidbody m_Bullet;
    public Vector3 direction;
   // public Transformer Bullet;

    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(-1f, 0f, 0f);
        m_Bullet = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Bullet(BindingDirection * Time.deltaTime);
        m_Bullet.velocity = direction * m_Speed;
    }
}
