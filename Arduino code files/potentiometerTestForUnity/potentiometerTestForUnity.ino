#define RIGHT 8
#define LEFT 9
#define FRONT 7
#define BACK 6
#define RESTART 11
#define BUZZER 3
char test;
#define LED 13
void setup()
{
  Serial.begin(9600);
  pinMode(A0, INPUT);
  pinMode(RIGHT, INPUT_PULLUP);
  pinMode(LEFT, INPUT_PULLUP);
  pinMode(FRONT, INPUT_PULLUP);
  pinMode(BACK, INPUT_PULLUP);
  pinMode(RESTART, INPUT_PULLUP);
  pinMode(BUZZER, OUTPUT);
  pinMode(LED, OUTPUT);
}

void loop()
{
  char data = Serial.read();
  test = ' ';
  if (digitalRead(RESTART) == LOW)
  {
    test = 'X';
    delay(20);
  }
  if (digitalRead(RIGHT) == LOW)
  {
    test = 'R';
    delay(20);
  }
  if (digitalRead(LEFT) == LOW)
  {
    test = 'L';
    delay(20);
  }
  if (digitalRead(FRONT) == LOW)
  {
    test = 'F';
    delay(20);
  }
  if (digitalRead(BACK) == LOW)
  {
    test = 'B';
    delay(20);
  }

  if (data == 't')
  {
    digitalWrite(LED, HIGH);
    tone(BUZZER, 1000);
  }

  if (data == 'o')
  {
    digitalWrite(LED, LOW);
    noTone(BUZZER);
  }
  
  float volt = analogRead(A0);
  volt = map(volt, 0, 1023, 0, 100);
  delay(20);
  Serial.print(volt);
  Serial.print(",");
  Serial.println(test);
}
