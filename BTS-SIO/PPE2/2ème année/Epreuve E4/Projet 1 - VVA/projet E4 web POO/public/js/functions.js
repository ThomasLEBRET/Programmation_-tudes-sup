function DisplayForm(typeForm, cdTypeAnim) {
	switch (typeForm) {
		case 'ajouter':
		if(document.getElementById('addAnim').style.display == "none") {
			document.getElementById('addAnim').style.display = "block";
		} else {
			document.getElementById('addAnim').style.display = "none";
		}
		break;
		case 'modifier':
		if(document.getElementById("update"+cdTypeAnim).style.display == "none") {
			document.getElementById("update"+cdTypeAnim).style.display = "block";
			document.getElementById("delete"+cdTypeAnim).style.display = "none";
			document.getElementById('addAnim').style.display = "none";
		} else {
			document.getElementById("update"+cdTypeAnim).style.display = "none";
		}
		break;
		case 'supprimer':
		if(document.getElementById("delete"+cdTypeAnim).style.display == "none") {
			document.getElementById("delete"+cdTypeAnim).style.display = "block";
			document.getElementById("update"+cdTypeAnim).style.display = "none";
			document.getElementById('addAnim').style.display = "none";
		} else {
			document.getElementById("delete"+cdTypeAnim).style.display = "none";
		}
		break;
	}
}

function DisplayFormActi(typeBtn, noAct) {
	switch (typeBtn) {
		case "modifier":
		if(document.getElementById("update"+noAct).style.display == "none") {
			document.getElementById("update"+noAct).style.display = "block";
			document.getElementById("delete"+noAct).style.display = "none";
		} else {
			document.getElementById("update"+noAct).style.display = "none";
		}
		break;
		case "supprimer":
		if(document.getElementById("delete"+noAct).style.display == "none") {
			document.getElementById("delete"+noAct).style.display = "block";
			document.getElementById("update"+noAct).style.display = "none";
		} else {
			document.getElementById("delete"+noAct).style.display = "none";
		}
		break;
	}
}
