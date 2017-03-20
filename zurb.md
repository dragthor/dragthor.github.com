---
redirect_from: "/tag/zurb/"
layout: page
title: Zurb Foundation Development
permalink: /zurb/
description: "Zurb Foundation development, learning, and testing.  Zurb for Sites, Email, and mobile Apps."
---
<div class="home">



  <ul class="post-list">
    {% for post in site.posts %}
		{% if post.meta contains 'zurb' %}
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

{% include signup.html %}