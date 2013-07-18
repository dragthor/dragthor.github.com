import urllib2

url = 'http://graph.facebook.com/southridgecommunitychurch/albums/?fields=name,cover_photo,description,count,likes&limit='

from array import *
a=array('i',[11,51])
for i in a:

    remote = urllib2.urlopen(url + str(i))

    localFile = open('albums-' + str(i) + '.json', 'w')
    localFile.write(remote.read())
    localFile.close()

print('Done and done.')