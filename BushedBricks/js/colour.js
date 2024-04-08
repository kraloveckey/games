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

var Colour = function () {
    this.list = ["#FFE082", "#FF8A65", "#AED581", "#81D4FA", "#A1887F"]; // yellow, red, green, blue, brown
    this.weight = [0.24, 0.24, 0.24, 0.24, 0.04];
}

Colour.prototype.random = function () {
    var index = Math.floor(Math.random() * this.list.length);

    return this.list[index];
}

Colour.prototype.randomByWeight = function () {
    var data = this.weight.reduce(function (prev, curr, i) {
        return prev.sum < prev.rand ? { sum: prev.sum + curr, index: i, rand: prev.rand } : prev;
    }, { sum: 0, index: -1, rand: Math.random() });

    return this.list[data.index];
}
