var zdjecia = Array(
    Array('obraz_0.jpg', 'obraz_0.jpg', '-Trwałość Pamięci- Salvador Dali', 'Surrealistyczny obraz przedstawiający rozpuszczające się zegary na tle niezwykłego krajobrazu.'),
    Array('obraz_1.jpg', 'obraz_1.jpg', '-Ostatnia Wieczerza- Leonardo Da Vinci', 'Fresk przedstawiający Jezusa z apostołami podczas ostatniej wieczerzy, ukazujący ich emocje w chwili ogłoszenia zdrady. Znany z doskonałej perspektywy i kompozycji.'),
    Array('obraz_2.jpg', 'obraz_2.jpg', '-Gwieździsta Noc- Vincent Van Gogh', 'Dynamiczne niebo nocne pełne wirujących gwiazd nad małym miasteczkiem.'),
    Array('obraz_3.jpg', 'obraz_3.jpg', '-Narodziny Wenus- Sandro Boticelli', 'Obraz przedstawiający narodziny bogini Wenus na muszli, otoczonej aniołami i wiatrem.'),
    Array('obraz_4.jpg', 'obraz_4.jpg', '-Straż Nocna- Rembradnt', 'Dynamiczna scena przedstawiająca grupę milicji miejskiej w akcji, znana z gry światła i cienia.')
);
var max_width = 520;

function laduj() {
    for(var i = 0; i < zdjecia.length; i++)
        document.getElementById('miniaturki').innerHTML += '<img src="' + zdjecia[i][1] + '" onclick="zmien(' + i + ')" />';
    zmien(0);
}
function zmien(id) {
    document.getElementById('zdjecie').innerHTML += '<div id="ladowanie"></div>'; 
    var custom = '';
    var preload = new Image(); 
    preload.onload = function() {
        if(preload.width > max_width) 
            custom = ' style="height: '+(Math.floor(max_width / (preload.width / preload.height)))+'px;width:'+max_width+'px;"';
 
        document.getElementById('informacje').innerHTML = '<b>'+zdjecia[id][2]+'</b><br /><i>'+zdjecia[id][3]+'</i>';
        document.getElementById('zdjecie').innerHTML = '<img src="'+zdjecia[id][0]+'"'+custom+' />'; 
    }
    preload.src = zdjecia[id][0]; 
}
window.onload = laduj;