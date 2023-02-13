async function openCacheStorage() {
    return await window.caches.open("Blazor School");
}

function createRequest(url, method, body = "") {
    let requestInit =
    {
        method: method
    };

    if (body != "") {
        requestInit.body = body;
    }

    let request = new Request(url, requestInit);

    return request;
}