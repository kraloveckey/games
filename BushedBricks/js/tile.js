/*
 *  "Bushed Bricks" JavaScript Game
 *  source code  : https://github.com/kraloveckey/games/BushedBricks
 *
 *  Copyright 2017, kraloveckey
 *  GitHub : https://github.com/kraloveckey/
 *
 *  Licensed under the MIT license:
 *  http://www.opensource.org/licenses/MIT
 */

var Tile = function (colour) {
    this.colour = colour;
    this.combo = 1;
    this.lifetime = -1;
    this.merged = false;
}
