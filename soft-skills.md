---
layout: page
title: Professional Developer Soft Skills
permalink: /soft-skills/
description: "Professional developer soft skills for sometimes socially ackward nerds and geeks."
---
<div class="home">

{% include amazon-books.html %}

  <ul class="post-list">
    {% for post in site.posts %}
		{% if post.meta contains 'soft-skills' %}
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