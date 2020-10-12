function verifPsw() {
	var password1 = document.getElementById("psw");
	var password2 = document.getElementById("psw2");

	if(password1.value == password2.value && password1.value != "") {
		password1.style.border = "1px solid green";
		password2.style.border = "1px solid green";
	}
	else if (password1.value == "" && password2.value == "") {
		password1.style.border = "";
		password2.style.border = "";
	}
	else {
		password1.style.border = "1px solid red";
		password2.style.border = "1px solid red";
	}
}

function sendNewMail() {
	var xhttp = new XMLHttpRequest();
	xhttp.open("POST", "index.php?page=verifie", true);
	xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
	xhttp.send("repost=mail");
}
