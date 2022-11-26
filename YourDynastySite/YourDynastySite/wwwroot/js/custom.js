//* YOUR CUSTOMIZED JAVASCRIPT *//

const activateFormBtns = document.querySelectorAll('[person-form-btn]');
activateFormBtns.forEach(btn => {
    const id = btn.getAttribute('person-form-btn');
    const form = document.querySelector(`[person-form-btn=${id}]`);

    btn.addEventListener('click', () => {
        const isHidden = form.hidden;
        form = !isHidden;
        btn.innerHTML = isHidden ? 'Дополнить' : 'Скрыть';
    })
})