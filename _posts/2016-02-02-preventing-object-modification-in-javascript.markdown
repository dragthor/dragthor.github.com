---
layout: post
title: "Preventing Object Modification in Javascript"
permalink: /preventing-object-modification-in-javascript/
meta: javascript
---
Currently ([ECMAScript 5](http://www.ecmascript.org/docs.php)) there are three ways to prevent or lock down object modification in Javascript.  This is important to help prevent possible third party Javascript partners from tampering with your objects.  Or if you want to write [immutable Javascript](https://github.com/facebook/immutable-js).

The methods below all "inherit" the abilities of the one above it (the one at the top is the least restrictive).

1. [```Object.preventExtensions()```](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/preventExtensions)

	* No newly added properties

Here is an [```Object.preventExtensions()```](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/preventExtensions) example:

	"use strict";

	var order = { Total: 100, SubTotal: 105 };

	order.OrderNumber = "0001";

	Object.preventExtensions(order);

	// TypeError: object is not extensible
	order.AffiliateCode = "BAD_THIRD_PARTY_VENDOR";

2. [```Object.seal()```](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/seal)

	* Non-configurable

		* Cannot remove properties

		* Can only read/write to its properties

		* Cannot change a property's type

		* You can still have an object property and modify it

Here is an [```Object.seal()```](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/seal) example:

	"use strict";

	var order = { Total: 100, SubTotal: 105 };

	order.OrderNumber = "0001";
	order.Items = { Count: 0 };
	order.AffiliateCode = "TRUSTED_THIRD_PARTY_VENDOR";

	Object.seal(order);

	order.Items.Count = 2;

	// TypeError: Cannot delete property
	delete order.AffiliateCode;

3. [```Object.freeze()```](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/freeze)

	* Non-writable data properties

	* Once frozen cannot become unfrozen

Here is an [```Object.freeze()```](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Object/freeze) example:

	"use strict";

	var order = { Total: 100, SubTotal: 105 };

	order.OrderNumber = "0001";
	order.AffiliateCode = "TRUSTED_THIRD_PARTY_VENDOR";

	Object.freeze(order);      

	// TypeError: Cannot assign to read only property
	order.Total = 500;
	order.AffiliateCode = "BAD_THIRD_PARTY_VENDOR";

When [Strict mode](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Strict_mode) is invoked an exception is thrown when attempting to modify an object.  If strict mode (```use strict```) is not invoked then no exception is thrown and silently fails.

See the [ECMAScript compatibility table](http://kangax.github.io/compat-table/es5/) for strict mode support.
 