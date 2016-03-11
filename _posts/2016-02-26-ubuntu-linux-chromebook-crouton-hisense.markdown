---
layout: post
title: "Produce: Turn a Hisense Chromebook into a Dual Ubuntu/Chrome OS Laptop"
permalink: /ubuntu-linux-chromebook-crouton-hisense/
meta: linux ubuntu
---
Chromebooks are small affordable laptops.  They are great for **consuming** information, audio, and video.  Elementary, middle, and high schools like their low maintenance, long life, low price, and ease-of-use.  Users can utilize [Google Docs](http://docs.google.com/) to **produce** limited information and content, however it's not enough for "power users" who need the ability to develop software, edit images and video, or to utilize the computer to **produce** something more than a simple spreadsheet, document, or presentation.  Is there an ultra-portable and affordable laptop out there for the **producers** of the world?

Recently I purchase a $90 USD refurbished Chromebook on [Woot](http://www.woot.com) ([Amazon](http://amzn.to/21AnI8c) has them too) -

> Hisense C11 11.6" Chromebook, Rockchip RK3288 Quad-Core, 16GB Internal Storage, 2GB Memory, 802.11ac, Bluetooth, Chrome OS

Enter [Crouton](https://github.com/dnschneid/crouton).  The installation instructions are straight forward so I won't repeat them.  However at first you should read through it entirely to learn about options (ie, how not to install the [Unity desktop](https://unity.ubuntu.com/)).  You end up with the ability to run [Chrome OS](https://en.wikipedia.org/wiki/Chrome_OS) and linux (Ubuntu or Debian) simultaneously.  You literally can ```Alt-Tab``` between environments, although it's more like ```Ctrl-Shift-Alt-Arrow``` which can be a little clumsy.

Personally I think 2GB of RAM is a little too slim to run Unity Ubuntu so I opted for the [lxde](http://lxde.org/) desktop with Ubuntu.  Forget about Android Studio - I tried.  It simply uses too much memory.  And it seems that a few of its tools favor Intel x86.  You can still install the JDK to run and compile Java.  Gimp, Git, Ruby, Python, PyCharm, and WebStorm work well.  I did not try to install IntelliJ or a [LAMP stack](https://en.wikipedia.org/wiki/LAMP_%28software_bundle%29).

After installing Firefox (or Chromium) go ahead and remove the default [NetSurf browser](http://www.netsurf-browser.org/) - ```apt-get remove netsurf-gtk```.  Sure its small as a mouse, and fast as a cheetah but not familiar to the majority of users.  I am old enough to remember the Mosaic and early Netscape days - I'm trying to move past them.

One consequence of enabling Developer Mode on the Chromebook is that during boot you have to ```Ctrl-D``` every time to confirm.  The good news is that you do not have to perform reboots often.  The battery can last a long time and the Chrome OS optimizes (works correctly) when you close the lid.  Expect a similar experience to the Mac laptops which also provide good, clean, lid closing.  Is it me or has lid closing been an unresolved issue with Windows laptops?

In the future I plan on purchasing two more Chromebooks for my kids (wink wink - dad will be taking them apart).  Probably with an Intel processor just to see if I can successfully build an existing Android project.

Final thoughts - are you primarily a consumer or a producer?  And what is the ideal balance?  80% producer, 20% consumer?  And are you consuming too much?  Personally I need to be producing more consuming less.

<span class="fi-page-edit size-21"></span> <a href="{{ site.post_source_root }}2016-02-26-ubuntu-linux-chromebook-crouton-hisense.markdown" target="_blank">Contribute and Fork</a>

{% include disqus.html %}