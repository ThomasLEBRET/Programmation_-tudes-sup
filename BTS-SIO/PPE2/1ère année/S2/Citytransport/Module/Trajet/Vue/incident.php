<?php
echo
"<div class='alert $imp justify' role='alert'>
<h4 class='alert-heading'>".$ligne['lib_incident']."</h4>
<h6>Date de début de l'incident </h6>
<i> ".$ligne['dt_deb_inc']."</i>
<p>".$ligne['description'].".</p>
</div>
";
