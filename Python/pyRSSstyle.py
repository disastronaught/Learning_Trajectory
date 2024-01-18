//there'll be several programs here, seperated out and explained by comments.

#so I assembled several cameras on Pico and Zero W boards for Infrared use. One was ported to a watch screen and the other to a 2.8"TFT
#I wanted to set one of them to activate at night to run as a night sigh security camera. I'll run it a few times in VScode and see what needs to be altered
import os
from datetime import datetime
now = datetime.now

if now >= 19:00
  print("Recording Started!")
    and do | send True to SDA1
  elif now < 19:00 
    print("Daytime sec cam off")
  end
#I'll need to reread my pinout for the zero motherboard and see which GPIO needs a positive value


