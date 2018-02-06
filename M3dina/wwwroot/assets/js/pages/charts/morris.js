$(function () {
    getMorris('line', 'line_chart');
    getMorris('bar', 'bar_chart');
    getMorris('area', 'area_chart');
    getMorris('donut', 'donut_chart');
});


function getMorris(type, element) {
    if (type === 'line') {
        Morris.Line({
            element: element,
            data: [{
                'period': '2011 Q3',
                'licensed': 3407,
                'sorned': 2132
            }, {
                    'period': '2017 Q2',
                    'licensed': 2154,
                    'sorned': 3212
                }, {
                    'period': '2016 Q1',
                    'licensed': 3269,
                    'sorned': 2541
                }, {
                    'period': '2015 Q4',
                    'licensed': 3246,
                    'sorned': 2194
                }, {
                    'period': '2014 Q4',
                    'licensed': 3171,
                    'sorned': 2144
                }, {
                    'period': '2013 Q4',
                    'licensed': 3155,
                    'sorned': 3122
                }, {
                    'period': '2012 Q4',
                    'licensed': 3226,
                    'sorned': 1025
                }, {
                    'period': '2011 Q4',
                    'licensed': 3245,
                    'sorned': 1025
                }, {
                    'period': '2010 Q4',
                    'licensed': 3289,
                    'sorned': 1022
                }],
            xkey: 'period',
            ykeys: ['licensed', 'sorned'],
            labels: ['Licensed', 'Off the road'],
            lineColors: ['rgb(125, 210, 61)', 'rgb(55, 150, 225)'],
            lineWidth: 3
        });
    } else if (type === 'bar') {
        Morris.Bar({
            element: element,
            data: [{
                x: '2011 Q1',
                y: 3,
                z: 2,
                a: 3
            }, {
                    x: '2017 Q2',
                    y: 2,
                    z: null,
                    a: 1
                }, {
                    x: '2016 Q3',
                    y: 0,
                    z: 2,
                    a: 4
                }, {
                    x: '2015 Q4',
                    y: 2,
                    z: 4,
                    a: 3
                }],
            xkey: 'x',
            ykeys: ['y', 'z', 'a'],
            labels: ['Y', 'Z', 'A'],
            barColors: ['rgb(125, 125, 250)', 'rgb(236, 192, 15)', 'rgb(85, 203, 140)'],
        });
    } else if (type === 'area') {
        Morris.Area({
            element: element,
            data: [{
                period: '2017 Q1',
                iphone: 2666,
                ipad: 1254,
                itouch: 2647
            }, {
                    period: '2017 Q2',
                    iphone: 2778,
                    ipad: 2294,
                    itouch: 2441
                }, {
                    period: '2016 Q3',
                    iphone: 4912,
                    ipad: 1969,
                    itouch: 2501
                }, {
                    period: '2015 Q3',
                    iphone: 4820,
                    ipad: 3795,
                    itouch: 1588
                }, {
                    period: '2014 Q4',
                    iphone: 15073,
                    ipad: 5967,
                    itouch: 5175
                },{
                    period: '2013 Q4',
                    iphone: 3767,
                    ipad: 3597,
                    itouch: 5689
                }, {
                    period: '2012 Q1',
                    iphone: 6810,
                    ipad: 1914,
                    itouch: 2293
                }, {
                    period: '2011 Q2',
                    iphone: 5670,
                    ipad: 4293,
                    itouch: 1881
                },{
                    period: '2010 Q1',
                    iphone: 10687,
                    ipad: 4460,
                    itouch: 2028
                }, {
                    period: '2009 Q2',
                    iphone: 8432,
                    ipad: 5713,
                    itouch: 1791
                }],
            xkey: 'period',
            ykeys: ['iphone', 'ipad', 'itouch'],
            labels: ['iPhone', 'iPad', 'iPod Touch'],
            pointSize: 1,
            hideHover: 'auto',
            lineColors: ['rgb(254, 191, 15)', 'rgb(25, 161, 183)', 'rgb(134, 139, 239)']
        });
    } else if (type === 'donut') {
        Morris.Donut({
            element: element,
            data: [{
                label: 'Jam',
                value: 25
            }, {
                    label: 'Frosted',
                    value: 40
                }, {
                    label: 'Custard',
                    value: 15
                },{
                    label: 'Jelly',
                    value: 20
                }, {
                    label: 'Sugar',
                    value: 10
                }],
            colors: ['rgb(0,189,209)', 'rgb(137,197,75)', 'rgb(27,138,207)', 'rgb(168,104,224)', 'rgb(255,200,0)'],
            formatter: function (y) {
                return y + '%'
            }
        });
    }
}