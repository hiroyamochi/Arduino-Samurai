using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      // スペースキーでゲーム開始
      if (Input.GetKeyDown(KeyCode.Space))
      {
        // 開始エフェクトを再生
        GameStart(); // ゲーム開始処理を呼び出す 
      }
        
    }

    void GameStart()
    {
      Debug.Log("ゲームを開始しました");
      
      StartCoroutine(Countdown());

      // 0~2のランダムな数値を取得
      Debug.Log("待ったよ");

      int number = Random.Range(0, 3);

      switch (number)
      {
          case 0:
              Debug.Log("グー");
              break;
          case 1:
              Debug.Log("チョキ");
              break;
          case 2:
              Debug.Log("パー");
              break;
      }
    }

    private IEnumerator Countdown()
    {

      float waitSecond = Random.Range(4, 10);

      Debug.Log(waitSecond);

      yield return new WaitForSeconds(waitSecond);

    }
}
