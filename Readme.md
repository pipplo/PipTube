#PipTube v0.1 #

This is a very simple plugin that lets you access YouTube leanback from within MediaCenter. It pretty much just opens youtube.com/leanback in a media center browser window.

I made this plugin because I wanted to be able to access my own YouTube playlists from media center so that I could save videos on my pc or phone and watch them later on my TV.  

The leanback interface is easily navigated with the up, down, left, and right buttons.  Ok can be used to make selections or play/pause a movie.

##Known Issues 

* Certain media center buttons like 'Back' are linked to keyboard shortcuts. Pressing Back on your remote will exit the plugin, NOT go back in leanback.

* You can use the keyboard to search, but since 'Backspace' is used by Media Center to go back a menu you can't really use Backspace whiel in leanback.  I hope to fix this

* There is some problem on MediaCenter 64 bit where Leanback will only work properly once.  If the flash plugin is cached then you will get an error message.  To workaround this the plugin will look for a  watch_as3*.swf file in the temporary internet files directory and delete it.

##Installation

* Download PipTubeSetup.msi
* Run the installer
* Open Media Center and Navigate to Extras Library
* Run PipTube
* You may see some dialogs from Media Center.  Answer those
* If leanback does not work you may need to install the latest version of flash.  Open IE and install flash then try again.

'''At this point you should see YouTube leanback. Logging in after this is optional'''

###Logging In
* Select the login option
* Use a keyboard to fill in your login details
** ''After logging in you may see an error message. If you do exit PipTube then re-run PipTube. This error is because of the issue with the flash file''
* You should now be able to access your own playlists

