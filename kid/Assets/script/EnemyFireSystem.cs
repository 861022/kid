
using UnityEngine;
namespace JACK
{
    /// <summary>
    /// 敵人發射器
    /// </summary>
    public class EnemyFireSystem : FireSystemBase
    {
        [SerializeField, Header("生成子彈間隔"), Range(0, 3)]
        private float interval = 1.5f;

        private void Awake()
        {
            //呼叫方法
            //SpawanBullet();
 
        }

        private void OnBecameVisible()
        {
            //延遲重複呼叫("方法名稱"，延遲時間，重複頻率)
            InvokeRepeating("SpawanBullet", 0, interval);
        }

        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }
}

