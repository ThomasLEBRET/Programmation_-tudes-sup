<select>
	<?php
	for ($i=1; $i <= 31; $i++)
	{
		if($i < 10)
		{
			echo "<option value='0".$i."'>".$i."</option>\n";
		}
		else
		{
			echo "<option value='".$i."'>".$i."</option>\n";
		}
	}
	?>
</select>

<select>
	<?php
	for ($i=1; $i <= 31; $i++)
	{
		echo "<option value='";
		if($i < 10)
		{
			echo "0";
		}
		echo $i."'>".$i."</option>\n";
	}
	?>
</select>
