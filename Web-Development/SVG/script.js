function script(){
  const fx = document.getElementById('fx').value;
  alert(fx)
  const SVG = '<svg width = "500" height = "500"><polygon points="0 0, 250 500, 500, 0"</svg>'
  document.getElementById('SVG').innerHTML = SVG;
}