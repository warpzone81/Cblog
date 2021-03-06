﻿/*global angular*/

angular.module('postdb', ['ngResource'])
    .factory('PostDb', function ($resource) {
        "use strict";
        var PostDb = $resource('/api/Post/:id', {},
            {
                query: { method: 'GET', isArray: true },
                get: { method: 'GET' },
                update: { method: 'PUT' },
                save: { method: 'POST' },
                destroy: { method: 'DELETE' }
            });
        PostDb.prototype.update = function (cb) {
            return PostDb.update({ id: this.PostId },
                angular.extend({ }, this, { PostId: this.PostId }), cb);
        };

        PostDb.prototype.destroy = function (cb) {
            return PostDb.destroy({ id: this.PostId },
                angular.extend({ }, this, { PostId: this.PostId }), cb);
        };

        return PostDb;
    });