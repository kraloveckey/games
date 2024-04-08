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

var Shelter = function () {
    this.list = ["#FFE082", "#AED581", "#81D4FA", "#FF8A65"];
}

Shelter.prototype.random = function () {
    var index = Math.floor(Math.random() * this.list.length);

    return this.list[index];
}
