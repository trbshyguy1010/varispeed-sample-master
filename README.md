# Varispeed NAudio Playback Sample

This sample shows how to achieve varispeed playback in NAudio by making use of the [SoundTouch library](http://www.surina.net/soundtouch/README.html). It can modify playback speed on its own, or tempo which maintains the same pitch at any speed.

The `VarispeedSampleProvider` implements NAudio's `ISampleProvider` and calls into SoundTouch to perform the speed change. Read more about this project [here](http://markheath.net/post/varispeed-naudio-soundtouch)

## This project is still in development stages

**This project is an old attempt of me trying to make a music player that has :**
1. Discord RPC
1. Variable Song Speeds
1. BPM detection

**But fails to do so due to some bugs that I still don't have the time to fix**

If you ever want to contribute to the project, please contact me at my Discord
