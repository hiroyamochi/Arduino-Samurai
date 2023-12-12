using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Game : MonoBehaviour
{
  public GameObject LED;
  public GameObject Sound;
  public GameObject Haptic;
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
        ChangeColor(LED, Color.red);
        break;
      case 1:
        Debug.Log("いまから鳴るよ!!");
        ChangeColor(Sound, Color.blue);
        break;
      case 2:
        Debug.Log("いまから震えるよ!!");
        ChangeColor(Haptic, Color.green);
        break;
    }

    int count = Battle();

    Debug.Log(count);

  }

  // 刹那のカウントダウン処理
  private IEnumerator Countdown()
  {

    float waitSecond = Random.Range(3, 8);

    Debug.Log($"待機時間: {waitSecond}秒");

    yield return new WaitForSeconds(waitSecond);

  }

  private void ChangeColor(GameObject targetObject, Color newColor)
  {
    Renderer objectRenderer = targetObject.GetComponent<Renderer>();

    if (objectRenderer != null)
    {
        objectRenderer.material.color = newColor;
    }
  }

  private int Battle()
  {
    int count = 0;

    while (true)
    {
      if (Input.GetKeyDown(KeyCode.UpArrow))
      {
        Debug.Log("上矢印キーが押されたよ");
        return count;
      }
      else
      {
        count++;
        continue;
      }
    }
  }
}
