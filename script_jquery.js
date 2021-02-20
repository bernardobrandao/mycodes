$(document).ready(function(){ //nessa função de boas praticas o seletor verifica se o documento esta pronto antes de executar a função
	$('#eom').click(function(){ //aqui o seletor do button na funcao click
		$('h1').hide();//aqui o seletor escolhe a opção hide
	});
	
	$('#azul').click(function(){//nessa função ao clicar no botao identificado como azul ele altera a cor to paragrafo identificado como p para azul
		$('p').css("color", "blue");
		$('#mensagem').text("Cor alterada para Azul");//Exibe uma mensagem dizendo que a cor foi alterada para azul
		$('#mensagem').css('color', 'blue');//
		$('#mensagem').css('border','1px solid blue');
		$('#mensagem').fadeOut();
		$('#mensagem').delay(3500);
		$('#mensagem').fadeIn('slow');


	});
	
	$('#vermelho').click(function(){//nessa função ao clicar no botao identificado como vermelho ele altera a cor to paragrafo identificado como p para vermelho
		$('p').css("color", "red");
		$('#mensagem').text("Cor alterada para vermelho");
		$('#mensagem').css('color', 'red');
		$('#mensagem').css('border','1px solid red');
		$('#mensagem').fadeOut();
		$('#mensagem').delay(3500);
		$('#mensagem').fadeIn('slow');

	});

	$('#bca').click(function(){//nessa função ao clicar no botao identificado como bca ele altera a cor do background do texto para azul
		$('p').css("background-color", "blue");
		$('p').fadeOut('slow');//aqui efeito fade out que faz o texto desaparecer suavemente com o atributo slow ele desaparece lentamente
		$('p').delay(1500);//aqui o contador do efeito para 1,5 segundos 
		$('p').fadeIn('slow');//aqui efeito fade in que faz o texto aparecer suavemente com o atributo slow ele aparece lentamente
		$('#mensagem').text("Cor alterada para Azul");//Exibe uma mensagem dizendo que a cor foi alterada para azul
		$('#mensagem').css('color', 'blue');//configuração onde a cor azul é setada
		$('#mensagem').css('border','3px solid blue');//configuração onde a borda é setada
		$('#mensagem').fadeOut();
		$('#mensagem').delay(3500);
		$('#mensagem').fadeIn('slow');


	});

	$('#bcv').click(function(){//nessa função ao clicar no botao identificado como bcv ele altera a cor do background do texto para vermelho
		$('p').css("background-color", "red");
		$('p').fadeOut('slow');//aqui efeito fade out que faz o texto desaparecer suavemente com o atributo slow ele desaparece lentamente
		$('p').delay(1500);//aqui o contador do efeito para 1,5 segundos
		$('p').fadeIn('slow');//aqui efeito fade in que faz o texto aparecer suavemente com o atributo slow ele aparece lentamente
		$('#mensagem').text("Cor alterada para Vermelho");
		$('#mensagem').css('color', 'red');
		$('#mensagem').css('border','3px solid red');
		$('#mensagem').fadeOut();
		$('#mensagem').delay(3500);
		$('#mensagem').fadeIn('slow');

	});

});
$(function(){
	$('#l1').click(function(){
		$('#i1').show();
		$('#i2').hide();
		$('#i3').hide();
		$('#i4').hide();
	})

	$('#l2').click(function(){
		$('#i1').hide();
		$('#i2').show();
		$('#i3').hide();
		$('#i4').hide();
	})

	$('#l3').click(function(){
		$('#i1').hide();
		$('#i2').hide();
		$('#i3').show();
		$('#i4').hide();
	})

	$('#l4').click(function(){
		$('#i1').hide();
		$('#i2').hide();
		$('#i3').hide();
		$('#i4').show();
	})



})