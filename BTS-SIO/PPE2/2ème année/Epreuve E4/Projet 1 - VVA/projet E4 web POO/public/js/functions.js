function DisplayForm(typeForm, cdTypeAnim) {
	switch (typeForm) {
		case 'ajouter':
			if(document.getElementById('addAnim').style.display == "none") {
				document.getElementById('addAnim').style.display = "block";
				window.scrollTo(0, 2000);
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

function ajaxRequest() {
	var xhttp = new XMLHttpRequest();
	xhttp.open("POST", "index.php?page=var", true);
	xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
	xhttp.send("data=value");
}
