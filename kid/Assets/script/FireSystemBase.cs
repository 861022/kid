
using UnityEngine;

namespace JACK
{


    /// <summary>
    /// �o�g�t�ΰ�
    /// </summary>
    public class FireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("�l�u�w�s��")]
        private GameObject prefabBullet;
        [SerializeField, Header("�l�u�ͦ��I")]
        private Transform pointSpawn;

        //�ۦ��l�u
        //�ͦ��l�u
        protected void SpawanBullet()
        {
            //��Ҥ�(�ͦ�����A�y�СA����)�F
            // �ͦ� �l�u�w�s�� �y�лP���׸�ͦ��I�ۦP
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
        
        }
    }
}

