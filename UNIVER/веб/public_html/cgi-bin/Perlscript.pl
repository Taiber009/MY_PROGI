#!/usr/bin/perl

read(STDIN, $buffer, $ENV{'CONTENT_LENGTH'});

@pairs = split(/&/, $buffer);
foreach $pair (@pairs) {
  ($name, $value) = split(/=/, $pair);
  $value =~ tr/+/ /;
  $value =~ s/%([a-fA-F0-9][a-fA-F0-9])/pack("C", hex($1))/;
  $input{$name} = $value;   
}
$rad = $input{"radius"};   
$vis = $input{"visota"};
print "Content-type: text/html\n\n";
if (($rad =~/^(\d)+(\.(\d)+)*$/)&&($vis =~/^(\d)+(\.(\d)+)*$/))
		{
			$rad = $rad * 1.0;
            $vis = $vis * 1.0;			
			if (($rad != 0)&&($vis != 0)){
				$rad = ($rad * $rad * $vis * 2 * 3.14) / 3  ;
				print "<h1>Ob'em: ", $rad,"</h1>"; 
				}
			else{
				print "Chto-to ne tak";
				}
		}
		else
		{
		print "Chto-to ne tak";
		}
print "\n";