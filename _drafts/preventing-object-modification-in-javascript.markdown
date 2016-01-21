layout: post
title: "Preventing Object Modification in Javascript"
permalink: /preventing-object-modification-in-javascript/
categories: javascript
meta: javascript
---
Currently (ECMAScript 5) there are three ways to prevent or lock down object modification in Javascript. They all "inherit" the abilities of the one above it (the one at the top is the least restrictive) –

* Object.preventExtensions()

	* No newly added properties

* Object.seal()

	* Non-configurable

		* Cannot remove properties

		* Can only read/write to its properties

		* Cannot change a property's type

		* You can still have an object property an modify it

* Object.freeze()

	* Non-writable data properties

	* Once frozen cannot become unfrozen

Immutable and immutability.

[Strict mode](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Strict_mode). What exactly is it? Should be on for all [qUnit](http://qunitjs.com/) tests.

Strict mode throws exceptions when attempting to modify an object. Else it just silently fails.

[ECMAScript compatibility table](http://kangax.github.io/compat-table/es5/)
 