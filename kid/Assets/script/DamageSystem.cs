
using UnityEngine;

namespace JACK
{
    /// <summary>
    /// �˨t��
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("�z���w�s��")]
        private GameObject prefabExplosin;
        [SerializeField, Header("�I��|�z�����W��")]
        private string nameTarget;

        //�I���}�l����@��
        private void OnCollisionEnter2D(Collision2D collision)
        {
            print(collision.gameObject.name);
            //�p�G �I�쪫��W�� �]�tnameaTarget�N�z���çR��
            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosin, transform.position, transform.rotation);

                Destroy(gameObject);
            }

        }
        private void OnCollisionExit2D(Collision2D collision)
        {

        }
        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
    }
}

