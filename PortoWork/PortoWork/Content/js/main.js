$(document).ready(function(){

	// section header---------------

$(".fa-bars").click(function () {
	$(".navbar").toggleClass("active");
});


// section slider--------------------------


// var owl = $('#slider .owl-carousel');
// owl.owlCarousel({
//     items:1,
//     autoHeight:true,
//      lazyLoad:true,
//     navigatiov:true,
//     singleItme:true,
//     loop:true,
//     margin:10,
//     autoplay:true,
//     autoplayTimeout:3000,
//     autoplayHoverPause:true
// });
// $('.play').on('click',function(){
//     owl.trigger('play.owl.autoplay',[1000])
// })
// $('.stop').on('click',function(){
//     owl.trigger('stop.owl.autoplay')
// });


// section logo----------------------

$("#logo .prev").click(function(event){
	var	leftPos=$(" #logo .slider").offset().left;
	if(leftPos>0){
		$("#logo .slider").animate({
		left:leftPos-263+"px"
	});
	}

	else{
		$("#logo .slider").animate({
		left:"-340px"
	});
	}


	
	
});	

$("#logo .next").click(function(event){
	var leftPos=$(" #logo .slider").offset().left;
	if(leftPos>-78){
		$("#logo .slider").animate({
		left:"0"
	});
	}

	else{
		$("#logo .slider").animate({
		left:"-170px"
	});
	}
});


	
// section magazine----------------------------------
$("#magazine .next").click(function(event){
	$("#magazine .text").animate({
					
			left:"-600px",
		})
	
});


$("#magazine .prev").click(function(event){
	$("#magazine .text").animate({
		left:"0px"
	})
	
});
// --------------------------------------------------------
    



    // projects-pg-------------------------------

    $("#projects-pg .all").click(function(event){

    	$("#projects-pg .col-md-4").show(1000)
    	$("#projects-pg .pre, #projects-pg .gen, #projects-pg .plum,#projects-pg .paint").css({
    		color:"#E04622",
    		background:"white"
    	})
    	$(this).css({
    		color:"white",
    		background:"#E04622"
    	})
    });

    $("#projects-pg .pre").click(function(event){

    	$("#projects-pg .col-md-4").hide()
    	$("#projects-pg .img1, #projects-pg .img2").show(1000)
    	$(".all, .gen, .plum,.paint").css({
    		color:"#E04622",
    		background:"white"
    	})
    	$(this).css({
    		color:"white",
    		background:"#E04622"
    	})
    });

    $("#projects-pg .gen").click(function(event){

    	$("#projects-pg .col-md-4").hide()
    	$("#projects-pg .img3").show(1000)
    	$(".all, .pre, .plum,.paint").css({
    		color:"#E04622",
    		background:"white"
    	})
    	$(this).css({
    		color:"white",
    		background:"#E04622"
    	})
    });

    $("#projects-pg .plum").click(function(event){

    	$("#projects-pg .col-md-4").hide()
    	$("#projects-pg .img4").show(1000)
    	$(".all, .gen, .pre,.paint").css({
    		color:"#E04622",
    		background:"white"
    	})
    	$(this).css({
    		color:"white",
    		background:"#E04622"
    	})
    });

    $("#projects-pg .paint").click(function(event){

    	$("#projects-pg .col-md-4").hide()
    	$("#projects-pg .img5, #projects-pg .img6").show(1000)
    	$(".all, .gen, .plum,.pre").css({
    		color:"#E04622",
    		background:"white"
    	})
    	$(this).css({
    		color:"white",
    		background:"#E04622"
    	})
    });

});