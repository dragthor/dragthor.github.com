---
layout: post
title: "Introducing Zurb Foundation 6 Plugins "
permalink: /zurb-foundation-6-plugins/
meta: zurb
published: false
description: "How to make a Zurb Foundation 6 plugin.  What are the ingredients?  Boilerplate Javascript code functions."
image: http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/zurb-plugin.jpg
---
Zurb [Foundation for Sites 6](http://foundation.zurb.com/sites/docs/) allows you to design and develop your own custom responsive plugins.  As previously mentioned in [What's new in Zurb Foundation 6](/zurb-foundation-6-whats-new/), plugins help facilitate consistent integration and enable extensibility.  Foundation comes with several out of the box plugins such as accordion, dropdown, menu, reveal, slider, and tooltips.  However, sometimes these are not enough.  Your project or client requires more functionality than Zurb believes is not general enough to include in the base framework.  This is fair.  Most frameworks work this way, at least in the beginning.  [jQuery](http://jquery.com/), [Java](http://www.java.com/), and [Microsoft .NET](https://www.microsoft.com/net/) have ballooned in size with features that most of us never use, but I digress. 

It's helpful to think of plugins using this analogy: Zurb is an electrical outlet that provides responsive framework power.  A Zurb plugin is the pronged ending plug that literally "plugs" into this outlet.

At the end of an electrical cord in your house, there could be any type of interchangeable device (a toaster, a [George Foreman grill](http://amzn.to/1SOK0bY), a lamp, etc.).  You can substitute any device because they expect to plug into any standardized outlet.

Similar to household devices, Zurb plugins need to follow some predetermined rules, standardized guidelines, expectations, and interfaces (three hole vs. two hole and 120V vs. 240V).  Plug a device expecting to receive 120V into a 240V outlet and things go bad (fire).  Fortunately, this is software and your plugin will just not work properly.  This post explains the ingredients needed to develop a responsive plugin using Zurb Foundation 6 for Sites. It's less painful than you might think.

![alt text]({{ page.image }} "Zurb Foundation 6 plugin")

## Boilerplate Skeleton Code

What do all plugins have in common and what are they made of?  At the end of day, creating a Zurb plugin requires nothing more than providing custom CSS, HTML, and Javascript.  The idea is to not fight against the framework.  Work with it.  Extend that which has already been implemented by people smarter than you and I.  You can even wrap existing components to "plug in" into existing Zurb ideas.  For example, a custom Zurb datepicker could be composed of an input field to receive focus, then display a `reveal` with three dropdowns (one for day, month, and year) as shown here:

<script src="https://gist.github.com/dragthor/0cea3539e5eca54dc0f9fca0b82f5f48.js"></script>

In the traditional object-oriented programming world, the above described datepicker composes one or more existing components.  When the datepicker is destroyed via `destroy` (see below), the three dropdowns are also destroyed.  Depending on your plugin, destroy can mean DOM removal and unbinding events.  A custom Zurb plugin that owns (or wraps) another component that has no meaning or purpose outside the context of the plugin, is an example of composition.  Each dropdown would not make sense outside the container component.  There is a strong association to the datepicker plugin.  And each would probably look terrible and confuse users.  Arrows within a filmstrip slider, a legend within a chart component, and a sortable grid column header are some other examples.

These examples have me thinking.  Can traditional reporting data grids be responsive?  Anything can be made responsive, but will it provide meaningful value to users?  Do tabular data grids even fit in the responsive world?  I do not know or have answers to these questions as "mobile-first data grid" does not roll off the tongue well.  I need to do some research, find use cases, and see what Zurb's [stacked table](http://foundation.zurb.com/sites/docs/table.html) offers.  A Zurb pie, bar, scatter plot, or line chart plugin sounds like a potential useful open-source project. Anyone want to create a new [Github repository](https://github.com/open-source)? 

Javascript is not as strict as C# or Java regarding interface adherence, so technically you could get away with not implementing the standard methods listed below.  The current world of Javascript: no compilers, just transpilers and conventions.  One standard convention stated directly in the Zurb documentation:  

> Plugin methods prefixed with an underscore are considered part of the internal API, which means they could change, break, or disappear without warning. 

I am unsure why you wouldn't want your plugin to play nicely with Zurb and other components.  At minimum your plugin should contain these methods (technically `_init` and `_events` are not required, but it's a good idea to make these separate):  

* `constructor(element, options)` - class constructor to initialize, create, and register your plugin.  Zurb 6 utilizes [Babel](https://babeljs.io) to transpile to prototype-based ES5.  This is also the place to register `Foundation.Keyboard` handlers.  

* `destroy()` - destructor for clean up tasks: DOM removal, unbind events, and unregister your plugin. 

* `_init()` -  `reflow` `reInit` to reinitialize, reset/remove event listeners, recalculate position, etc.   

* `_events()` - define and setup events.  The fictional datepicker previously described might trigger `dateSelected`, `cancelled`, and `isValid` events.  It might also decide to bind and handle dropdown events, encapsulating them.

## Plugin Management 

How are plugins managed by the framework?  Inside the constructor and destroy methods are calls to `Foundation.registerPlugin` and `Foundation.unregisterPlugin(this)`.  Each are found in `foundation.core.js` and described below:

### registerPlugin

Calling `registerPlugin` is how your plugin announces to the Zurb framework, "Hey, I am here!"  Foundation stores a unique id pointer (think C# or Java reference) for each plugin instance in an internal `Array` and then triggers the plugin's initialization event.  Additionally, it adds the `zfPlugin` data-attribute to allow your plugin to be used like this:

* `$('#myZurbPlugin').foundation('destroy');` - I am done with you.  Now go away and make sure you clean yourself up.
* `$('#myZurbPlugin').foundation('formatTime');` - Call the publicly available `formatTime` function on the fictitious datepicker.
* `$('#myZurbPlugin').foundation('buyKrisCoffee');` - Buy Kris a cup of coffee.

### unregisterPlugin

Calling `unregisterPlugin` is how your plugin announces to the Zurb framework, "Hey, I am done!"  Foundation removes the unique id pointer from the internal `Array`, removes the added `zfPlugin` data-attribute, and remove any `zfPlugin` stored data.  Finally, it triggers the plugin's destroy event.

<script src="https://gist.github.com/dragthor/8ca90a0cd019c1fcb3f45eec7f893904.js"></script> 

## Final Thoughts

Zurb [Foundation 6 for Sites](http://foundation.zurb.com/sites/docs/) plugins are a great way to roll your own responsive components and provide missing pieces for your project under a consistent framework.  I hope to have a non-fictitious Zurb datepicker plugin ready soon if there is interest.  I decided to not discuss namespacing and publishing your custom Zurb plugin package to [NPM](https://www.npmjs.com/) at this time.  Please stay tuned for a future post. 

Disclaimer: I am a Foundation fan, user, and minor open-source contributor.

<span class="fi-page-edit size-21"></span> <a href="{{ site.post_source_root }}2016-04-20-zurb-foundation-6-plugins.markdown" target="_blank">Contribute and Fork</a>

{% include disqus.html %}
