$(document).ready(function(){

	$('.btn-tooltip').click(function(e) {
		if ($(this).hasClass('js-open')){
		    $(this).removeClass('js-open');
		    
		} 
		else{
		    $(this).addClass('js-open');
		}
		e.preventDefault();
	});

});