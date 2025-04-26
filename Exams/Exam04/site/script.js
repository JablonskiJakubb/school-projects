document.getElementById("oblicz").addEventListener("click", ObliczCene);

function ObliczCene() {
    let suma = 0;
    let peeling = 45;
    let maska = 30;
    let masaz = 20;
    let makijaz = 50;
    
    const zabieg1 = document.getElementById("CB1");
    const zabieg2 = document.getElementById("CB2");
    const zabieg3 = document.getElementById("CB3");
    const zabieg4 = document.getElementById("CB4");

    if (zabieg1.checked) suma += peeling;
    if (zabieg2.checked) suma += maska;
    if (zabieg3.checked) suma += masaz;
    if (zabieg4.checked) suma += makijaz;

    document.getElementById("wynik").innerHTML = "Cena zabiegów: " + suma + " zł";
}
