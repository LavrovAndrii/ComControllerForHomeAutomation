int pin1 = 2;
int pin2 = 3;
int pin3 = 4;
int pin4 = 5;
int pin5 = 6;
int pin6 = 7;
int pin7 = 8;
int pin8 = 9;

void setup() 
{
  Serial.begin(9600);
  pinMode(pin1, OUTPUT);
  pinMode(pin2, OUTPUT);
  pinMode(pin3, OUTPUT);
  pinMode(pin4, OUTPUT);
  pinMode(pin5, OUTPUT);
  pinMode(pin6, OUTPUT);
  pinMode(pin7, OUTPUT);
  pinMode(pin8, OUTPUT);

  digitalWrite(pin1,HIGH);
  digitalWrite(pin2,HIGH);
  digitalWrite(pin3,HIGH);
  digitalWrite(pin4,HIGH);
  digitalWrite(pin5,HIGH);
  digitalWrite(pin6,HIGH);
  digitalWrite(pin7,HIGH);
  digitalWrite(pin8,HIGH);
  
}

void loop() 
{ 
  
  char data = Serial.read();
  
  switch (data)
  {
    case 'Q':digitalWrite(pin1,LOW); break;
    case 'W':digitalWrite(pin2,LOW); break;
    case 'E':digitalWrite(pin3,LOW); break;
    case 'R':digitalWrite(pin4,LOW); break;
    case 'T':digitalWrite(pin5,LOW); break;
    case 'Y':digitalWrite(pin6,LOW); break;
    case 'U':digitalWrite(pin7,LOW); break;
    case 'I':digitalWrite(pin8,LOW); break;
    
    case 'A':digitalWrite(pin1,HIGH); break;
    case 'S':digitalWrite(pin2,HIGH); break;
    case 'D':digitalWrite(pin3,HIGH); break;
    case 'F':digitalWrite(pin4,HIGH); break;
    case 'G':digitalWrite(pin5,HIGH); break;
    case 'H':digitalWrite(pin6,HIGH); break;
    case 'J':digitalWrite(pin7,HIGH); break;
    case 'K':digitalWrite(pin8,HIGH); break;      
  }
}
