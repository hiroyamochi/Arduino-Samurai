using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Game : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
      // 刹那のスペースキーでゲーム開始
      if (Input.GetKeyDown(KeyCode.Space))
      {
        // 開始エフェクトを再生
        StartCoroutine(GameStart()); // ゲーム開始処理をコルーチンとして呼び出す 
      }
        
    }

    private IEnumerator GameStart()
    {
      Debug.Log("ゲームを開始したよ");
      
      yield return StartCoroutine(Countdown());

      // 0~2のランダムな数値を取得
      Debug.Log("待ったよ");
      int number = Random.Range(0, 3);

      switch (number)
      {
          case 0:
              Debug.Log("いまから光るよ!!");
              break;
          case 1:
              Debug.Log("いまから鳴るよ!!");
              break;
          case 2:
              Debug.Log("いまから震えるよ!!");
              break;
      }

    }

    // 刹那のカウントダウン処理
    private IEnumerator Countdown()
    {

      float waitSecond = Random.Range(3, 8);

      Debug.Log($"待機時間: {waitSecond}秒");

      yield return new WaitForSeconds(waitSecond);

    }
}
