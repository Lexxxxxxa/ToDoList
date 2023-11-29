function makeAjaxRequest(url, method, data, successCallback, errorCallback) {
    var xhr = new XMLHttpRequest();

    xhr.open(method, url, true);
    xhr.setRequestHeader("Content-Type", "application/json");

    xhr.onload = function () {
        if (xhr.status >= 200 && xhr.status < 300) {
            successCallback(xhr.responseText);
        } else {
            errorCallback(xhr.statusText);
        }
    };

    xhr.onerror = function () {
        errorCallback(xhr.statusText);
    };

    var jsonData = JSON.stringify(data);
    xhr.send(jsonData);
}

var requestData = {
};

makeAjaxRequest('/api/some-endpoint', 'POST', requestData, function (response) {
    console.log('Óñïåøíûé îòâåò:', response);
}, function (error) {
    console.error('Îøèáêà:', error);
});