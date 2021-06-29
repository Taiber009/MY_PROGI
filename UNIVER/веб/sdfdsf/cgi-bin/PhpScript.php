<?php
$name = $_POST["radius"];
			if (preg_match('/^(\d)+(\.(\d)+)*$/', $name)){
				$rad = $name * 1.0;
				if ($rad != 0){
				echo "Объем сферы с радиусом ",$rad, " равен ", 4 / 3 * $rad * $rad * $rad * 3.14;}
				else{
					echo "Если у сферы радиус равен 0, то это точка.";
				}
			}
			else{
			echo "Неверный формат числа.";
			}
?>