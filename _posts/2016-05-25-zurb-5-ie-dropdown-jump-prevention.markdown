---
layout: post
title: "Zurb 5 IE Dropdown Jump Prevention"
permalink: /zurb-foundation-5-ie-dropdown-jump-prevention/
meta: zurb
published: true
description: "Zurb Foundation 5 IE (internet explorer) dropdown jump prevention."
image: http://abe90238e3b628565257-c47b312812e6878374960f5d0b7661c9.r73.cf1.rackcdn.com/zurb-6.png
---
Internet Explorer likes to "jump" the user into position when jQuery's `.focus()` is called within a [Zurb 5](http://foundation.zurb.com/sites/docs/v/5.5.3/) dropdown.  I don't like this.  Notice in the video below that when the dropdown is positioned at the bottom of the screen, and the user selects a dropdown, their positioning "jumps" up.  And then the dropdown disappears (this is a separate unrelated `scroll` handler issue).

<div class="js-video [vimeo, widescreen]">
<iframe width="560" height="315" src="https://www.youtube.com/embed/OmuSAKOMjcQ?list=PLx-BRAFWgvyNCPrXLTvfmE4cNSPLhOKgp" frameborder="0" allowfullscreen></iframe>
</div>

The jumping behavior seems to only be an issue with IE.  Firefox, Safari, and Chrome do not have the weird `.focus()` issue.  It's not hard to see that Microsoft is trying to center the user within the `window`.  Pretty reasonable for some situations, yet it's not what I want.  I desire consistency among IE, Firefox, Safari, and Chrome.

The fix?  Simply do not call `.focus()`. View the [pull request](https://github.com/zurb/foundation-sites/pull/8885/files).  I added an additional setting named `no_focus` defaulting to the current behavior.  A developer can optionally override it when declaring the Zurb dropdown in HTML markup: `data-options="no_focus:true"`.

We can grab a reference to the dropdown's instance settings inside the `open` function like this:

{% highlight javascript %}
var settings = target.data(this.attr_name(true) + '-init') || this.settings;
{% endhighlight %}

And then decide to avoid the focus:

{% highlight javascript %}
if (settings.no_focus === false) { dropdown.focus(); }
{% endhighlight %}

Hurray!  No more jumping.  The video below demonstrates the desired behavior:

<div class="js-video [vimeo, widescreen]">
<iframe width="560" height="315" src="https://www.youtube.com/embed/D5BbHLIG4cE?list=PLx-BRAFWgvyNCPrXLTvfmE4cNSPLhOKgp" frameborder="0" allowfullscreen></iframe>
</div>

## Final Thoughts

Browser quirks are still prevalent.  Fortunately, [Zurb Foundation 5](http://foundation.zurb.com/sites/docs/v/5.5.3/) is still alive, heavily used, and supported by the open-source community.  

Disclaimer: I am a Foundation fan, user, and minor open-source contributor.   And yes, I work for a company that sells bras.

{% include signup.html %}

{% include disqus.html %}
