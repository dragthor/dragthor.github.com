---
layout: post
title: "Engage: Arduino Sketch Debugging for Dad (and the Kids)"
permalink: /arduino-sketch-debugging-for-dad-and-kids/
meta: arduino linux ubuntu
image: http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/arduino.jpg
description: "I did it.  I took the plunge.  I finally purchased an Arduino.  What took me so long to rekindle my childhood curiosity and tinker (um, break things)?  I don't know."
---
I did it.  I took the plunge.  I finally purchased an [Arduino](http://amzn.to/1ZlBPsE).  What took me so long to rekindle my childhood curiosity and tinker (um, break things)?  I don't know.  Although recently I have been reading Charles Petzold's [Code](http://amzn.to/1VMiYc9) book and it definitely helps provide a jump start.  Many a time throughout the book I would pause and remember things - working with assembly, the Intel 8080 and 8088, the Motorola 6800, and little-endian vs. big-endian.  The good old days.  I was there.  Closer to the metal.

![alt text]({{ page.image }} "Arduino")

What exactly am I trying to accomplish?  Admittedly it's another new toy for dad.  I enjoy this kind of stuff.  However, I am hopeful I can use the Arduino with my two young daughters.  Get them **involved**.  Get them interested.  Get them **excited**.  Show them a computer program that instructs a microcontroller to send and receive little tiny electrical impulses.  Demonstrate the humble beginnings of what is inside their smart phones and computers.  Plus who doesn't like colorful LED lights?  I ordered about 500 of them.

Working with an Arduino is not my first attempt at combining circuit building and computer programming.  Here is an old image from the 90s of a [Palm Pilot](https://en.wikipedia.org/wiki/PalmPilot) robot I built using a [kit](http://www.cs.cmu.edu/~pprk/) designed by the [Carnegie Mellon Robotics Insitute](http://www.ri.cmu.edu/):

![Palm Pilot Robot](http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/palmpilot-robot.jpg)

The [Arduino Software IDE](https://www.arduino.cc/en/Main/Software) is easy to install and use.  One way (and the easiest) to program the Arduino is to use [Sketch](https://www.arduino.cc/en/Tutorial/Sketch).  It's a language that sits above [C/C++](https://en.wikipedia.org/wiki/C_%28programming_language%29).  Software debugging and testing is accomplished simply by using `Serial.println(someSensorValue);`.  Some sensors and components can be tricky.  There might be other ways out there too.  Let me know!  Here is an example:

{% highlight c %}
void setup() { Serial.begin(9600); }

void loop() { Serial.println(someSensorValue); };
{% endhighlight %}

{% include amazon-tradeinelectronics.html %}

An [Arduino Unit Test framework](https://github.com/mmurdoch/arduinounit) exists which can also help debug and design software logic.  Debugging hardware usually involves reading datasheets, voltage meters, triple checking the wiring, and at times contacting the component manufacturer.

Additionally, I picked up temperature, light, and carbon monoxide sensors as well as a tiny LCD screen and a bluetooth shield.  I plan to send commands to Arduino via bluetooth from my Android device.  Shields are boards (or components) that literally plug into your Arduino to extend functionality.  To prevent against fraudulent (and illegal) parts (and personal frustration and disappointment) utilize [Octopart](https://octopart.com/) to locate an Authorized Distributor.  Expect fake and high defect rate Arduino components from [AliExpress](http://www.aliexpress.com/).  If the price is too good to be true, it probably is.  And do not let the five-star seller ratings and reviews fool you either!

Finally, I am running Ubuntu (you can also use Mac and Windows) and came across this error while attempting to push sketch code to my [Arduino](http://amzn.to/1pAaAil):

`avrdude: ser_open(): can't open device "/dev/ttyACM0": No such file or directory ioctl("TIOCMGET"): Inappropriate ioctl for device`

![Arduino Inappropriate ioctl for device](http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/arduino-sketch-linux.png)

To help debug run this command:

`ls -lah /dev/ttyACM0`

Check out the permissions.  You should see something similar to: `crw-rw----`

The problem is that the "other/all" permission group needs read and write access.  It needs to be changed to: `crw-rw-rw-`

One way to change this is to run this command:

`sudo chmod 666 /dev/ttyACM0`

Are you ready to take the [Arduino](http://amzn.to/1ZlBPsE) plunge?  It's a great way to share your excitement, personality, and job (if you are a computer programmer) with your kids.  **Engage and interact**.  Build a robot that operates outside.  Watch Star Wars and Star Trek with them later.

{% include disqus.html %}
