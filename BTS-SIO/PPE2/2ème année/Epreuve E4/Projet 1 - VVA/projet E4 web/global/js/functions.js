function ajaxRequest() {
	var xhttp = new XMLHttpRequest();
	xhttp.open("POST", "index.php?page=var", true);
	xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
	xhttp.send("data=value");
}
