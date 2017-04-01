---
redirect_from: "/tag/windows-app/"
layout: page
title: Windows Universal App Development
permalink: /windows-app/
description: "Windows 10 Universal application development and testing."
---
{% for post in site.posts %}
{% if post.meta contains 'windows-app' %}
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