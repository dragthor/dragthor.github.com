---
layout: page
title: "Web, Javascript, CSS, and App Performance"
permalink: /performance/
description: "Web page performance.  Web app, javascript, and CSS performance.  Mobile android performance."
---
{% for post in site.posts %}
{% if post.meta contains 'performance' %}
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