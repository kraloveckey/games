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

String.prototype.parseQueries = function (params) {
    return this.length > 0 ? [0].map.call(this.replace(/(^\?)/,'').split("&"), function(query) {
        return query = query.split("="), this[query[0]] = isNaN(query[1]) ? query[1] : +query[1], this;
    }, params || {})[0] : params || {};
}

document.addEventListener("DOMContentLoaded", function() {
    var params = (document.location.search || "").parseQueries({ size: 7 });

    if (window.innerWidth < 600) {
        params.size = 6;
        params.combo = params.combo || 3;
        params.count = params.count || 2;
    }

    new Gear(params);
});
