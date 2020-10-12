<div class="alert alert-primary" role="alert">
	<h4 class="alert-heading">Vérifiez votre compte</h4>
	<p>Allez dans votre boite mail et cliquez sur le lien dans le mail dans les 20 minutes</p>
	<p>Pensez à vérifier dans vos spams également</p>
	<hr>
	<button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal" onclick="sendNewMail()">
		Renvoyer un mail de vérification
	</button>
	<div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
		<div class="modal-dialog" role="document">
			<div class="modal-content">
				<div class="modal-header">
					<h5 class="modal-title" id="exampleModalLabel">Mail renvoyé !</h5>
					<button type="button" class="close" data-dismiss="modal" aria-label="Close">
						<span aria-hidden="true">&times;</span>
					</button>
				</div>
				<div class="modal-body">
					
					Allez vite dans votre boite mail (pensez à vérifier vos spams également).
				</div>
				<div class="modal-footer">
					<button type="button" class="btn btn-primary" data-dismiss="modal">Fermer</button>
				</div>
			</div>
		</div>
	</div>
</div>
