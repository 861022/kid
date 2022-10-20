
using UnityEngine;
namespace JACK
{
    /// <summary>
    /// 第一腳本
    /// </summary>
    public class FirstScript : MonoBehaviour



    {
        #region 單一註解

        // 單行註解
        // 單行註解
        /*多行註解
        * 
        * 
        * 
        * 
        */
        //A a
        #endregion
        #region 事件區域
        //喚醒事件
        private void Awake()
        {
            print("game over");
        }
        //開始事件
        private void Start()
        {
            print("<color=blue>開始事件</color>");



        }
        //更新
        private void Update()
        {
            print("<color=green>更新</color>");


        }
        #endregion

    }

}


