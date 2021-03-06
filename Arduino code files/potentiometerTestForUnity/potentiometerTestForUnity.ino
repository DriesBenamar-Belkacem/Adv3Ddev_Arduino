#define RIGHT 8
#define LEFT 9
#define FRONT 7
#define BACK 6
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
  pinMode(LED, OUTPUT);
}

void loop()
{
  char data = Serial.read();
  test = ' ';
  if (digitalRead(RIGHT) == LOW)
  {
    test = 'R';
    delay(50); //debounce
  }
  if (digitalRead(LEFT) == LOW)
  {
    test = 'L';
    delay(50); //debounce
  }
  if (digitalRead(FRONT) == LOW)
  {
    test = 'F';
    delay(50); //debounce
  }
  if (digitalRead(BACK) == LOW)
  {
    test = 'B';
    delay(50); //debounce
  }

  if (data == 't')
  {
    digitalWrite(LED, HIGH);
  }


  if (data == 'o')
  {
    digitalWrite(LED, LOW);
  }


  if (data == 'b')
  {
    digitalWrite(LED, HIGH);
    delay(250);
    digitalWrite(LED, LOW);
    delay(250);
    digitalWrite(LED, HIGH);
    delay(250);
    digitalWrite(LED, LOW);
    delay(250);
    digitalWrite(LED, HIGH);
    delay(250);
    digitalWrite(LED, LOW);
    delay(250);
    digitalWrite(LED, HIGH);
    delay(250);
    digitalWrite(LED, LOW);
    delay(250);
    digitalWrite(LED, HIGH);
    delay(250);
    digitalWrite(LED, LOW);
    delay(250);
    digitalWrite(LED, HIGH);
    delay(250);
    digitalWrite(LED, LOW);
    delay(250);

  }
  float volt = analogRead(A0);
  volt = map(volt, 0, 1023, 0, 100);
  Serial.print(volt);
  Serial.print(",");
  Serial.println(test);
}
