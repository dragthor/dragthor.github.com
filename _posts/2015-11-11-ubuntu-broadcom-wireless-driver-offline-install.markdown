---
layout: post
title: "Ubuntu Broadcom Wireless Driver Offline Install"
permalink: /ubuntu-broadcom-wireless-driver-offline-install/
meta: linux ubuntu
---
You installed Ubuntu and the only access to the interweb is via Wifi (no ethernet cat 5 connection in sight for miles).  However, your system is not recognizing your Broadcom wireless card.  Your are in trouble... for now...

First you need to determine which card you have:

[http://askubuntu.com/questions/55868/installing-broadcom-wireless-drivers](http://askubuntu.com/questions/55868/installing-broadcom-wireless-drivers){:target="_blank"}

Mine is a ```BCM43142 14e4:4365 rev 01```.  And I am running [Trusty](https://wiki.ubuntu.com/DevelopmentCodeNames){:target="_blank"} 14.04 TLS so I need to use ```bcmwl-kernel-source```. 

Next I need to utilize a different computer (or phone, or phablet) to [download the appropriate package](https://launchpad.net/ubuntu/+source/bcmwl){:target="_blank"}. Save the .deb file to a separate USB (or whatever) and copy to your local system.

You can now either [set up a local aptget offline repository](https://help.ubuntu.com/community/AptGet/Offline/Repository){:target="_blank"} or even easier... just right-click on the file from within Ubuntu and select "Open with Ubuntu Software Center" to install.

<a href="{{ site.post_source_root }}2015-11-11-ubuntu-broadcom-wireless-driver-offline-install.markdown" target="_blank">Contibute and Fork</a>

{% include disqus.html %}
