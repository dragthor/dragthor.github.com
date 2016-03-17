---
layout: post
title: "Web Page Performance Death by a Thousand Tiny Cuts"
permalink: /web-page-performance-death-by-a-thousand-tiny-cuts/
meta: javascript
published: false
---
Web page performance is literally a death by a thousand tiny little cuts.  Sure there are some big obvious low hanging fruit "code smells" that you should keep an eye out for (like duplicate or unused code).  And yes, it's hard to justify spending eight hours to shave 50 milliseconds.

I've done some micro optimizations for [Zurb](http://foundation.zurb.com/) that have been worth it.  Not only for own projects but others too.  Sure you might think I'm a little crazy and over the top - I don't care.  I want fast web pages.

Invite other to look at my code and tel me it sucks.  Help me learn.

Over doing it by spending/burning hours to shave a few milliseconds.  May not be worth it unless its a focus or important area or feature on your site.  The business can help drive your focus.

Test on old crappy devices.  For example, I use an old 1st generation iPad with iOS 5 to test heavy pages.

Use tools (from [JetBrains](http://www.jetbrains.com/), Microsoft, Google, etc.) to help spot mistakes.  Code reviews and unit testing also help - big time.

Do not over do it, at the end of the day you need to **ship it**.

Regression test by capture timing from qUnit tests with headless PhantomJs - compare results.

Some examples

  -  string evals
  -  anonymous and inline functions
    - debugging difficult.  Named function helps with debugging errors.
  -  unnecessary each or looping
  -  coercion === [jsPerf](https://jsperf.com/)
  -  not var caching
  -  GC working too hard
  -  layout calculation and rendering
    - invalidation
    
A last minute code review would let the following go out.  Its not really hurting anything.

Old -
{% highlight javascript %}
if (Foundation.utils.is_small_only() && $(".top-strip").outerHeight(true) == 2) 
	$(".top-strip").css("padding-top",0)
{% endhighlight %}

New -

Self-Invoking Anonymous Function - which might be overkill here.

http://jsperf.com/anonymous-vs-named-functions

{% highlight javascript %}
(function () {
	if (Foundation.utils.is_small_only()) {
		var topStrip = $(".top-strip");

		if (topStrip.outerHeight(true) === 2) {
			topStrip.css("padding-top", 0);
		}
	}
})();
{% endhighlight %}

<span class="fi-page-edit size-21"></span> <a href="{{ site.post_source_root }}2016-03-16-web-page-performance-death-by-a-thousand-tiny-cuts.markdown" target="_blank">Contribute and Fork</a>

{% include disqus.html %}
