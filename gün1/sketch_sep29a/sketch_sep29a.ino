// Pin tanımlamaları
const int buttonPin1 = 2;  
const int buttonPin2 = 3;  
const int ledPin1 = 8;     
const int ledPin2 = 9;     

void setup() {
  // Düğme pinlerini giriş olarak ayarla
  pinMode(buttonPin1, INPUT);
  pinMode(buttonPin2, INPUT);
  
  // LED pinlerini çıkış olarak ayarla
  pinMode(ledPin1, OUTPUT);
  pinMode(ledPin2, OUTPUT);
}

void loop() {
  // 1. düğme durumunu oku
  int buttonState1 = digitalRead(buttonPin1);
  
  // 2. düğme durumunu oku
  int buttonState2 = digitalRead(buttonPin2);
  
  // Eğer 1. düğmeye basıldıysa, 1. LED'i yak
  if (buttonState1 == HIGH) {
    digitalWrite(ledPin1, HIGH);
  } else {
    digitalWrite(ledPin1, LOW);
  }
  if (buttonState2 == HIGH) {
    digitalWrite(ledPin2, HIGH);
  } else {
    digitalWrite(ledPin2, LOW);
  }
}
