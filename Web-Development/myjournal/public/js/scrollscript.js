function toggleMenu() {
    const sideMenu = document.getElementById("sidemenu");
    const mainContent = document.querySelector("main");

    // Toggle the 'visible' class to animate the side menu
    if (sideMenu.classList.contains('visible')) {
        sideMenu.classList.remove('visible'); // Slide out to the right
        mainContent.style.marginRight = "0"; // Restore content position
    } else {
        sideMenu.classList.add('visible'); // Slide in from the right
        mainContent.style.marginRight = "250px"; // Move content to the left
    }
}
