//* YOUR CUSTOMIZED JAVASCRIPT *//

const activateFormBtns = document.querySelectorAll('[person-form-btn]');
activateFormBtns.forEach(btn => {
    const id = btn.getAttribute('person-form-btn');
    const form = document.querySelector(`[person-additional-form='${id}']`);

    btn.addEventListener('click', () => {
        const isHidden = !form.hidden;
        form.hidden = isHidden;
        btn.innerHTML = isHidden ? 'Дополнить' : 'Скрыть';
    })
})