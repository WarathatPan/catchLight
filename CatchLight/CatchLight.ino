void setup() { 
  // put your setup code here, to run once:
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  /*int value  = analogRead(A0);//รับค่าจากพอตA0
  int value2 = analogRead(A1);//รับค่าจากพอตA1
  int value3 = analogRead(A2);//รับค่าจากพอตA2
  int value4 = analogRead(A3);//รับค่าจากพอตA3
  int value5 = analogRead(A4);//รับค่าจากพอตA4
  int value6 = analogRead(A5);//รับค่าจากพอตA5
  String s = String(value) + "," + String(value2) + "," + String(value3) + "," + String(value4) + "," + String(value5) + "," + String(value6);//กำหนดตัวแปร s มาเก็บค่าทุกพอต
  Serial.println(s);*/ 
  int value  = digitalRead(13);//รับค่าจากพอตD13
  int value2  = digitalRead(12);//รับค่าจากพอตD12
  int value3  = digitalRead(11);//รับค่าจากพอตD11
  int value4 = digitalRead(10);//รับค่าจากพอตD10
  int value5 = digitalRead(9);//รับค่าจากพอตD9
  int value6 = digitalRead(8);//รับค่าจากพอตD8
  int value7 = digitalRead(7);//รับค่าจากพอตD7
  int value8 = digitalRead(6);//รับค่าจากพอตD6
  int value9 = digitalRead(5);//รับค่าจากพอตD5
  String s = String(value) + "," + String(value2) + "," + String(value3) + "," + String(value4) + "," + String(value5) + "," + String(value6) + "," + String(value7) + "," + String(value8) + "," + String(value9);//กำหนดตัวแปร s มาเก็บค่าทุกพอต
  Serial.println(s);
  delay(20);
}
