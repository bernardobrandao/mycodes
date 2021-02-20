/*var a = 2; //variavel a recebe 2
var b = 3; //variavel b recebe 3
var i = 0;

//tipos de variaveis
var inteiro = 1; //variavel de numeros inteiros
var flutuante = 1.6; //variavel de numeros ponto flutuante os numeros são sempres separados por . de suas casas decimais
var texto = "String"; //variavel string sempre sendo representada por " " nas palavras
var lista = ["laranja", "Banana","Maca"];//variavel lista/array representada aqui por diversas strings dentro de uma mesma variavel todas apontadas com numeros no caso da lista de 0 a 2
alert(lista[0]); // para passar a mensagem na tela na posição zero ele vai imprimir a palavra laranja

for (o in lista){//laço for para imprimir todos os indices da lista ou seja aparecera de 0 a 2 na tela
	alert(o);
}

for (o in lista){
	alert(lista[o]);//laço for para imprimir todas as strings contidas na lista ou seja aparecera de laranja,banana,maca na tela
}

console.log("Ola mundo"); // Essa função tambem passa mensagens na tela, porem somente no console do navegador na função inspecionar elemento


var soma = a+b; //operação aritmetica para somar
var sub = a-b;  //operação aritmetica para subtrair
var mult = a*b; //operação aritimetica para multiplicar
var div = a/b;  //operação aritimetica para dividir
var resto = a%b; //Operação aritimetica para dividir, porem exibe o resto da divisão

//comando que vai exibindo mensagens no navegador
alert(soma);
alert(sub);
alert(mult);
alert(div);
alert(resto);

//estrutura condicional if onde ele esta verificando se o numero contido na variavel b e par
if(b%2 == 0){
	alert("Numero Par!");
} else{
	alert("Numero Impar!")
}

//estrutura condicional if onde ele esta verificando se o numero contido na variavel a e par
//if(a%2 == 0){
	//alert("Numero Par!");
//}

//Esctrutura de repetição condicional while onde enquanto o i for menor que 3 ele exibe,
while (i < 3){
	alert(i);
	i = i+1;//incremento apos a exibição do conteudo da variavel i
}

//Estrutura de repetição condicional for, nessa estrutura temos a opção de declarar a variavel dentro da condicional como é o caso
//E declarada a variavel j com valor 0, implementada a condicional j menor que 3 e apos isso um incremento de +1 a cada rodada
//nessa estrutura a cada rodada ele vai exibindo os numeros menores que 3 e incrementando mais um, quando chegar em 3 ou mais ele para de exibir
for(var j = 0; j < 3; j++){
	alert(j);
}

function somar(c, d){//Função - Utilizada para executar comandos no caso especifico a função exibe a soma de 2+ 2
	console.log(c+d)
}
somar(2, 2);

function subtracao(c, d){//Nesse caso a função retorna o valor para a subtração entao para exibir sera necessario criar uma variavel que armazene
//o valor da subtracao para exibi-la no console	
	return c-d;
}

var s = subtracao(5, 3);
console.log(s);


function multiplicacao(c, d){//nessa forma ele chama a funcao multiplica 5 x 6 vai retornar o resultado e jogar no console.log
	return c*d;
}
console.log(multiplicacao(5,  6));*/

function mensagem(){ //Mensagem atraves da pagina html é invocada essa função que ao usuario clicar no botao o alerta é acionado.
	alert("Filho da Puta!!");/// o botao criado e com codigo onclick ele invoca a funcao mensagem no cocigo script.js//
}

function mudaCor(cor){
	var elemento = document.getElementById("mensagem");
	elemento.style.color = cor;
	elemento.style.Backgroudcolor = cor;
}

function valida(){//nessa função de validação de formulario ele coleta o que esta escrito no campo nome assim que é apertado o botao de enviar
	var nome = document.getElementById('nome');//se o campo estiver em branco o formulario retorna com erro caso contrario exibe uma mensagem de sucesso

	if(nome.value == ""){
		alert("Campo nome nao pode ficar em branco porra!!");
	} else{
		alert("Nenhum problema foi detectado.Seu formulario foi enviado!!");
	}
}