/*=============== SCROLL REVEAL ANIMATION ===============*/
const sr = ScrollReveal({
    origin: 'top',
    distance: '60px',
    duration: 2500,
    delay: 400,
    reset: true
})

sr.reveal(`.home__data`)
sr.reveal(`.home__img`, {delay: 500})
/* sr.reveal(`.contact__data`)
sr.reveal(`.contact__social`, {delay:500})
sr.reveal(`.contact__social`, {delay: 600}) */