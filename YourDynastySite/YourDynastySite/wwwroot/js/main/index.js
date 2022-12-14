document.getElementById('form-memorial-submit')?.addEventListener('click', async (ev) =>
{
    var form = ev.currentTarget.parentNode;
    const data = new URLSearchParams();
    for (const pair of new FormData(form)) {
        data.append(pair[0], pair[1]);
    }

    showSpiner();

    await fetch('/api/search/memorial?' + data, { method: "GET" }).then(async (res) => {
        var container = document.getElementById('memorial-container');
        container.innerHTML = await res.text();
        initPager();
        hideSpiner();
    });
});

function initPager() {
    document.getElementById('pager')?.addEventListener('click', async (ev) => {
        var form = document.getElementById('memorial-form');
        const data = new URLSearchParams();
        for (const pair of new FormData(form)) {
            data.append(pair[0], pair[1]);
        }

        var pageElem = document.getElementById('Page');
        if (pageElem) {
            pageElem.value = (parseInt(pageElem.value, 10) ?? 1) + 1;
            data.append("Page", pageElem.value);
        }

        showSpiner();

        await fetch('/api/search/memorial?' + data, { method: "GET" }).then(async (res) => {
            var container = document.getElementById('persons-container');
            container.innerHTML += await res.text();
            hideSpiner();
        });
    });
}

document.getElementById('submit_photo')?.addEventListener('click', (ev) => {
    showSpiner();
    initFaceInfo();
});

function initFaceInfo() {
    document.querySelectorAll('.face_info')?.addEventListener('click', (ev) => {
        showSpiner();
    });
}

function hideSpiner() {
    document.querySelectorAll("#spinner-area")?.forEach(elem => {
        elem.style.display = 'none';
    });
}

function showSpiner() {
    var elem = document.querySelector("#spinner-area");
    if (elem) {
        elem.style.display = 'block';
    }
}