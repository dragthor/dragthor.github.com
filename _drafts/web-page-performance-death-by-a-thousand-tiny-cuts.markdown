---
layout: post
title: "Web Page Performance Death by a Thousand Tiny Cuts"
permalink: /web-page-performance-death-by-a-thousand-tiny-cuts/
meta: javascript
---
Page performance It’s literally a death by a thousand tiny little cuts.

A last minute code review would let the following go out.  Its not really hurting anything.

Old -
{% highlight javascript %}
if (Foundation.utils.is_small_only() && $(".top-strip").outerHeight(true) == 2) 
	$(".top-strip").css("padding-top",0)
{% endhighlight %}

New -

Self-Invoking Anonymous Function - which might be overkill here.
type coercion 

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

Named function helps with debugging errors.
