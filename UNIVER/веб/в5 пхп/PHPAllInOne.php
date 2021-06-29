<head>
		<title>PHP все в одном</title>
	</head>
<text>Определение объема сферы через радиус.</text></br>

<text>Можно вводить целые или вещественные числа без знака минуса.</text>
	</br>
<form method="POST">
	<p> Радиус: <input name ="rad" type="text"></p>
	<input type="submit" value="Fuck">
</form>

<?php
if($_SERVER['REQUEST_METHOD'] == 'POST') {
    $name = $_POST['rad'];
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
}
?>