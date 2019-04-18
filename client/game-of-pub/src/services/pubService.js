const BASE_URL = "https://localhost:44312/";

export function GetAllPubs() {
    var url = BASE_URL + "api/pubs";

    return fetch(url).then(response => response.json());
}

export function GetPub(id) {
    var url = BASE_URL + "api/pubs/" + id;

    return fetch(url).then(response => response.json());
}