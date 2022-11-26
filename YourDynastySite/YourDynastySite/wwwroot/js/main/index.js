document.getElementById('form-memorial-submit').addEventListener('click', async (ev) =>
{
    var form = ev.currentTarget.parentNode;
    const data = new URLSearchParams();
    for (const pair of new FormData(form)) {
        data.append(pair[0], pair[1]);
    }

    var items = await fetch('https://localhost:7133/api/search/memorial?' + data,
        {
            method: "GET",
            headers: {
                'Content-Type': 'application/json'
            },
        }).then(async (res) => {
            return await res.json();
    }).catch(() => '');

    var container = document.getElementById('memorial-container');
    container.innerHTML = items;
});