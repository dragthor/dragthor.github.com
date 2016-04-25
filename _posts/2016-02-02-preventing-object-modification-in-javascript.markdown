---
layout: post
title: "Preventing Object Modification in Javascript"
permalink: /preventing-object-modification-in-javascript/
meta: javascript
image: http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/javascript.jpg
description: "Prevent possible misbehaving third party Javascript partners from tampering with your Javascript objects.  Guard against lead generation, eCommerce pixel partners, referral & affiliates, and commission tracking."
---
Currently ([ECMAScript 5](http://www.ecmascript.org/docs.php)) there are three ways to prevent or "lock down" object modification in Javascript.  This is important to help prevent possible misbehaving third-party Javascript partners from tampering with your objects.  Or worse - your own Javascript in other parts of your code base that you did not consider or test.  Or maybe there are specific areas or parts of your code where you want to write [immutable Javascript](https://github.com/facebook/immutable-js) and reap the [benefits](http://programmers.stackexchange.com/questions/151733/if-immutable-objects-are-good-why-do-people-keep-creating-mutable-objects)?

![alt text]({{ page.image }} "Javascript")

The methods below all "inherit" the abilities of the one above it (the one at the top is the least restrictive).

{% include adsense.html %}

At the top is [```Object.preventExtensions()```](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/preventExtensions) -

* No newly added properties

Here is an [```Object.preventExtensions()```](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/preventExtensions) example:

{% highlight javascript %}
"use strict";

var order = { Total: 100, SubTotal: 105 };

order.OrderNumber = "0001";

Object.preventExtensions(order);

// TypeError: object is not extensible
order.AffiliateCode = "BAD_THIRD_PARTY_VENDOR";
{% endhighlight %}

Next is [```Object.seal()```](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/seal) -

* Cannot remove properties

* Can only read/write to its properties

* Cannot change a property's type

* However, you can still have an object property and modify it

Here is an [```Object.seal()```](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/seal) example:

{% highlight javascript %}
"use strict";

var order = { Total: 100, SubTotal: 105 };

order.OrderNumber = "0001";
order.Items = { Count: 0 };
order.AffiliateCode = "TRUSTED_THIRD_PARTY_VENDOR";

Object.seal(order);

order.Items.Count = 2;

// TypeError: Cannot delete property
delete order.AffiliateCode;
{% endhighlight %}

At the bottom and most restrictive is [```Object.freeze()```](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/freeze) -

* Non-writable data properties

* Once frozen cannot become unfrozen

Here is an [```Object.freeze()```](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/freeze) example:

{% highlight javascript %}
"use strict";

var order = { Total: 100, SubTotal: 105 };

order.OrderNumber = "0001";
order.AffiliateCode = "TRUSTED_THIRD_PARTY_VENDOR";

Object.freeze(order);      

// TypeError: Cannot assign to read only property
order.Total = 500;
order.AffiliateCode = "BAD_THIRD_PARTY_VENDOR";
{% endhighlight %}

When [Strict mode](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Strict_mode) is invoked an exception is thrown when attempting to modify an object using the aforementioned methods.  If ```use strict``` is not invoked then no exception is thrown and the modification attempt silently fails.

See the [ECMAScript compatibility table](http://kangax.github.io/compat-table/es5/) for strict mode support.

Lead generation, eCommerce pixel partners, referral & affiliates, and commission tracking are some use cases that come to mind.  What are some other scenarios to guard your Javascript objects against?  And yes, unfortunately sometimes our own code can be our enemy too.

{% include adsense.html %}

<span class="fi-page-edit size-21"></span> <a href="{{ site.post_source_root }}2016-02-02-preventing-object-modification-in-javascript.markdown" target="_blank">Contribute and Fork</a>

{% include disqus.html %}