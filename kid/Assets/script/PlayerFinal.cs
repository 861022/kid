
using UnityEngine;

namespace JACK
{
    /// <summary>
    /// ���a�����޲z�F���`�L��
    /// </summary>

    public class PlayerFinal : MonoBehaviour
    {
        //�Q�R���ɷ|����@��
        private void OnDestroy()
        {
            //���`
            FinalManager.instance.GameOver("�D�ԥ���!");
        }

        //�I��|�Ŀ� Is Trigger ����ɷ|����@��
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //�L��
            FinalManager.instance.GameOver("�C���q�L");
        }
    }
}

