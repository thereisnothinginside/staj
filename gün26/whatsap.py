from selenium import webdriver
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
import time


driver = webdriver.Edge()


driver.get("https://web.whatsapp.com")


try:
    WebDriverWait(driver, 60).until(
        EC.invisibility_of_element_located((By.XPATH, '//canvas[@aria-label="Scan me!"]'))
    )
    print("QR kod tarandı, 10 saniye bekleniyor...")
    time.sleep(10)  # 10 saniye bekleme
except:
    print("QR kod taranamadı veya çıkıyorum.")


try:
    ara_button = WebDriverWait(driver, 30).until(
        EC.element_to_be_clickable((By.XPATH, '//button[@aria-label="Aratın veya yeni sohbet başlatın"]'))
    )
    ara_button.click()  # Arama butonuna tıklanıyor
    print("Arama kutusu bulundu ve tıklatıldı!")
    
    
    hedef = "Reşit abim"  
    arama_kutusu = WebDriverWait(driver, 30).until(
        EC.presence_of_element_located((By.XPATH, '//div[@role="textbox"][@contenteditable="true"]'))
    )
    arama_kutusu.send_keys(hedef)
    arama_kutusu.send_keys(Keys.ENTER)
    print(f"{hedef} arandım ve seçtim.")
    
except:
    print("Arama kutusu yok zaman doldu.")

# Mesaj kutusunun görünmesini bekle ve mesajı gönder
try:
    mesaj_kutusu = WebDriverWait(driver, 30).until(
        EC.presence_of_element_located((By.XPATH, '//div[@aria-label="Bir mesaj yazın" and @role="textbox"]'))
    )
    mesaj = "abim sen canını sıkma seviliyosun :)"
    mesaj_kutusu.send_keys(mesaj)
    mesaj_kutusu.send_keys(Keys.ENTER)
    
    a=("  **    **"  )
    b=(" *  *  *  *" )
    c=("*    **    *")
    d=("*          *")
    e=(" *        *" )
    f=("  *      *"  )
    g=("   *    *"   )
    x=("    *  *"    )
    c=("     **"     )
        
        
        
    mesaj_kutusu.send_keys(a)
    mesaj_kutusu.send_keys(Keys.ENTER)
    mesaj_kutusu.send_keys(b)
    mesaj_kutusu.send_keys(Keys.ENTER)
    mesaj_kutusu.send_keys(c)
    mesaj_kutusu.send_keys(Keys.ENTER)
    mesaj_kutusu.send_keys(d)
    mesaj_kutusu.send_keys(Keys.ENTER)
    mesaj_kutusu.send_keys(e)
    mesaj_kutusu.send_keys(Keys.ENTER)
    mesaj_kutusu.send_keys(f)
    mesaj_kutusu.send_keys(Keys.ENTER)
    mesaj_kutusu.send_keys(g)
    mesaj_kutusu.send_keys(Keys.ENTER)
    mesaj_kutusu.send_keys(x)
    mesaj_kutusu.send_keys(Keys.ENTER)
    mesaj_kutusu.send_keys(c)
    mesaj_kutusu.send_keys(Keys.ENTER)

    
    print("Mesaj gönderildi!")
except:
    print("Mesaj kutusu bulunamadı veya zaman aşımı oldu.")


time.sleep(5)
driver.quit()


