---
layout: post
title: "Arduino Sketch Debugging"
permalink: /arduino-sketch-debugging/
meta: javascript
published: false
---
I did it.  I took the plunge.  I finally purchased an [Arduino](http://amzn.to/1pAaAil).  What took me so long to rekindle my childhood curiosity and tinker (um, break things)?  I don't know.  Although recently I have been reading Charles Petzold's "[Code](http://amzn.to/1pA0HkH)" book and it definitely helps provide a jump start.  Many a time throughout the book I would pause and remember things - working with assembly, the Intel 8080 and 8088, the Motorola 6800, and little-endian vs. big-endian.  The good old days.  Closer to the metal.

What exactly am I trying to accomplish?  Admittedly it's another new toy for dad.  I enjoy this kind of stuff.  However I am hopeful I can use the Arduino with my two young daugthers.  Get them involved.  Get them interested.  Get them excited.  Show them a computer program that instructs a microcontroller to send and receive little tiny electrical impulses.  Demonstrate the humble beginnings of what is inside their phones and computers.  Plus who doesn't like colorful LED lights?  I ordered about 500 of them.

Working with an Arduino is not my first attempt at combining circuit building and computer programming.  Here is an old image from the 90s of a [Palm Pilot](https://en.wikipedia.org/wiki/PalmPilot) robot I built using a [kit](http://www.cs.cmu.edu/~pprk/) designed by the [Carnegie Mellon Robotics Insitute ](http://www.ri.cmu.edu/):

![Palm Pilot Robot](http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/palmpilot-robot.jpg)

The [Arduino Software IDE](https://www.arduino.cc/en/Main/Software) is easy to install and use.  One way (and the easiest) to program the Arduino is to use [Sketch](https://www.arduino.cc/en/Tutorial/Sketch).  It's a language that sits above C/C++.

[Arduino Unit Test framework](https://github.com/mmurdoch/arduinounit)

Additionally I picked up temperature, light, and carbon monoxide sensors as well as a tiny LCD screen and a bluetooth shield.  Shields are boards (or components) that literally plug into your Arduino to extend functionality.  To prevent against fraud (and illegal) parts utilize [Octopart](https://octopart.com/) to locate an Authorized Distributor.  Expect fake Arduino components from [AliExpress](http://www.aliexpress.com/).  If the price is too good to be true, it probably is.  And do not let the five star seller reviews fool you either.

I am running Ubuntu and came across this error while attempting to push sketch code to my [Arduino](http://amzn.to/1pAaAil):

`avrdude: ser_open(): can't open device "/dev/ttyACM0": No such file or directory ioctl("TIOCMGET"): Inappropriate ioctl for device`

![Arduino Inappropriate ioctl for device](http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/arduino-sketch-linux.png)

To help debug run this command:

`ls -lah /dev/ttyACM0`

Check out the permissions: `crw-rw----`

`sudo chmod 666 /dev/ttyACM0`

Change permissions to: `crw-rw-rw-`

<span class="fi-page-edit size-21"></span> <a href="{{ site.post_source_root }}2016-03-10-arduino-sketch-debugging.markdown" target="_blank">Contribute and Fork</a>

{% include disqus.html %}