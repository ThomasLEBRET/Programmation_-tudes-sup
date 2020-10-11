var numForm = 0;

function choisiFormulaire(nbr) {
	switch(nbr) {
		case 0:
		var dataForm = document.forms["form1"].elements;
		alert("Donnée bien ajoutée au CV");
		break;
		case 1:
		var dataForm = document.forms["form2"].elements;
		alert("Donnée bien ajoutée au CV");
		break;
		case 2:
		var dataForm = document.forms["form3"].elements;
		alert("Donnée bien ajoutée au CV");
		break;
		case 3:
		var dataForm = document.forms["form4"].elements;
		alert("Donnée bien ajoutée au CV");
		break;
		case 4:
		var dataForm = document.forms["form5"].elements;
		alert("Donnée bien ajoutée au CV");
		break;
		default:
		alert("Erreur inattendue !");
		break;
	}
	return dataForm;
}

function prochainFormulaire() {
	var precedent = document.getElementById("precedent");
	var suivant = document.getElementById("suivant");
	var dataForm = document.getElementsByTagName("form");
	dataForm[numForm].style.display = "none";
	if(numForm < 4) {
		dataForm[numForm + 1].style.display = "";
		numForm++;
	}
	if(numForm > 0){
		precedent.style.display = "";
		suivant.style.display = "";
	}
	if (numForm == 4) {
		precedent.style.display = "";
		suivant.style.display = "none";
	}
}

function precedentFormulaire() {
	var precedent = document.getElementById("precedent");
	var suivant = document.getElementById("suivant");
	var dataForm = document.getElementsByTagName("form");
	dataForm[numForm].style.display = "none";
	if(numForm <= 4) {
		dataForm[numForm - 1].style.display = "";
		numForm--;
	}
	if(numForm == 0) {
		precedent.style.display = "none";
		suivant.style.display = "";
	}
	if(numForm > 0) {
		precedent.style.display = "";
		suivant.style.display = "";
	}
}

function getExperience(numForm) {
	var dataForm = choisiFormulaire(numForm);
	var elemName = new Array();
	var elemValue = new Array();
	for(var i = 0; i < dataForm.length; i++) {
		elemName.push(dataForm[i].name);
	}
	for(var i = 0; i < dataForm.length; i++) {
		elemValue.push(dataForm[i].value)
	}
	var request = "";
	for(var i = 0; i < dataForm.length; i++) {
		if(i < dataForm.length - 1){
			request = request + elemName[i] + "=" + elemValue[i] + "&";
		}
		else {
			request = request + elemName[i] + "=" + elemValue[i];
		}
	}
	requete(request);
}

function requete(request) {
	var xhttp = new XMLHttpRequest();
	xhttp.open("POST", "index.php?page=formulaire");
	xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
	xhttp.send(request);
}
