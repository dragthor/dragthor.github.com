---
layout: post
title: "Introducing Zurb Foundation 6 Plugins "
permalink: /2016-04-20-zurb-foundation-6-plugins/
meta: zurb
published: false
description: "How to make a Zurb Foundation 6 plugin.  What are the ingredients?"
image: http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/zurb-plugin.jpg
---
Bring your own custom component plugins to Zurb Foundation for Sites 6.  As previously mentioned in [What's new in Zurb Foundation 6?](/zurb-foundation-6-whats-new/) plugins help facilitate consistent integration and enable extensibility.  It's helpful to think of plugins this way: Zurb is the electrical outlet that provides framework power.  A Zurb plugin is the ending plug that literally plugs into the outlet.  At the end of the electrical cord could be any type of device (a toaster, a [George Foreman grill](http://amzn.to/1SOK0bY), a lamp, etc.).  Of course these devices (or your plugin) need to follow some predetermined rules, guidelines, and interfaces (three hole vs. two hole or 120V vs. 240V).  This post provides you with the ingredients needed to develop a bare bones responsive plugin using [Zurb Foundation 6 for Sites](http://foundation.zurb.com/sites/docs/). 

## Skeleton Code: What do all plugins have in common? 

At the end of day, Zurb plugins are nothing more than you providing custom CSS, HTML, and Javascript.  For example, a custom Zurb datepicker could be composed of a an input field to receive focus, then dispplay a reveal with three dropdowns (a dropdown for day, month, and year). 

Composition or aggregation of one or more other existing components.  In the traditional object-oriented world A owns B (composition) when B has no meaning or purpose without A.  A uses B (aggregation) when B exists independently from A.  The fictional datepicker previously mentioned above uses composition.  But maybe a custom responsive Zurb grid or chart component would each be independent plugins.  Can a traditional reporting grid be responsive?   Does it even fit in the responsive world?  A Zurb graphical chart sounds like a future idea. Pull request, anyone? 

Javascript is not as strict as C# or Java with interfaces so technically you could not implement these. No compilers, just transpilers and conventions.  One standard convention:  

Plugin methods prefixed with an underscore are considered part of the internal API, which means they could change, break, or disappear without warning. 

Unsure why you wouldn't want your plugin to play nicely with Zurb and other components?  Whether you choose composition or aggregation at minimum your plugin should look like this.  

` constructor(element, options)` - is your plugin constructor.  It initializes and set's up your plugin.  `Foundation.Keyboard.register()` handlers.  And registers your plugin. 

`destroy()` - is your plugin destructor.  And deregisters your plugin. 

`_init()` -  init - re-initialize, reset/remove event listeners, to recalculate position, etc.   

`_events()` - event listeners. onDateSelected, onCancelled, isValid (error msg for 2/31) 

## Plugin Management 

How are they managed by the framework? 

    `registerPlugin` – in core.js 

Populates the _uuids array with pointers to each individual plugin instance. 
Adds the `zfPlugin` data-attribute to programmatically created plugins to allow use of $(selector).foundation(method) calls. 
Also fires the initialization event for each plugin, consolidating repetitive code. 

    `unregisterPlugin` – in core.js 

Removes the plugins uuid from the _uuids array. 
Removes the zfPlugin data attribute, as well as the data-plugin-name attribute. 
Also fires the destroyed event for the plugin, consolidating repetitive code. 

https://gist.github.com/dragthor/8ca90a0cd019c1fcb3f45eec7f893904 

<script src="https://gist.github.com/dragthor/8ca90a0cd019c1fcb3f45eec7f893904.js"></script> 


<span class="fi-page-edit size-21"></span> <a href="{{ site.post_source_root }}2016-04-20-zurb-foundation-6-plugins.markdown" target="_blank">Contribute and Fork</a>

{% include disqus.html %}
