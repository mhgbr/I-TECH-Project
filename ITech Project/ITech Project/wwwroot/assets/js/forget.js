﻿let inputField = document.querySelector(".login-inputs input[type='email']")
let EmailSent = document.querySelector(".Email-sent")
let subButton = document.querySelector(".b")

console.log("ahmed");

subButton.onclick = () => {
    if (inputField.value !== '') {


        EmailSent.innerHTML = '';
        let EmailSentText = document.createElement("p")
        EmailSentTextContent = document.createTextNode(`We have sent an email to: ${inputField.value}`)

        EmailSentText.appendChild(EmailSentTextContent)

        EmailSent.appendChild(EmailSentText)
        EmailSent.style.marginTop = "5%";
        setTimeout(() => {
            EmailSent.style.marginTop = "0";
            setTimeout(() => {
                window.location.replace("resetPassword")
            }, 1000)
        }, 2000)


    }
}
