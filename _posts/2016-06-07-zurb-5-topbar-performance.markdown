---
layout: post
title: "Zurb 5 Sticky Topbar Performance"
permalink: /zurb-foundation-5-sticky-topbar-performance/
meta: zurb performance
published: true
description: "Zurb Foundation 5 sticky topbar performance."
image: http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/zurb-6.png
---
While profiling our [Zurb 5](http://foundation.zurb.com/sites/docs/v/5.5.3/) implementation, we noticed a slight bottle neck using the "sticky" `topbar` component.  The user would sometimes experience a "stutter" or "glitch" while scrolling.  And users with lower end devices would experience the issue more often.

The problem: `update_sticky_positioning` is called a lot. Too much.  After a couple of good scrolls, hundreds of times.

The solution: `throttle` the `scroll` handler when calling `update_sticky_positioning`.

I introduced a new setting named `scroll_throttle` with a default value of 300 milliseconds. Throughout our test cycles the value works well.  

Inside the `sticky` function this:

{% highlight javascript %}
this.S(window).on('scroll', function () { self.update_sticky_positioning(); });
{% endhighlight %}

Becomes:

{% highlight javascript %}
this.S(window).on('scroll', self.throttle( function () {
        self.update_sticky_positioning();
      }, self.settings.scroll_throttle));
{% endhighlight %}

View the [pull request](https://github.com/zurb/foundation-sites/pull/8884/files).  Sure, it's a slight gain but the stutter is pretty much gone.

Javascript profiler before:

![alt text](https://cloud.githubusercontent.com/assets/156634/15751986/2d2c124c-28ba-11e6-8ecb-c781ea6fa410.PNG
 "Zurb 5 Tobar Profiled Before")

Javascript profiler after:

![alt text](https://cloud.githubusercontent.com/assets/156634/15751989/30daf980-28ba-11e6-9328-f189d395c489.PNG
 "Zurb 5 Tobar Profiled Before")

Disclaimer: I am a Foundation fan, user, and minor open-source contributor.  And yes, I work for a company that sells bras.

{% include signup.html %}

{% include disqus.html %}
