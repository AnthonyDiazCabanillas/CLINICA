var stackedBarChart = null;


function knob() {
    if ($('.knob').length > 0) {
        // El objeto Knob ya existe, destruirlo
        $('.knob').trigger('off.destroy');
    }

    $('.knob').knob({})
    /* END JQUERY KNOB */
}

//function knob() {
//    if ($('.knob').length > 0) {
//        // El objeto Knob ya existe, destruirlo
//        $('.knob').trigger('off.destroy');
//    }

//    // Crear un nuevo objeto Knob
//    $('.knob').knob({
//        // Configuración del objeto Knob
//    });
//    /* Resto de la configuración del knob */
//}

//function stackedBarChart() {
//    var stackedBarChartCanvas = $('#stackedBarChart').get(0).getContext('2d')
//    var areaChartDataX = {
//        labels: ['January', 'February', 'March', 'April', 'May', 'June', 'July'],
//        datasets: [
//            {
//                label: 'Digital Goods',
//                backgroundColor: 'rgba(60,141,188,0.9)',
//                borderColor: 'rgba(60,141,188,0.8)',
//                pointRadius: false,
//                pointColor: '#3b8bba',
//                pointStrokeColor: 'rgba(60,141,188,1)',
//                pointHighlightFill: '#fff',
//                pointHighlightStroke: 'rgba(60,141,188,1)',
//                data: [28, 48, 40, 19, 86, 27, 90]
//            },
//            {
//                label: 'Electronics',
//                backgroundColor: 'rgba(210, 214, 222, 1)',
//                borderColor: 'rgba(210, 214, 222, 1)',
//                pointRadius: false,
//                pointColor: 'rgba(210, 214, 222, 1)',
//                pointStrokeColor: '#c1c7d1',
//                pointHighlightFill: '#fff',
//                pointHighlightStroke: 'rgba(220,220,220,1)',
//                data: [65, 59, 80, 81, 56, 55, 40]
//            },
//        ]
//    }

//    var stackedBarChartData = $.extend(true, {}, areaChartDataX)
//    var temp0 = areaChartDataX.datasets[0]
//    var temp1 = areaChartDataX.datasets[1]
//    stackedBarChartData.datasets[0] = temp1
//    stackedBarChartData.datasets[1] = temp0

//    var stackedBarChartOptions = {
//        responsive: true,
//        maintainAspectRatio: false,
//        scales: {
//            xAxes: [{
//                stacked: true,
//            }],
//            yAxes: [{
//                stacked: true
//            }]
//        }
//    }

//    new Chart(stackedBarChartCanvas, {
//        type: 'bar',
//        data: stackedBarChartData,
//        options: stackedBarChartOptions
//    })
//}

//function generateStackedBarChart(canvasId, labels, datasets) {
//    var stackedBarChartCanvas = document.getElementById(canvasId).getContext('2d');

//    if (stackedBarChart) {
//        stackedBarChart.destroy();
//    }

//    var stackedBarChartData = {
//        labels: labels,
//        datasets: datasets
//    };

//    var stackedBarChartOptions = {
//        responsive: true,
//        maintainAspectRatio: false,
//        scales: {
//            xAxes: [{
//                stacked: true,
//            }],
//            yAxes: [{
//                stacked: true
//            }]
//        }
//    };


//    stackedBarChart = new Chart(stackedBarChartCanvas, {
//        type: 'bar',
//        data: stackedBarChartData,
//        options: stackedBarChartOptions
//    });
//}

function generateStackedBarChart(canvasId, labels, datasets) {
    var stackedBarChartCanvas = document.getElementById(canvasId).getContext('2d');

    // Destruye el gráfico existente si hay alguno
    if (stackedBarChart) {
        stackedBarChart.destroy();
    }

    var stackedBarChartData = {
        labels: labels,
        datasets: datasets
    };

    var stackedBarChartOptions = {
        responsive: true,
        maintainAspectRatio: false,
        scales: {
            xAxes: [{
                stacked: true,
            }],
            yAxes: [{
                stacked: true
            }]
        },
        tooltips: {
            mode: 'single', // Modo de visualización del tooltip    
            callbacks: {
                label: function (tooltipItem, data) {
                    // Personaliza el contenido del tooltip
                    var datasetLabel = data.datasets[tooltipItem.datasetIndex].label || '';
                    var datasetCantidad = data.datasets[tooltipItem.datasetIndex].data || '';
                    var CantidadValues = datasetCantidad.length > 0 ? datasetCantidad[tooltipItem.index] : '';

                    var datasetSoles = data.datasets[tooltipItem.datasetIndex].tooltip.callbacks.soles || [];
                    var solesValue = datasetSoles.length > 0 ? datasetSoles[tooltipItem.index] : '';
                    var formattedSolesValue = parseFloat(solesValue).toLocaleString('es-PE', {
                        style: 'currency',
                        currency: 'PEN'
                    });
                    return datasetLabel + ': Cantidad: ' + CantidadValues + ', Soles: ' + formattedSolesValue;
                }
            }
        }
    };

    // Crea un nuevo gráfico de barras apiladas
    stackedBarChart = new Chart(stackedBarChartCanvas, {
        type: 'bar',
        data: stackedBarChartData,
        options: stackedBarChartOptions
    });
}
