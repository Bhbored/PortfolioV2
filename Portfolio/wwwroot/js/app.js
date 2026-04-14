gsap.registerPlugin(ScrollTrigger, ScrollToPlugin);

function scrollToSection(sectionId) {
  const element = document.getElementById(sectionId.toLowerCase());
  if (!element) return;

  const offsetTop = element.getBoundingClientRect().top + window.pageYOffset;

  gsap.to(window, {
    duration: 1,
    scrollTo: { y: offsetTop, autoKill: true },
    ease: "power2.inOut",
  });
}

function setupScrollSpy(sectionIds, callback) {
  sectionIds.forEach((id) => {
    ScrollTrigger.create({
      trigger: `#${id}`,
      start: "top center",
      end: "bottom center",
      onEnter: () => callback(id),
      onEnterBack: () => callback(id),
    });
  });
}

window.slideProjectsTrack = function (currentIndex) {
  const track = document.getElementById("projects-track");
  if (!track) return;

  const slides = Array.from(track.children);
  if (slides.length === 0) return;

  const slideWidth = slides[0].offsetWidth;

  const trackStyle = window.getComputedStyle(track);
  const gap = parseFloat(trackStyle.gap) || 24;

  const offset = -currentIndex * (slideWidth + gap);

  gsap.to(track, {
    x: offset,
    duration: 0.6,
    ease: "power2.inOut",
  });
};

window.scrollGallery = function (galleryElement, direction) {
  const container = galleryElement.querySelector(".screenshot-container");
  if (!container) return;

  const item = container.querySelector(".screenshot-item");
  if (!item) return;

  const itemWidth = item.offsetWidth;
  const gap = parseFloat(window.getComputedStyle(container).gap) || 16;

  const isDesktop = window.innerWidth >= 768;
  const scrollCount = isDesktop ? 3 : 2;
  const scrollAmount = (itemWidth + gap) * scrollCount;

  container.scrollBy({
    left: direction * scrollAmount,
    behavior: "smooth",
  });
};

window.slideSkillsTrack = function (trackId, slideIndex) {
  const track = document.getElementById(trackId);
  if (!track) return;

  const inner = track.querySelector(".skills-track-inner");
  if (!inner) return;

  const firstCard = inner.querySelector(".skill-card-wrapper");
  if (!firstCard) return;

  const cardWidth = firstCard.offsetWidth;
  const innerStyle = window.getComputedStyle(inner);
  const gap = parseFloat(innerStyle.gap) || 24;

  const offset = -slideIndex * (cardWidth + gap);

  gsap.to(inner, {
    x: offset,
    duration: 0.5,
    ease: "power2.inOut",
  });
};

window.slideCertsTrack = function (slideIndex) {
  const inner = document.getElementById("certificates-track");
  if (!inner) return;

  const firstCard = inner.querySelector(".cert-card-wrapper");
  if (!firstCard) return;

  const cardWidth = firstCard.offsetWidth;
  const gap = parseFloat(window.getComputedStyle(inner).gap) || 48;

  const offset = -slideIndex * (cardWidth + gap);

  gsap.to(inner, {
    x: offset,
    duration: 0.5,
    ease: "power2.inOut",
  });
};

window.slideEduTrack = function (slideIndex) {
  const inner = document.getElementById("education-track");
  if (!inner) return;

  const firstCard = inner.querySelector(".edu-card-wrapper");
  if (!firstCard) return;

  const cardWidth = firstCard.offsetWidth;
  const gap = parseFloat(window.getComputedStyle(inner).gap) || 48;

  const offset = -slideIndex * (cardWidth + gap);

  gsap.to(inner, {
    x: offset,
    duration: 0.5,
    ease: "power2.inOut",
  });
};
