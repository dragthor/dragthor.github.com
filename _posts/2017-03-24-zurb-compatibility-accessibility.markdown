---
layout: post
title: "Zurb Foundation 6 Compatibility and Accessibility"
permalink: /zurb-foundation-compatibility-accessibility/
meta: zurb
published: true
image: http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/lego-guys.png
---
Accessibility and compatibility are difficult to write about.  Neither are a day in, day out concern for the average developer.  Most of the time we do not worry about either until the very end of a project or worse, after a release to production.

![alt text]({{ page.image }} "Zurb Foundation 6 Compatibility and Accessibility")

## Browser Compatibility

Compatibility concerns are not specific to the [Foundation 6](http://foundation.zurb.com/) framework.  All other frameworks must deal with quirks and lagging vendors too (looking in Apple’s direction).  And we, as developers, must also deal with this stuff.  It comes with the job.

Let’s cut to the chase. In my cynical web developer voice, what’s supposed to work?  Answer - the last two versions of Chrome, Firefox, Safari, Opera, Mobile Safari, IE Mobile (older Windows Phone and Windows CE devices), IE 9+, and the Android web browser 2.3+.  How many people still use the old Android browser?  Some native apps might have it embedded, but since Android 4.4 the default browser has been based on Chromium.  Plus, all recent Android device users utilize mobile Chrome (and so do a lot of Apple device users too).  Check your visitor’s browser usage.  The 1% still using IE8 or Android 2.2 are probably not worth worrying about.  However, this is your decision. 

### Internet Explorer 8

What does not work?  IE8 doesn't support the `box-sizing: border-box` CSS property.  Foundation uses it to apply gutters to columns in their 12-column grid system.  In designer speak, a gutter is a “lane” of padding or margin between cells or columns.  I like to visualize a bowling alley lane with gutters on each side.  Gutters in Foundation 6 are responsive and increase for larger viewports.  They also provide space between the edge of a grid and the edge of the page.

IE8 is not ES5-compatible.  Foundation transpiles ES6 down to ES5 with [Babel](https://babeljs.io/).  However, IE8 lacks some ECMAScript 5 features used in plugins.  Per Microsoft, [support ended for older versions of IE](https://www.microsoft.com/en-us/WindowsForBusiness/End-of-IE-support) on January 12th, 2016.

### Internet Explorer 9

My Zurb Foundation 5 and 6 framework experience has taught me that IE9 can be finicky.  But it’s not the framework's problem, its IE's problem for not supporting HTML5 attributes like `placeholder` where you need to use some type of fallback polyfill.

### Media Queries

Finally, be aware that browsers that do not support media queries will render your website as small (mobile).  This should be fine as you’re ideally developing and designing from a mobile-first attitude and perspective.  Hey, at least your website will still function and be usable.

## Accessibility

Zurb’s Foundation is not only cross-device responsive, but accessible to everyone.  If you’re a consultant or freelancer, it's nice to know your framework is accessibility friendly.  Government projects usually require it.

Assistive devices like a screen reader make interacting with your website easier for the visually impaired.  My mom has vision problems.  I’ve seen firsthand that even with decent ARIA implemented, it’s still cumbersome to navigate, use menus, interact with accordions, and know visibility state for elements on the page.  UI updates, transitions, animations, and `<canvas/>` do not work well either.

Foundation 6 uses [what-input](https://github.com/ten1seven/what-input) to determine the current input method (mouse, keyboard, or touch) “to disable outlines for mouse users, but not keyboard users, who need the outline to know what element on the page has focus.”  Here is the Sass mixin definition that you can use in your own components:

{% highlight css %}
@mixin disable-mouse-outline {
  [data-whatinput='mouse'] & {
    outline: 0;
  }
}
{% endhighlight %}

All Foundation components are keyboard-accessible and screen reader-friendly.  Checkout the [source code](https://github.com/zurb/foundation-sites) to see that relevant ARIA HTML attributes are baked into the plugins.  However, it’s important to remember that ultimately you own the markup. Whether it’s `aria-hidden` or the no brainer `img alt` text.  Want to show or hide an element based on the aria-hidden state?  Here you go:

{% highlight css %}
[aria-hidden=true] {
    visibility: hidden;
}
{% endhighlight %}

I recommend following standard accessibility principles (see [WCAG](https://www.w3.org/TR/WCAG20/) or [MDN](https://developer.mozilla.org/en-US/docs/Web/Accessibility) documentation) for your website.  And don’t worry.  The extra ARIA HTML attributes won’t significantly increase your page size.  I am sure your webserver is gzip compressing them anyway.  The additional attributes are probably the least of your web performance worries (see [death by a thousand tiny cuts](/web-page-performance-death-by-a-thousand-tiny-cuts/)).

{% include signup.html %}

{% include disqus.html %}
