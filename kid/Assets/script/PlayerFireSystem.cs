
using UnityEngine;
namespace JACK
{
    /// <summary>
    /// ���a�o�g��
    /// </summary>
public class PlayerFireSystem : FireSystemBase

{
        //�������a��J�欰:��L�B�ƹ��BĲ���P�n��
        private void Update()
        {
            //�p�G ���a���U �ť��� �N�ͦ��l�u
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawanBullet();
            }
        }

    }
}

