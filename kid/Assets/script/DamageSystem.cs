
using UnityEngine;

namespace JACK
{
    /// <summary>
    /// 傷系統
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("爆炸預製物")]
        private GameObject prefabExplosin;
        [SerializeField, Header("碰到會爆炸的名稱")]
        private string nameTarget;
        [Header("受傷與爆炸音效")]
        [SerializeField]
        private AudioClip soundHit;
        [SerializeField]
        private AudioClip soundExplosion;


        //碰撞開始執行一次
        private void OnCollisionEnter2D(Collision2D collision)
        {
            print(collision.gameObject.name);
            //如果 碰到物件名稱 包含nameaTarget就爆炸並刪除
            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosin, transform.position, transform.rotation);

                SoundManger.instance.Playsound(soundHit, new Vector2(0.7f, 0.9f));
                SoundManger.instance.Playsound(soundExplosion, new Vector2(1.2f, 1.5f));

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

