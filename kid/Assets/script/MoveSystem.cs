
using UnityEngine;

namespace JACK
{
    public class MoveSystem : MonoBehaviour
    {
      
        [SerializeField, Header("移動速度"), Range(-10, 0)]
        private float speed = -3.5f;

        private void Update()
        {
            //transform 指定物件的 Transsform 元件
            //Transslate(x,y,z)位移
            transform.Translate(speed*Time.deltaTime, 0, 0);

        }




    }






}

