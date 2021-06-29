function Randomchik(min, max)
{return Math.floor(Math.random() * (max - min + 1)) + min;}
var Slova = ["замок","лампа","студент","человек","троллейбус","экзамен"],
    Zagadki = ["Не лает, не кусает, в дом не пускает.",
               "Висит груша, нельзя скушать.",
			   "Кто не спит ночью?",
			   "Утром на 4 ногах, днем на 2, вечером на 3.",
			   "Большой, с усами, не любит зайцев.",
			   "Все со шпорами, но не Дикий Запад."],
	Priz = ["автомобиль","фен","компьютер","приставка","микроволновка","билеты в Крым","домашний кинотеатр"]

var rand = Randomchik(0,Slova.length-1);			   
var Slovo = Slova[rand],
    Vivod,
	Secret="";
window.addEventListener("load",function(){
    Vivod = document.getElementById("Otvet");
    for(var i=0; i<Slovo.length; i++) 
	     Secret+="*";
    Vivod.innerHTML = Secret;
	document.getElementById("zagadka").innerHTML = Zagadki[rand];
});
function Try(){
    var BukvaVal = document.getElementById("Bukva").value;
    document.getElementById("Bukva").value = "";
    if(BukvaVal.length>1||BukvaVal==""||BukvaVal==" ") 
	     return alert("Введите 1 символ");
    Secret = Secret.split("");
    for(var i=0;i<Slovo.length; i++) 
	     if(Slovo[i]==BukvaVal) 
	         Secret[i]=BukvaVal;
    Secret = Secret.join("");
    Vivod.innerHTML = Secret;
    if(Secret==Slovo) {
		 document.getElementById("Win").innerHTML = '<img src="Yakyb.jpg">'+'<br>'+
		 "У нас новый победитель! Ваш приз: "+Priz[Randomchik(0,Priz.length-1)]+"!";
	}
}