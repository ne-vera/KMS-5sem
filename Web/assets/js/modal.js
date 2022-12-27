let btnOpenModal = document.getElementById('btn-open-modal');
let modal = document.getElementById('wrapper-modal');
let overlay = document.getElementById('overlay');

let inputQuestion = document.querySelector(".question");
let btnOpenAnswer = document.querySelector(".question-button")
let answerBlock = document.querySelector(".wrapper-answer");
let answer = document.querySelector(".answer");

inputQuestion.addEventListener('keypress', function(e){
    if(e.key == 'Enter')
    {
        answerBlock.classList.add('active');
        const answerText = getAnswer(inputQuestion.value);
        answer.innerHTML = answerText;
    }
});

btnOpenModal.addEventListener('click', function() {
    modal.classList.add('active');
});

btnOpenAnswer.addEventListener('click', function() {
    answerBlock.classList.add('active');
    const answerText = getAnswer(inputQuestion.value);
    answer.innerHTML = answerText;
});

function closeModal(){
    modal.classList.remove('active');
    answerBlock.classList.remove('active');
}

overlay.addEventListener('click', closeModal);

var recognizer = new webkitSpeechRecognition();
recognizer.interimResults = true;
recognizer.lang = 'ru-Ru';
recognizer.onresult = function (event) {
    var result = event.results[0][0].transcript;
    console.log(result);
    inputQuestion.value = result + "?";
}

function speech() {
    recognizer.start();
};