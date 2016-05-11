---
redirect_from: "/tag/windows-app/"
layout: page
title: Windows Universal App Development and Testing
permalink: /windows-app/
description: "Windows 10 Universal application development and testing."
---
{% include amazon-books.html %}

<div class="home">



  <ul class="post-list">
    {% for post in site.posts %}
		{% if post.meta contains 'windows-app' %}
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