---
layout: post
title: "Arduino Sketch Linux Debugging"
permalink: /arduino-linux-debugging/
meta: javascript
published: false
---
avrdude: ser_open(): can't open device "/dev/ttyACM0": No such file or directory
ioctl("TIOCMGET"): Inappropriate ioctl for device

ls -lah /dev/ttyACM0

Check out the permissions: crw-rw----

sudo chmod 666 /dev/ttyACM0

Change permissions to: crw-rw-rw-

http://metroize.com/images/arduino-sketch-linux.png

<span class="fi-page-edit size-21"></span> <a href="{{ site.post_source_root }}2016-03-05-arduino-linux-debugging.markdown" target="_blank">Contribute and Fork</a>

{% include disqus.html %}