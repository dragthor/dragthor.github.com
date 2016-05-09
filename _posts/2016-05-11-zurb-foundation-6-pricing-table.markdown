---
layout: post
title: "Zurb Foundation 6 Pricing Table"
permalink: /zurb-foundation-6-pricing-table/
meta: zurb
published: false
description: "How to make a Zurb Foundation 6 pricing table.  They were removed from Zurb Foundation 5."
image: http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/zurb6-pricing-table.PNG
---
Zurb Foundation 6 no longer includes a pricing table component.  No problem.  Let's put one in as these are great for marketing landing pages, signups, and product or subscription comparisons.  Both Zurb 5 and Zurb 6 utilize Sass, however the variables have either changed, were made obsolete, or flat-out no longer make sense.  After following the steps below, you will end up with a Zurb 6 pricing table looking like this:

![alt text]({{ page.image }} "Zurb 6 Pricing Table")

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

https://gist.github.com/dragthor/bab15cbee60c42f682f2a292791f3a66

Pull down and install [Zurb Foundation](https://github.com/zurb/foundation-sites).

Using your favorite text editor or IDE, create the following files:

`docs/pages/pricingtable.md`

`scss/components/_pricingtable.scss`

Crack open `scss/foundation.scss` and append the following to the list of import statements:

`@import 'components/pricingtable';`

Here is the Scss:

<script src="https://gist.github.com/dragthor/6d4638eb28b6138054d7e619093710b2.js"></script>

Disclaimer: I am a Foundation fan, user, and minor open-source contributor.

{% include adsense.html %}

{% include disqus.html %}
