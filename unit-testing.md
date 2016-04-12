---
layout: page
title: Unit Testing
permalink: /unit-testing/
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

			{{ post.excerpt }}
		  </li>
		{% endif %}
    {% endfor %}
  </ul>
  
  {% include adsense.html %}
</div>