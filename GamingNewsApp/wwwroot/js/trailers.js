/*https://drive.google.com/uc?export=view&id=1MAcF2ydw_b_9ZNhBpnw03euC1GhSULmW*/

$(document).ready(function () {
    var parallaxSliderOptions = {
        speed: 1000,
        effect: 'coverflow',
        autoplay: false,
        parallax: true,
        loop: true,
        grabCursor: true,
        centeredSlides: true,
        coverflowEffect: {
            rotate: 35,
            depth: 10,
            stretch: 0,
            modifier: 1,
            slideShadows: true
        },
        pagination: {
            el: '.swiper-pagination',
            clickable: true
        },
        on: {
            init: function () {
                let swiper = this;
                for (let i = 0; i < swiper.slides.length; i++) {
                    $(swiper.slides[i])
                        .find('.img-container')
                        .attr({
                            'data-swiper-parallax': 0.75 * swiper.width,
                            'data-swiper-paralalx-opacity': 0.5
                        });
                }
                let index = swiper.activeIndex;
                $(swiper.slides).removeClass('active');
                $(swiper.slides[index]).addClass('active');
            },
            transitionEnd: function () {
                let swiper = this;
                let index = swiper.activeIndex;
                $(swiper.slides).removeClass('active');
                $(swiper.slides[index]).addClass('active');
            },
            resize: function () {
                this.update();
            }
        },
        navigation: {
            nextEl: '.image-slider .next-ctrl',
            prevEl: '.image-slider .prev-ctrl'
        }
    };
    var slider = new Swiper('.image-slider', parallaxSliderOptions);
});
