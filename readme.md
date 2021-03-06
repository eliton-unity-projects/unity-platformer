# unity-platformer [![Travis Status](https://secure.travis-ci.org/llafuente/unity-platformer.png?branch=master)](http://travis-ci.org/llafuente/unity-platformer) [![Appveyor Status](https://ci.appveyor.com/api/projects/status/github/llafuente/unity-platformer?branch=master&svg=true)](https://ci.appveyor.com/project/llafuente/unity-platformer)



===

Based on https://github.com/SebLague/2DPlatformer-Tutorial evolve
in it's own beast.

This project is 5.5, I cannot garantee 5.4 compatibility of Assets but code
should be OK as unit-test pass on 5.4

## API & documentation & Installation

[unity-platformer API](http://llafuente.github.io/unity-platformer/)

## Features

Tiles (Assets/UnityPlatformer/Scripts/Tiles/)

* Moving platforms
* One way platforms (all four directions)
* Ladders
* Boxes (movable)
* Jumpers
* Ropes
* Item (Pickable / Usable)
* Tracks
* Liquid (bouyancy, not inside water yet)


Artificial inteligence (Assets/UnityPlatformer/Scripts/AI/)

* Patrol
* Projectiles
* Jumper


Character actions (Assets/UnityPlatformer/Scripts/Character/Actions/)

* Melee attacks
* Wallstick/WallJump
* Push boxes
* Water (liquid) bouyancy
* Climb/Descent Slopes
* Crounch
* Slip down big slopes
* Use items
* ...


Input (Assets/UnityPlatformer/Scripts/Input/)
* Keyboard / mouse (unity input)
* Wii pad
* CnControls


## Known issues

[https://github.com/llafuente/unity-platformer/labels/bug](https://github.com/llafuente/unity-platformer/labels/bug)

## TODO

[https://github.com/llafuente/unity-platformer/issues?q=is%3Aissue+is%3Aopen+label%3Aenhancement](https://github.com/llafuente/unity-platformer/issues?q=is%3Aissue+is%3Aopen+label%3Aenhancement)

## Caveats

[https://github.com/llafuente/unity-platformer/labels/caveat](https://github.com/llafuente/unity-platformer/labels/caveat)


## Hotswapping

`unity-platformer` support (mostly) hotswapping.

There are some limitations, like the character current actions is lost: Example: If character is grabbing will fall.

# License

License is MIT Copyright © 2016 Luis Lafuente Morales <llafuente@noboxout.com>

Except a few files that are shared with Sebastian (https://github.com/SebLague)
