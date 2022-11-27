
using UnityEngine;
namespace JACK
{
    /// <summary>
    /// �ĤH�o�g��
    /// </summary>
    public class EnemyFireSystem : FireSystemBase
    {
        [SerializeField, Header("�ͦ��l�u���j"), Range(0, 3)]
        private float interval = 1.5f;

        private void Awake()
        {
            //�I�s��k
            //SpawanBullet();
 
        }

        private void OnBecameVisible()
        {
            //���𭫽ƩI�s("��k�W��"�A����ɶ��A�����W�v)
            InvokeRepeating("SpawanBullet", 0, interval);
        }

        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }
}

