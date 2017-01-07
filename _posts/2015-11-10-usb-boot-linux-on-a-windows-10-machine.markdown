---
layout: post
title: "USB Boot Linux on a Windows 10 Machine"
permalink: /usb-boot-linux-on-a-windows-10-machine/
meta: linux
image: http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/ubuntu.jpg
description: "Disable Secure Boot, then change from UEFI Boot to CSM Boot to boot Linux on a Windows 10 machine."
---
Things are different compared to five years ago in the hardware world.  Booting a "live" Linux USB on a machine primarily running Windows 10 is little more involved.  I am choosing [Ubuntu](http://www.ubuntu.com) - although [Mint](http://linuxmint.com) is another good choice (and pretty hot right now).

![alt text]({{ page.image }} "Ubuntu")

The process?  Check it out -

Control Panel > Power Options > Choose what the power button does >  Change settings that are unavailable > disable turn on fast startup (see below)

![disable fast startup](http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/usb-boot.PNG)

Reboot and go into your BIOS.  My system (a Toshiba laptop) involves holding down F2.  Visit your manufacturer's website to learn how to boot to your BIOS.

Double check your Boot options and ordering to boot from USB.  This should be no different than five to ten years ago.

Once in BIOS go to the security tab and disable "Secure Boot".  Then go to the Advanced tab... then System Configuration to locate "Boot Mode".  Change it from UEFI Boot to CSM Boot.  What's difference?  Read more [here](http://superuser.com/questions/496026/what-is-the-difference-in-boot-with-bios-and-boot-with-uefi).

Save and restart your computer (with the USB device plugged in).

Your system should now boot from USB.


{% include disqus.html %}
