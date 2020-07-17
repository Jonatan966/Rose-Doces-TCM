var slideIndex = 1;
showSlides(slideIndex);

// Next/previous controls
function plusSlides(n) {
  showSlides(slideIndex += n);
}

// Thumbnail image controls
function currentSlide(n) {
  showSlides(slideIndex = n);
}

function showSlides(n) {
  var i;
  var slides = document.getElementsByClassName("mySlides");
  var dots = document.getElementsByClassName("dot");
  if (n > slides.length) {slideIndex = 1} 
  if (n < 1) {slideIndex = slides.length}
  for (i = 0; i < slides.length; i++) {
      slides[i].style.display = "none"; 
  }
  for (i = 0; i < dots.length; i++) {
      dots[i].className = dots[i].className.replace(" active", "");
  }
  slides[slideIndex-1].style.display = "block"; 
  dots[slideIndex-1].className += " active";
}
$('.dropdown-toggle').dropdown()
/*
* Js para criar novos elementos e depois função de Js para abrir ao clicar
*/
$(function(){

	$('#off-canvas-nav .megamenu .dropdown-toggle').each(function(){
		$(this).parent().append('<span class="open_dropdown"><i class="fa fa-sort-desc" aria-hidden="true"></i></span>');		
	});

	$('#off-canvas-nav .open_dropdown').click(function(e){
		e.preventDefault();
		var atual = $(this).parent().find('.dropdown-menu').css('display');
		if(atual=="none"){
			$(this).parent().find('.dropdown-menu').slideDown(500);
		}else{
			$(this).parent().find('.dropdown-menu').slideUp(500);
		}
	});

});



