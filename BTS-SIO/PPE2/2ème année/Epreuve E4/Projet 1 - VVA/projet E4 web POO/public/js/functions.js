function DisplayForm(typeForm) {
	switch (typeForm) {
		case 'ajouter':
			if(document.getElementById('addAnim').style.display == "none") {
				document.getElementById('addAnim').style.display = "block";
				document.getElementById('updateAnim').style.display = "none";
				document.getElementById('deleteAnim').style.display = "none";
			} else {
				document.getElementById('addAnim').style.display = "none";
			}
			break;
		case 'modifier':
			if(document.getElementById('updateAnim').style.display == "none") {
				document.getElementById('updateAnim').style.display = "block";
				document.getElementById('deleteAnim').style.display = "none";
				document.getElementById('addAnim').style.display = "none";
			} else {
				document.getElementById('updateAnim').style.display = "none";
			}
			break;
		case 'supprimer':
			if(document.getElementById('deleteAnim').style.display == "none") {
				document.getElementById('deleteAnim').style.display = "block";
				document.getElementById('updateAnim').style.display = "none";
				document.getElementById('addAnim').style.display = "none";
			} else {
				document.getElementById('deleteAnim').style.display = "none";
			}
			break;
		default:
			document.getElementById('updateAnim').style.display = "none";
			document.getElementById('deleteAnim').style.display = "none";
			break;
	}
}

function ajaxRequest() {
	var xhttp = new XMLHttpRequest();
	xhttp.open("POST", "index.php?page=var", true);
	xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
	xhttp.send("data=value");
}
