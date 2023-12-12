const int LED = 13; //LEDは13番ピンのものを使用
int num;            //受信したデータを入れる変数
float data = 1;     //送信するデータを入れる変数（例として1を入れてある）

void setup() {
  Serial.begin(9600);   //シリアルポートを9600bpsで開く
  pinMode(LED, OUTPUT); //ピンを出力に設定
 }

void loop() {
  
  //-----受信部-----
  
  if (Serial.available()>0){  //データが到着していたら
    num = Serial.parseInt();  //読み取って変数numへ
  }
  
  if (num == 1){              //Unityから届いた値が1（オン）であれば
    //オンの時の処理
    digitalWrite(LED, HIGH);  //LEDをオン
  }else{
    //オフの時の処理
    digitalWrite(LED, LOW);   //LEDをオフ
  }
  
  //---受信部終わり---


    
  //-----送信部-----
    Serial.println(data);      //変数dataの値を送信
  //---送信部終わり---

  delay(10);  //バッファが詰まらないように0.01秒待機

}
