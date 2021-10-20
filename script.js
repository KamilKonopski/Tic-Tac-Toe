$('.btn').on('click', function () {
    $('body, html').animate({
        scrollTop: $('.portfolio').offset().top
    }, 1500)
})