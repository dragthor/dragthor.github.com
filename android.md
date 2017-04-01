---
redirect_from: "/tag/android/"
layout: page
title: Android Development and Testing
permalink: /android/
description: "Android development, testing, unit testing, espresso, and automated UI testing."
---
{% for post in site.posts %}
{% if post.meta contains 'android' %}
<div class="row">
<div class="small-12 columns">

<h2>
<a class="post-link" href="{{ post.url | prepend: site.baseurl }}">{{ post.title }}</a>
</h2>
• <span class="post-meta">{{ post.date | date: "%b %-d, %Y" }}</span>
<p>

{{ post.excerpt | remove: '<p>' | remove: '</p>' }} <br/><span class="fi-page"></span> <a href="{{ post.url | prepend: site.baseurl }}">Read More...</a>
</p>

</div></div>
{% endif %}
{% endfor %}

{% include signup.html %}