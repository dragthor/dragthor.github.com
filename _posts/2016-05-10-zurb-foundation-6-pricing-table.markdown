---
layout: post
title: "Zurb Foundation 6 Pricing Table"
permalink: /zurb-foundation-6-pricing-table/
meta: zurb
published: true
description: "How to make a Zurb Foundation 6 pricing table.  They were removed from Zurb Foundation 6."
image: http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/zurb6-pricing-table.PNG
---
Zurb's [Foundation for Sites 6](http://foundation.zurb.com/sites/docs/) no longer includes a Pricing table component.  No problem.  Let's put a Pricing table in the Zurb 6 pipeline.  They are great for marketing landing pages, product signups, and subscription or product comparisons.  Unfortunately, I saw a few people on the interwebs indicate Zurb 6's lack of Pricing tables a show stopper; preventing their move from Zurb 5 to Zurb 6.  At the end of the day, regardless of version, Zurb Foundation is still CSS, HTML, and Javascript.  And both Zurb 5 and Zurb 6 utilize [Sass](http://sass-lang.com/); although some Scss variables have either changed, were made obsolete, or flat-out no longer make sense.  After utilizing the code and instructions below, you will end up with a Zurb 6 responsive Pricing table.

## The End Result
I made it look exactly like a Zurb 5 Pricing table.  But you can modify the colors, border, and style if you like.

![alt text]({{ page.image }} "Zurb 6 Pricing Table")

## Markup
The HTML stays exactly the same.  Notice we are **not** using a `<table/>` tag.

{% highlight xml %}
<ul class="pricing-table">
  <li class="title">Standard</li>
  <li class="price">$99.99</li>
  <li class="description">An awesome description</li>
  <li class="bullet-item">1 Database</li>
  <li class="bullet-item">5GB Storage</li>
  <li class="bullet-item">20 Users</li>
  <li class="cta-button"><a class="button" href="#">Buy Now</a></li>
</ul>
{% endhighlight %}

## CSS
If you haven't already done so, pull down and install [Zurb Foundation](https://github.com/zurb/foundation-sites).  If you are unsure, review the [Getting Started](https://github.com/zurb/foundation-sites#getting-started) instructions.  If you are coming from Zurb 5, check out a previous post: [What's new in Zurb Foundation 6?](/zurb-foundation-6-whats-new/).

Using your favorite text editor or IDE, create and/or modify the following files.  I've been using Microsoft's free, open source, multi-platform [Visual Studio Code](https://code.visualstudio.com/).  It might be better than [Sublime Text](http://www.sublimetext.com/).

* `scss/foundation.scss`

Append `@import 'components/pricingtable';` to the list of import statements.

* `scss/components/_pricingtable.scss`

Use the modified Scss below.

<script src="https://gist.github.com/dragthor/6d4638eb28b6138054d7e619093710b2.js"></script>

## Final Thoughts
Pricing tables were missed.  And I agree with Zurb's decision to not make them part of the core framework.  They are too specific and niche.  But I showed you how to bring Pricing tables back.  One less excuse to not transition from Zurb 5 to Zurb 6.  Now get back out there and design something responsively awesome!

Disclaimer: I am a Foundation fan, user, and minor open-source contributor.

{% include signup.html %}

{% include disqus.html %}
