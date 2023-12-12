const int LED = 13; //LEDは13番ピンのものを使用
int recieved;            //Unityから送られてくる値を格納する変数

void setup() {
  Serial.begin(9600);   //シリアルポートを9600bpsで開く
  pinMode(LED, OUTPUT); //ピンを出力に設定
 }

void loop() {
  
  if (Serial.available()>0){  //データが到着していたら
    recieved = Serial.parseInt();  //読み取って変数recievedへ
  }
  
  switch(recieved){
    case 0: // LED
      digitalWrite(LED, HIGH);
      break;
    case 1: // モーター
      digitalWrite(LED, LOW);
      break;
    case 2: // 音
      digitalWrite(LED, HIGH);
      break;
  }

  delay(10);

}
