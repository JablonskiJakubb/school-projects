document.addEventListener("DOMContentLoaded", function () {
    const blurRadio = document.getElementById("blur");
    const sepiaRadio = document.getElementById("sepia");
    const negatywRadio = document.getElementById("negatyw");
    const imagep = document.getElementById("pszczola");
    const imaged = document.getElementById("drzewo");
    const imageo = document.getElementById("owoce");
    const imagez = document.getElementById("zolw");
    const buttonone = document.getElementById("button_one");
    const buttontwo = document.getElementById("button_two");
    const buttonthree = document.getElementById("button_three");
    const buttonfour = document.getElementById("button_four");
    const buttonfive = document.getElementById("button_five");
    const rangeone = document.getElementById("range_one");
    const rangetwo = document.getElementById("range_two");

    // Domyślnie ustawiamy jasność na 125 (w skali 0 - 250)


    buttonone.addEventListener("click", function () {
        if (blurRadio.checked) {
            let blurValue = Math.random() * (8 - 4) + 4; // Losowa wartość od 4px do 8px
            imagep.style.filter = `blur(${blurValue}px)`;
        } else if (sepiaRadio.checked) {
            imagep.style.filter = "sepia(100%)"; // Nakłada filtr sepii
        } else if (negatywRadio.checked) {
            imagep.style.filter = "invert(100%)"; // Nakłada efekt negatywu
        }
    });

    buttontwo.addEventListener("click", function () {
        imaged.style.filter = "none"; // Przywrócenie kolorów (usunięcie filtra)
    });

    buttonthree.addEventListener("click", function () {
        imaged.style.filter = "grayscale(100%)"; // Zmiana na czarno-biały
    });

    buttonfour.addEventListener("click", function () {
        const opacityValue = rangeone.value / 100; // Zmiana przezroczystości obrazu o id "owoce"
        imageo.style.opacity = opacityValue;
    });

    // Obsługa button_five (suwak rangetwo - zmiana jasności)
    buttonfive.addEventListener("click", function () {
        const brightnessValue = rangetwo.value / 125; // Skala suwaka rangetwo zmienia jasność (0 do 2)
        imagez.style.filter = `brightness(${brightnessValue})`; // Nakładanie filtra jasności
    });
});
