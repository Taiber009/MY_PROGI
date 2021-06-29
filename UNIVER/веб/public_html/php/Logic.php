<?php
	$name = $_GET["radius"];
		if (preg_match('/^(\d)+(\.(\d)+)*$/', $name)){
			$rad = $name * 1.0;
			if ($rad != 0){
				echo "Объем сферы радиусом ", $rad, " равен ", 4 / 3 * 3.14 * $rad * $rad * $rad ;}
			else{
				echo "Это точкя.";
				}
			}
		else{
			echo "Неверный формат данных.";
			}
	?>