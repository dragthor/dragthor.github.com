---
layout: page
title: Developer War Stories and Lifestyle
permalink: /dev-life/
description: "Developer war stories, lifestyle, work environment, coding culture, and consultant tales."
---
<div class="home">
{% include amazon-books.html %}

  <ul class="post-list">
    {% for post in site.posts %}
		{% if post.meta contains 'dev-life' %}
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