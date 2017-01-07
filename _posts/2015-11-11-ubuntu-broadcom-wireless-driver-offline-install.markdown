---
layout: post
title: "Ubuntu Broadcom Wireless Driver Offline Install"
permalink: /ubuntu-broadcom-wireless-driver-offline-install/
meta: linux ubuntu
image: http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/wireless-coffee.jpg
description: "Have your offline Ubuntu installation recognize your Broadcom wireless networking card."
---
You installed [Ubuntu](http://amzn.to/1TUYoQT) and the only access to the interweb is via Wifi (no ethernet cat 5 connection in sight for miles).  However, your system is not recognizing your [Broadcom wireless card](http://amzn.to/1sOFhSI).  Your are in trouble.

![alt text]({{ page.image }} "Wireless Coffee")

First, you need to determine which card you have:

[http://askubuntu.com/questions/55868/installing-broadcom-wireless-drivers](http://askubuntu.com/questions/55868/installing-broadcom-wireless-drivers)

Mine is a ```BCM43142 14e4:4365 rev 01```.  And I am running [Trusty](https://wiki.ubuntu.com/DevelopmentCodeNames) 14.04 TLS so I need to use ```bcmwl-kernel-source```. 

Next, you need to utilize a different computer (or phone, or phablet) to [download the appropriate package](https://launchpad.net/ubuntu/+source/bcmwl). Save the .deb file to a [separate USB](http://amzn.to/1OULVAs) (or whatever) and copy to your local system.

You can now either [set up a local aptget offline repository](https://help.ubuntu.com/community/AptGet/Offline/Repository) or even easier - just right-click on the file from within [Ubuntu](http://amzn.to/1TUYoQT) and select "Open with Ubuntu Software Center" to install.

{% include disqus.html %}
