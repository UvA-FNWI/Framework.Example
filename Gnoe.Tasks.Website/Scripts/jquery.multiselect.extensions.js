(function ($, undefined) {

    $.widget("ech.multiselect", $.ech.multiselect, {
        getSelectedIndexes: function () {
            var indexes = new Array();
            inputs = this.menu.find('input');
            inputs.each(function (i, v) {
                if (jQuery(this).is(':checked'))
                    indexes.push(i);
            });
            return indexes;
        },

        getSelectedIndexesStringyfied: function () {
            var ind = this.getSelectedIndexes();
            //if (ind.length == 1) {
            //    return this.menu.find('input')[ind[0]].value;
            //}
            return JSON.stringify(ind);
        }

    });

})(jQuery);

