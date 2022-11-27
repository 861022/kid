
using UnityEngine;

namespace JACK
{


    /// <summary>
    /// 發射系統基底
    /// </summary>
    public class FireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("子彈預製物")]
        private GameObject prefabBullet;
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpawn;
        [SerializeField, Header("發射音效")]
        private AudioClip soundFire;

        //自成子彈
        //生成子彈
        protected void SpawanBullet()
        {
            //實例化(生成物件，座標，角度)；
            // 生成 子彈預製物 座標與角度跟生成點相同
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);

            SoundManger.instance.Playsound(soundFire, new Vector2(0.7f, 1.2f));
        }
    }
}

