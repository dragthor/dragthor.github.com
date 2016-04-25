---
layout: page
title: Unit Testing
permalink: /unit-testing/
description: "Unit testing produces better code.  Better design.  Android and javascript unit testing."
---
<div class="home">
  <ul class="post-list">
    {% for post in site.posts %}
		{% if post.meta contains 'unit-testing' %}
		  <li>
			<span class="post-meta">{{ post.date | date: "%b %-d, %Y" }}</span>

			<h2>
			  <a class="post-link" href="{{ post.url | prepend: site.baseurl }}">{{ post.title }}</a>
			</h2>

			<p>
				{{ post.excerpt | remove: '<p>' | remove: '</p>' }} <a href="{{ post.url | prepend: site.baseurl }}">Read More...</a>
			</p>
		  </li>
		{% endif %}
    {% endfor %}
  </ul>
  
  
</div>

{% include adsense.html %}