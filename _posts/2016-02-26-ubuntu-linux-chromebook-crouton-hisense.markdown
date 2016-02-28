---
layout: post
title: "Turn a Hisense Chromebook into a Dual Ubuntu/Chrome OS Laptop"
permalink: /ubuntu-linux-chromebook-crouton-hisense/
meta: linux ubuntu
published: false
---
Chromebooks are small affordable laptops.  They are great for **consuming** information.  Elementary, middle, and high schools like their low maintence, long life, low price, and ease-of-use.  Users utilize Google Docs to **produce** information, however this is not enough for "power users" who need the ability to instruct the computer to do work for them - develop software.

Recently I purchase a $90 USD refurbished Chromebook on [Woot](http://www.woot.com){:target="_blank"} -

> Hisense C11 11.6" Chromebook, Rockchip RK3288 Quad-Core, 16GB Internal Storage, 2GB Memory, 802.11ac, Bluetooth, Chrome OS

Enter [Crouton](https://github.com/dnschneid/crouton){:target="_blank"}.  The installation instructions are straight forward so I won't repeat them.  However you should read through it entirely at first to learn about options.  You end up with the ability to run [Chrome OS](https://en.wikipedia.org/wiki/Chrome_OS){:target="_blank"} and linux (Ubuntu or Debian) simultaneously.  You literally can ```Alt-Tab``` between environments, however its more like ```Ctrl-Shift-Alt-Arrow```.

Personally I think 2GB of RAM is a little to slim to run Unity Ubuntu so I opted for the [lxde](http://lxde.org/){:target="_blank"} desktop on Ubuntu.  Forget about Android Studio - I tried.  It simply uses too much memory.  And it seems that a few of its tools want ARM.  You can still install the JDK to run and compile Java.  Git, Ruby, Python, PyCharm, and WebStorm work well (did not try IntelliJ).

After installing Firefox (or Chromium) go ahead and remove [the default NetSurf browser](http://www.netsurf-browser.org/){:target="_blank"} - ```apt-get remove netsurf-gtk```.  Sure its small as a mouse, and fast as a cheetah but not familair to the majority.  I remember the Mosaic and Netscape days.
