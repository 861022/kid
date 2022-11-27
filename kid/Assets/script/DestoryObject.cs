
using UnityEngine;

namespace JACK
{
    /// <summary>
    /// �R������
    /// </summary>
    public class DestoryObject : MonoBehaviour
    {
        [SerializeField, Header("�R���ɶ�"), Range(0, 3)]
        private float destoryTime = 0.5f;

        private void Awake()
        {
            //gameObject,���}�����C���ت���
            //�R��(����,�R���ɶ�)
            Destroy(gameObject, destoryTime);
        }

        //�i���ƥ�:���V����(Randerer)�X�{�bScence��Game�ɰ���@��
        private void OnBecameVisible()
        {
            
        }
        //���i���ƥ�:���V����(Randerer)�����bScence�ήɰ���@��
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
        
        
        

    }
}

