#!/usr/bin/perl

read(STDIN, $buffer, $ENV{'CONTENT_LENGTH'});

@pairs = split(/&/, $buffer);
foreach $pair (@pairs) {
  ($name, $value) = split(/=/, $pair);
  $value =~ tr/+/ /;
  $value =~ s/%([a-fA-F0-9][a-fA-F0-9])/pack("C", hex($1))/eg;
  $input{$name} = $value;   #Тутай черная магия дешифровки
}
$rad = $input{"radius"};   #Вытаскиваем в новую переменную строку с радиусом

print "Content-type: text/html\n\n";
if ($rad =~/^(\d)+(\.(\d)+)*$/)
		{
			$rad = $rad * 1.0;   #Превращаем в число
			if ($rad != 0){
				$rad = ($rad ** 3) * 4 * 3.14 / 3;
				print "<h1>Value: ", $rad,"</h1>";  #Бабахаем объем
				}
			else{
				print "It's a point.";
				}
		}
		else
		{
		print "Bad number";
		}
print "\n";