---
layout: post
title: "Preventing Object Modification in Javascript"
permalink: /preventing-object-modification-in-javascript/
meta: javascript
---
Currently ([ECMAScript 5](http://www.ecmascript.org/docs.php)) there are three ways to prevent or lock down object modification in Javascript.  This is important to help prevent possible third party Javascript partners from tampering with your objects.

The methods below all "inherit" the abilities of the one above it (the one at the top is the least restrictive) –

* Object.preventExtensions()

	* No newly added properties

* Object.seal()

	* Non-configurable

		* Cannot remove properties

		* Can only read/write to its properties

		* Cannot change a property's type

		* You can still have an object property and modify it

* Object.freeze()

	* Non-writable data properties

	* Once frozen cannot become unfrozen

When [Strict mode](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Strict_mode) is invoked an exception is thrown when attempting to modify an object.  If ```strict mode``` is not invoked then no exception is thrown and silently fails.

[ECMAScript compatibility table](http://kangax.github.io/compat-table/es5/)
 