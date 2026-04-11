// GSAP + Plugins are loaded via script tags in index.html
// This file contains custom helper functions

// Register plugins at load time
gsap.registerPlugin(ScrollTrigger, ScrollToPlugin);

// Scroll to section with smooth animation
function scrollToSection(sectionId) {
    const element = document.getElementById(sectionId.toLowerCase());
    if (!element) return;

    const offsetTop = element.getBoundingClientRect().top + window.pageYOffset;

    gsap.to(window, {
        duration: 1,
        scrollTo: { y: offsetTop, autoKill: true },
        ease: "power2.inOut"
    });
}

// Setup scroll spy for active section detection
function setupScrollSpy(sectionIds, callback) {
    sectionIds.forEach(id => {
        ScrollTrigger.create({
            trigger: `#${id}`,
            start: "top center",
            end: "bottom center",
            onEnter: () => callback(id),
            onEnterBack: () => callback(id)
        });
    });
}

// Projects Horizontal Scroll
window.slideProjectsTrack = function(currentIndex) {
    const track = document.getElementById('projects-track');
    if (!track) return;

    const slides = Array.from(track.children);
    if (slides.length === 0) return;

    const slideWidth = slides[0].offsetWidth;
    // Get actual gap from computed style
    const trackStyle = window.getComputedStyle(track);
    const gap = parseFloat(trackStyle.gap) || 24;

    // Slide by current index amount (each index = one card position)
    const offset = -currentIndex * (slideWidth + gap);

    gsap.to(track, {
        x: offset,
        duration: 0.6,
        ease: "power2.inOut"
    });
};
