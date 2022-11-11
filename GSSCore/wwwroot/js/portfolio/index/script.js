$(document).ready(function () {
    $(window).scroll(function () {
        if (this.scrollY > 20) {
            $('.header').addClass('stick');
            $('.header .logo a').addClass('stick');
        } else {
            $('.header').removeClass('stick');
            $('.header .logo a').removeClass('stick');
        }

        if (this.scrollY > 500) {
            $('.button-scroll').addClass('show');
        } else {
            $('.button-scroll').removeClass('show');
        }
    });

    $('.button-scroll').click(function () {
        $('html').animate(
            {
                scrollTop: 0
            }
        );
    });

    $('.header .menu li a').click(function () {
        $('html').css('scrollBehavior', 'smooth');

        if ($('.header .menu.active li a').length > 0) {
            $('.header .menu').toggleClass('active');
            $('.menu-button i').toggleClass('active');
        }
    });

    $('.menu-button').click(function () {
        $('.header .menu').toggleClass('active');
        $('.menu-button i').toggleClass('active');
    });

    new Typed('.changed', {
        strings: ['Desenvolvedor Web', 'Desenvolvedor Mobile', 'Desenvolvedor Desktop'],
        typedSpeed: 100,
        backSpeed: 60,
        loop: true
    });
});