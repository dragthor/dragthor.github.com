---
layout: post
title: "Preventing Object Modification in Javascript"
permalink: /preventing-object-modification-in-javascript/
meta: javascript
---
Currently ([ECMAScript 5](http://www.ecmascript.org/docs.php){:target="_blank"}) there are three ways to prevent or "lock down" object modification in Javascript.  This is important to help prevent possible misbehaving third party Javascript partners from tampering with your objects.  Or worse - your own Javascript in other parts of your code base that you did not think about or test.  Or maybe there are specific areas or parts of your code where you want to write [immutable Javascript](https://github.com/facebook/immutable-js){:target="_blank"} and reap the [benefits](http://programmers.stackexchange.com/questions/151733/if-immutable-objects-are-good-why-do-people-keep-creating-mutable-objects){:target="_blank"}?

The methods below all "inherit" the abilities of the one above it (the one at the top is the least restrictive).

At the top is [```Object.preventExtensions()```](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/preventExtensions){:target="_blank"} -

* No newly added properties

Here is an [```Object.preventExtensions()```](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/preventExtensions){:target="_blank"} example:

	"use strict";

	var order = { Total: 100, SubTotal: 105 };

	order.OrderNumber = "0001";

	Object.preventExtensions(order);

	// TypeError: object is not extensible
	order.AffiliateCode = "BAD_THIRD_PARTY_VENDOR";

Next is [```Object.seal()```](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/seal){:target="_blank"} -

* Cannot remove properties

* Can only read/write to its properties

* Cannot change a property's type

* However, you can still have an object property and modify it

Here is an [```Object.seal()```](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/seal){:target="_blank"} example:

	"use strict";

	var order = { Total: 100, SubTotal: 105 };

	order.OrderNumber = "0001";
	order.Items = { Count: 0 };
	order.AffiliateCode = "TRUSTED_THIRD_PARTY_VENDOR";

	Object.seal(order);

	order.Items.Count = 2;

	// TypeError: Cannot delete property
	delete order.AffiliateCode;

At the bottom and most restrictive is [```Object.freeze()```](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/freeze){:target="_blank"} -

* Non-writable data properties

* Once frozen cannot become unfrozen

Here is an [```Object.freeze()```](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/freeze){:target="_blank"} example:

	"use strict";

	var order = { Total: 100, SubTotal: 105 };

	order.OrderNumber = "0001";
	order.AffiliateCode = "TRUSTED_THIRD_PARTY_VENDOR";

	Object.freeze(order);      

	// TypeError: Cannot assign to read only property
	order.Total = 500;
	order.AffiliateCode = "BAD_THIRD_PARTY_VENDOR";

When [Strict mode](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Strict_mode){:target="_blank"} is invoked an exception is thrown when attempting to modify an object using the aformentioned methods.  If ```use strict``` is not invoked then no exception is thrown and the modification attempt silently fails.

See the [ECMAScript compatibility table](http://kangax.github.io/compat-table/es5/){:target="_blank"} for strict mode support.

<a href="{{ site.post_source_root }}2016-02-02-preventing-object-modification-in-javascript.markdown" target="_blank">Contibute and Fork</a>

{% include disqus.html %}