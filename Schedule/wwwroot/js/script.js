jQuery(($) => {
    $('.select').on('click', '.head', function () {
        if ($(this).hasClass('open')) {
            $(this).removeClass('open');
            $(this).next().fadeOut();
        } else {
            $('.head').removeClass('open');
            $('.list').fadeOut();
            $(this).addClass('open');
            $(this).next().fadeIn();
        }
    });

    $('.select').on('click', '.item', function () {
        $('.head').removeClass('open');
        $(this).parent().fadeOut();
        $(this).parent().prev().text($(this).text());
        $(this).parent().prev().prev().val($(this).text());
    });
	
	$('.block-head').on('click', function (e) {
		let tmp = document.getElementById('day');
		
		$(tmp).parent().prev().text($(tmp).text());
		$(tmp).parent().prev().prev().val($(tmp).text());
		
		document.getElementById('month-view').style.display = 'none';
		document.getElementById('week-view').style.display = 'none';
		document.getElementById('day-view').style.display = 'block';
		
		// e.preventDefault();
    	// e.stopPropagation();
	});

    $(document).click(function (e) {
        if (!$(e.target).closest('.select').length) {
            $('.head').removeClass('open');
            $('.list').fadeOut();
        }
    });
});