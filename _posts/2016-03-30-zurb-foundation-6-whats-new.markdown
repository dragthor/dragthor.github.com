---
layout: post
title: "What's new in Zurb Foundation 6?"
permalink: /zurb-foundation-6-whats-new/
meta: zurb
published: false
---
Initially released in November 2015, Zurb's [Foundation for Sites 6](http://foundation.zurb.com/sites/docs/) brings some new features, functionality, and concepts.  Although Foundation’s core principles and ideas remain, when comparing the latest code to the previous version you can see an almost complete overhaul.  Immediately you'll notice some [ECMAScript 2015](http://www.ecma-international.org/ecma-262/6.0/) syntax usage.  The arrows `=>` jumped out at me as the code now gets transpiled to ES5 with [Babel](https://babeljs.io/) during the [gulp](http://gulpjs.com/) build process.  [Grunt](http://gruntjs.com/) is no longer used.  Foundation 5 utilized the Javascript testing framework [Jasmine](http://jasmine.github.io/).  And it too has been replaced with [Mocha](http://mochajs.org/) and [Chai](http://chaijs.com/).  Unfortunately a lot of the unit tests did not make it over to Foundation 6.  [Pull request](https://github.com/zurb/foundation-sites/tree/V5) idea – time to help write some new tests.

##Zurb Foundation 6 Browser Compatibility

Not much has changed.  Browsers that do not support media queries still receive the default mobile first experience.  IE9+, Android 2.3+ and the last two versions of Chrome, Firefox, Opera, Mobile Safari, and IE mobile are supported.  And yes, Zurb is still using (and dependent on) jQuery 2.x which also left behind legacy browsers.  Maybe Zurb Foundation 7 will decouple the jQuery dependency?

##Zurb Foundation 6 Accessibility

Where it makes sense, Zurb Foundation components are keyboard-accessible and screen reader friendly as they have ARIA attributes and borrow accessibility patterns and practices from the [A11y project](http://a11yproject.com/).  Implementing thoughtful accessibility still seems to be more of an art than science.  At the end of the day, accessibility is still the developer’s responsibility, not Foundation’s.  One continuing challenge is that you still need to test with actual screen readers, special keyboards, and speech recognition tools that real people use.  Here are some helpful accessibility testing tools:

* [aDesigner](http://www.eclipse.org/actf/downloads/tools/aDesigner/)
* [WebAnywhere](http://webanywhere.cs.washington.edu/)
* [Vischeck](http://www.vischeck.com/)

> At the end of the day, accessibility is still the developer’s responsibility, not Foundation’s.  

##Zurb Foundation 6 Components

Standalone [Block Grids](http://foundation.zurb.com/sites/docs/v/5.5.3/components/block_grid.html) disappear and have been merged into the default [Grid](http://foundation.zurb.com/sites/docs/grid.html) layout component.  Block Grids provided a way to evenly space list contents regardless of screen size.  Now it’s a matter of applying a class in this format `[size]-up-[n]` at the row level.  Combining grids is a welcoming change since it was a little wonky having two grids in Foundation 5.  Additionally responsive grid gutters have made their way into Foundation 6.  The ability to responsively define the spacing between the edge of a grid and the edge of the page is a big win for users (and most of my clients).  Warning - static gutters are no longer supported as of version 6.2.

> Warning - static gutters are no longer supported as of version 6.2.

[Flex Grid](http://foundation.zurb.com/sites/docs/flex-grid.html) is a newly introduced flexbox-driven grid.  Usage benefits include less CSS, easier to understand, and easier to use.  One disadvantage is browser compatibility which introduces risk and increases the testing cycle.  This means most of us that need to support older browsers will stick with the normal decaffeinated Grid.  Zurb Foundation 6 did not stop the flexbox train at Flex Grid.  Rather they extended the flexbox concept to optionally empower most Foundation 6 components (the button group, input group, menu, top bar, media object, and title bar) to negate the need for float and table cell shenanigans.  This global flexbox mode is purely optional (disabled by default) and generates a lot less CSS.  Less is more.

>  Flexbox mode negates the need for float and table cell shenanigans.

Lastly I want to point out that [modernizr](https://modernizr.com/) is removed.  Instead the [what-input](https://github.com/ten1seven/what-input) library is used to determine the current input method (mouse, keyboard, or touch).  Apparently too many developers (myself included) are incorrectly relying on `Modernizr.touch` and end up in limbo with –

* tablet users using a mouse
* touch-enabled laptops (or desktops)

Directly from Foundation’s documentation:

> There are no classes to detect touchscreen devices, as both desktop and mobile browsers inconsistently report touch support.

##Zurb Foundation 6 Plugins

Plugins are a new addition to the framework too.  They help facilitate consistent integration and enable extensibility.  Although limited to only one element at a time, plugins can be nested and attached to elements using data attributes (`data-accordion` or `data-tooltip`).  A similar method found in Foundation 5, plugins should utilize `data-options` for settings and default behavior.  Per documentation (and good practice) callbacks as settings are discouraged (and removed) and should be implemented as event listeners.  Moreover, a global `reInit` function is defined and causes one or more active plugins to re-initialize, reset/remove event listeners,  to recalculate position, etc.  `reInit` is your consistent replacement for `reflow`.

[Foundation 5](http://foundation.zurb.com/sites/docs/v/5.5.3/) components and features that are now plugins:

* Abide (form validation)
* Equalizer (equal height manager)
* Interchange (dynamically load responsive content)
* Toggler (toggle CSS or animate an element)
* Sticky (stick it anywhere)

> `reInit` is your consistent replacement for `reflow`.

##Zurb Foundation 6 CSS

Overall Zurb Foundation 6 outputs less CSS resulting in less work for the browser.  One obvious way to accomplish less CSS is to not use certain components.  Pick and choose what you need.  Fortunately this is a little easier compared to Foundation 5 which required some manual developer intervention (post grunt clean up).  [CSS Mixins](http://foundation.zurb.com/sites/docs/sass-mixins.html) facilitate reusable styles and rules which also means less CSS.  For example you could decide to not use `foundation-grid`, but still use grid mixins like `grid-row`, `grid-col`.  Mixins are also more expressive and semantic.  Instead of having the following sprinkled throughout your markup:

`<div class="medium-6 large-4 medium-push-6 large-push-4 columns" />`

You can now use CSS Mixins with Foundation 6 to have just this:

`<div class="mainContentArea" />` or 

`<div class="leftNavigation" />` or 

`<div class="sideBar" />`

A new [Motion UI](http://foundation.zurb.com/sites/docs/motion-ui.html) Sass library helps to bring flexible UI transitions and animations to the framework.  Along with it are about two dozen transition classes that come out-of-the-box.  Finally, another notable addition to the gulp pipeline (think series of tubes) is `sass-true` to bring some [CSS unit testing](https://www.npmjs.com/package/sass-true) to the table for `[function]` and `[mixin]`. Testing CSS used to be crazy talk.

##Zurb Foundation 6 Javascript

The amount of Javascript is less because it’s easier to choose only the components, features, and plugins that you need.  However, one of the biggest change is the onboarding of [Babel](https://babeljs.io/) to transpile [ECMAScript 2015](http://www.ecma-international.org/ecma-262/6.0/) within the [gulp](http://gulpjs.com/) build pipeline.  Before digging into the guts of [Foundation 6 code](https://github.com/zurb/foundation-sites) it might be wise to read up on arrow syntax `(e) => {}`, custom iteration `forEach(id => {})`, and classes `class`.  You know, yummy delicious syntax sugar.  Homer Simpson voice, “Mmm... Zurb”.

Components such as Tooltips sometimes like to leave behind footprints (i.e., the tooltip template).  Fortunately a new `destroy` pattern is consistently implemented – when finished, clean yourself up.  This would also be a great pattern to implement in Foundation 5.  [Pull request](https://github.com/zurb/foundation-sites/tree/V5) anyone?  `destroy` literally destroys instance, state, unbinds events, or removes elements completely.  Performance matters.  And I hate seeing unused Tooltip templates lingering in my DOM.  Sometimes third party Javascript vendors like to haphazardly bind to these elements and never let go.

##Final Thoughts

Zurb [Foundation 6 for Sites](http://foundation.zurb.com/sites/docs/) is good and carefully considered for both designers and frontend developers.  Download it.  Try it.  Contribute to it.  Help make it better.  Heck, share some knowledge with a backend developer too!  While not as mature as Foundation 5 and with less tests, Foundation 6 should be your mobile first responsive strategy going forward.

Disclaimer – I am a Foundation fan, user, and minor open source contributor.

<span class="fi-page-edit size-21"></span> <a href="{{ site.post_source_root }}2016-03-30-zurb-foundation-6-whats-new" target="_blank">Contribute and Fork</a>

{% include disqus.html %}
