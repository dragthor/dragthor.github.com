---
layout: post
title: "Introducing Zurb Foundation 6 Plugins "
permalink: /zurb-foundation-6-plugins/
meta: zurb
published: false
description: "How to make a Zurb Foundation 6 plugin.  What are the ingredients?  Boilerplate javascript code functions."
image: http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/zurb-plugin.jpg
---
Zurb [Foundation for Sites 6](http://foundation.zurb.com/sites/docs/) allows you to design and develop your own custom responsive plugins.  As previously mentioned in [What's new in Zurb Foundation 6](/zurb-foundation-6-whats-new/), plugins help facilitate consistent integration and enable extensibility.  Foundation comes with several out of the box plugins such as accordion, dropdown, menu, reveal, slider, and tooltips.  However, sometimes these are not enough.  Your project or client requires more functionality than Zurb believes is not general enough to include in the base framework.  This is fair and most frameworks work this way, at least in the beginning.  [jQuery](http://jquery.com/), [Java](http://www.java.com/), and [Microsoft .NET](https://www.microsoft.com/net/) have ballooned in size with features that most of us never use.  But I digress. 

It's helpful to think of plugins using this analogy: Zurb is an electrical outlet that provides responsive framework power.  A Zurb plugin is the pronged ending plug that literally "plugs" into this outlet.

At the end of an electrical cord in your house, there could be any type of interchangeable device (a toaster, a [George Foreman grill](http://amzn.to/1SOK0bY), a lamp, etc.).  You can substitute any device because they expect to plug into any standardized outlet.

Similar to household devices, Zurb plugins need to follow some predetermined rules, standardized guidelines, expectations, and interfaces (three hole vs. two hole and 120V vs. 240V).  Plug a device expecting to receive 120V into a 240V outlet and things go bad (fire).  Fortunately, this is software and your plugin will just not work properly.  This post explains the ingredients needed to develop a responsive plugin using Zurb Foundation 6 for Sites. It's less painful than you might think.

![alt text]({{ page.image }} "Zurb Foundation 6 plugin")

## Boilerplate Skeleton Code

What do all plugins have in common?  And what are they made of?  At the end of day, creating Zurb plugins are nothing more than custom CSS, HTML, and Javascript.  You can even wrap or extend existing components.  For example, a custom Zurb datepicker could be composed of an input field to receive focus, then display a `reveal` with three dropdowns (one for day, month, and year) as shown here:

<script src="https://gist.github.com/dragthor/0cea3539e5eca54dc0f9fca0b82f5f48.js"></script>

The fictional datepicker above aggregates one or more existing components.  The `reveal` can exist, have purpose, and have meaning idependently from the datepicker.  In the traditional object-oriented programming world this is aggregation.  A custom Zurb plugin that owns or wraps another component that has no meaning or purpose without it, would be an example of composition. 

Maybe a custom responsive Zurb grid or chart component would each be independent plugins?  Can a traditional reporting grid be responsive?  Does it even fit in the responsive world?  A Zurb graphical chart sounds like a future idea. [Pull request](https://github.com/zurb/foundation-sites/pulls), anyone? 

Javascript is not as strict as C# or Java with interfaces, so technically you could not implement these. No compilers, just transpilers and conventions.  One standard convention:  

Plugin methods prefixed with an underscore are considered part of the internal API, which means they could change, break, or disappear without warning. 

Unsure why you wouldn't want your plugin to play nicely with Zurb and other components?  Whether you choose composition or aggregation at minimum your plugin should contain these methods:  

` constructor(element, options)` is your plugin constructor.  It initializes and sets up your plugin.  

`Foundation.Keyboard.register()` handlers.  And registers your plugin. 

`destroy()` - is your plugin destructor.  And unregisters your plugin. 

`_init()` -  init - re-initialize, reset/remove event listeners, to recalculate position, etc.   

`_events()` - event listeners. onDateSelected, onCancelled, isValid (error msg for 2/31) 

## Plugin Management 

How are they managed by the framework? 

`registerPlugin` – in core.js 

Populates the _uuids array with pointers to each individual plugin instance. 
Adds the `zfPlugin` data-attribute to programmatically created plugins to allow use of $(selector).foundation(method) calls.  Also fires the initialization event for each plugin, consolidating repetitive code. 

`unregisterPlugin` – in core.js 

Removes the plugins uuid from the _uuids array. 
Removes the `zfPlugin` data attribute, as well as the data-plugin-name attribute. 
Also fires the destroyed event for the plugin, consolidating repetitive code. 

<script src="https://gist.github.com/dragthor/8ca90a0cd019c1fcb3f45eec7f893904.js"></script> 

## Final Thoughts

Zurb [Foundation 6 for Sites](http://foundation.zurb.com/sites/docs/) plugins are a great way to roll your own responsive components and provide any missing pieces for your project under a consistent framework.

Disclaimer: I am a Foundation fan, user, and minor open-source contributor.

<span class="fi-page-edit size-21"></span> <a href="{{ site.post_source_root }}2016-04-20-zurb-foundation-6-plugins.markdown" target="_blank">Contribute and Fork</a>

{% include disqus.html %}
