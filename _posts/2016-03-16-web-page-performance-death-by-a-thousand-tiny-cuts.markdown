---
layout: post
title: "Web Page Performance Death by a Thousand Tiny Cuts"
permalink: /web-page-performance-death-by-a-thousand-tiny-cuts/
meta: javascript
published: false
---
Web page performance is literally a death by a thousand tiny little cuts.  Yes there are more, but some "cuts" include (in no particular order): 

* Not using image sprites.
* Not using a cookieless domain for images and other static content.  
* Not using a CDN.  
* Blocking javascript.  Worse if it's in the head.
* Not minifying your javascript and css.  
* Not optimizing caching policies.  
* Not gzipping your content.  Most if not all popular web servers support some type of compression option. 

Usually the biggest issue for most is the number of requests a page makes.  Keep the requests down and your web page performance increases.  And how many third party javascript partners are doing things on your page too?  Are they also performant?  What exactly are they downloading (and adding to your DOM)?  Hopefully they are working asynch.  But I digress (you can sense my [disliking of third party javascript vendors](http://metroize.com/preventing-object-modification-in-javascript/). The mobile world we currently live in makes fewer requests that much more important.  It's true that mobile and tablet devices are getting more powerful each day.  However they are still no match for the desktop.  And desktops are connected to broadband.  Mobile devices are utilizing 3G and 4G.

Javascript is an important performance factor too.  Sure there is the obvious low hanging fruit "code smells" that you should keep an eye out for like duplicate or unused code.  Using tools (from [JetBrains](http://www.jetbrains.com/), Microsoft, Google, etc.) definitely help spot mistakes, suggest improvements, avoid common gotchas and help enforce team coding standards.  Code reviews and unit testing lend a **big time** helping hand.  Unit tests help to isolate code which is convenient for performance testing and evaluation.  Code reviews help yout learn because they invite others to look at your code and tell you it sucks (or not).  And sometimes as a developer you need to hear how others would tackle a similar problem.  Take a breath.  Prepare yourself.  You cannot know everything.  

Putting on my manager's hat for a minute.  It's hard to justify spending eight developer hours to shave 50 milliseconds.  As focused developers we sometimes get too sucked in.  Over doing it by spending and burning hours to shave a few milliseconds may not be worth it unless its a focus or important area or feature on your site.  Utilizing the business can help drive your focus and see the forest from the trees.  And then just do what I do, and work on it on your own time.  Personally I sometimes dream about a problem, bug, or performance issue that I was unable to resolve.  Sometimes I lay awake at 3AM thinking about it.  I just cannot put it down.  It eats away at me.  Other developers must experience something similar.

Bottom line.  Try not to over do it (on company time).  At the end of the day you need to **ship it**.

I've done some javascript micro optimizations for [Zurb](http://foundation.zurb.com/) that I believe have been worth it.  Worth it not only for my own projects but also for others too.  Open source benefits the community of users.  

Sure you might think I'm a little crazy and over the top for micro optimizing javascript. I don't care.  I want fast, interactive, and responsive user experience.  Here are some examples (with [JsPerf](https://jsperf.com/) links) in no particular order that can impact the UI:

* [string `eval` vs. straight-up `eval`](http://jsperf.com/eval-string-vs-straight-up)
* [anonymous, inline, or unnamed functions vs. named functions](http://jsperf.com/anonymous-vs-named-functions) (see more below)
* unnecessary `jQuery.each()`, looping, iteration, or recursion
* coercion (see more below)
* [not `var` caching](http://jsperf.com/variable-caching-jquery)
* making the garbage collector work hard or collect more often
* causing excessive layout calculation, rendering, or invalidation

Most browsers have optimizations in place to deal with coercion.  Its not really a performance benefit to use `===` vs. `==`.  Its more to help with readability and undestanding for the next guy.  Function expressions are sometimes called (incorrectly?) anonymous, inline, or unnamed functions.  They can make debugging difficult because you might see an error (weeks later in a log) that doesn't explicitlly include its name (does not have one) or missing in the call stack (most F12 Dev Tools display <anonymous function>).

Test using older crappy devices.  I use an old 1st generation iPad with iOS 5 to test heavy pages with lots of javascript.  If your page is halfway decent on an older device it should be fine on the shiny newer ones.  And try to regression test by capturing test completion timing results from [QUnit](http://qunitjs.com/) and [Mocha](http://mochajs.org/) tests with headless [PhantomJs](http://phantomjs.org/).  Track, record, and then compare results.
 
Here is some code from a last minute code review that you might let normally go out.  Its not really hurting anything.  And personally my javascript is far from perfect at times.  Remember that when you look at another developer's code you usually do not know the context when it was written.  Was there a hard deadline?  Was there an emergency bug fix or issue?  Was it a show stopper?

{% highlight javascript %}
// Using Zurb foundation.
if (Foundation.utils.is_small_only() && $(".top-strip").outerHeight(true) == 2) 
   $(".top-strip").css("padding-top",0)
{% endhighlight %}

Changed to:

{% highlight javascript %}
(function () {
   // Using Zurb foundation.
   if (Foundation.utils.is_small_only()) {
      var topStrip = $(".top-strip");

      if (topStrip.outerHeight(true) === 2) {
         topStrip.css("padding-top", 0);
      }
   }
})();
{% endhighlight %}

The self-invoking anonymous function might be overkill.  Although ideally it should be organized within a namespace.  The `var` caching helps and the code is also more readable.  But that could just be personal style.  What do you think?  Are the tiny javascript cuts I mentioned nit-picking?  I am positive there are a lot more out there.

<span class="fi-page-edit size-21"></span> <a href="{{ site.post_source_root }}2016-03-16-web-page-performance-death-by-a-thousand-tiny-cuts.markdown" target="_blank">Contribute and Fork</a>

{% include disqus.html %}
