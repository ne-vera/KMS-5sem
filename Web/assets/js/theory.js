function replacementTextForImage(spanId, text,  path) {
    document.getElementById(spanId).innerHTML = '<img onmouseout="replacmentImageForText( \''+spanId+ '\' , \'' + text + '\')" style="display: inline" src="'+path+'"/>'
}
function replacmentImageForText(id, text){
    document.getElementById(id).innerHTML = text;
}
function increaseImg(event, size){
    event.currentTarget.style.width += size;
}

function decreaseImg(event){
    event.currentTarget.style.width = '';
}
