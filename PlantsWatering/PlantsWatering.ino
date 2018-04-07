/*
 Name:		PlantsWatering.ino
 Created:	4/5/2018 8:09:21 PM
 Author:	nguye
*/

// the setup function runs once when you press reset or power the board
#include <Adafruit_BMP085.h>
#include <Adafruit_Sensor.h>
#include "DHT_U.h"
#include "DHT.h"

const int DHTPIN = 2;
const int DHTTYPE = DHT11;
const int MOTORA = 3;
const int MOTORB = 4;

float humidity;
float temperature;
float light;
float earthHumidity;

byte readValue = '0';

DHT dht(DHTPIN, DHTTYPE);

Adafruit_BMP085 bmp;

bool bmpIsEnable = true;

void setup() {
	Serial.begin(9600);
	pinMode(A0, INPUT);
	pinMode(A1, INPUT);
	pinMode(MOTORA, OUTPUT);
	pinMode(MOTORB, OUTPUT);
	dht.begin();
	if (!bmp.begin()) {
		bmpIsEnable = false;
	}
}

// the loop function runs over and over again until power down or reset
void loop() {

	humidity = dht.readHumidity();
	temperature = dht.readTemperature();
	light = analogRead(A0);
	earthHumidity = analogRead(A1);

	if (Serial.available()>0) {
		readValue = Serial.read();

		Serial.flush();
	}


	if (readValue == '0') {
		digitalWrite(MOTORA, LOW);
		digitalWrite(MOTORB, LOW);
	}
	else if (readValue == '1') {
		digitalWrite(MOTORA, LOW);
		digitalWrite(MOTORB, HIGH);
		readValue = '0';
	}

	Serial.print("T:");
	Serial.println(temperature);
	Serial.print("H:");
	Serial.println(humidity);
	Serial.print("L:");
	Serial.println(1024 - light);
	Serial.print("E:");
	Serial.println(1024-earthHumidity);
	
	if (bmpIsEnable) {
		Serial.print("P:");
		Serial.println(bmp.readPressure());
		Serial.print("A:");
		Serial.println(bmp.readAltitude());
		Serial.print("TP:");
		Serial.println(bmp.readTemperature());
	}
	delay(1000);
}
