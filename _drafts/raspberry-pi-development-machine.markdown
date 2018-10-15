---
layout: post
title: "Raspberry Pi Development Machine"
permalink: /raspberry-pi-development-machine/
meta: linx
---
headless setup - [Raspbian Stretch Lite](https://www.raspberrypi.org/downloads/raspbian/)

Raspberry Pi 3 Model B - 1GB RAM, Quad Core 1.2GHz Broadcom BCM2837 64bit CPU

`username: pi
password: raspberry`

configure keyboard, localization, time, timezone, Wifi country

`$ sudo raspi-config`

configure wifi

advanced option

We are running our Raspbian Lite system without a graphical user interface so we can reduce the amount of memory made available for the GPU and consequently make more memory available for the CPU since the CPU/GPU memory is shared.

Arrow down to Memory Split and hit the Enter key.

Enter a value of 16 for the amount of memory in MB that the GPU should have and hit the Enter key.

apt-get update

python

lynx

`$ sudo apt install lynx`

nodejs 

`$ curl -sL https://deb.nodesource.com/setup_10.x | sudo -E bash -`

`$ sudo apt install nodejs`

git

`$ sudo apt install git`

configure your default git to reduce the number of times you must type your username or password (20 minutes below).

`$ git config --global user.name "John Doe"`
`$ git config --global user.email johndoe@example.com`
`$ git config credential.helper 'cache --timeout=1200'`

nano, emacs, vi, or something else
