#include <WiFi.h>
#include <WebServer.h>

const char* ssid = "";//wifi adınız
const char* password = "";//wifi şifreniz

IPAddress local_IP(192.168.2.1);
IPAddress gateway(192.168.2.1);
IPAddress subnet(255.255.255.0);

WebServer server(80);

void handleGet() {
  server.send(200, "text/plain", "GET isteği başarıyla alındı!");
}

void handlePost() {
  String message = "POST isteği alındı: ";
  message += server.arg(0);
  server.send(200, "text/plain", message);
}

void setup() {
  Serial.begin(115200);

  if (!WiFi.config(local_IP, gateway, subnet)) {
    Serial.println("IP yapılandırma başarısız!");
  }

  WiFi.begin(ssid, password);

  while (WiFi.status() != WL_CONNECTED) {
    delay(1000);
    Serial.println("WiFi'ye bağlanıyor...");
  }

  Serial.println("WiFi'ye bağlanıldı!");
  Serial.print("IP adresi: ");
  Serial.println(WiFi.localIP());

  server.on("/get", HTTP_GET, handleGet);
  server.on("/post", HTTP_POST, handlePost);

  server.begin();
  Serial.println("Web sunucusu başlatıldı.");
}

void loop() {
  server.handleClient();
}
//@Made By Mehmet Emre Çetinkaya
