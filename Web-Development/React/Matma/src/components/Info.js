export default function Info() {
  return (
    <div className="alert alert-info">
      <h4>Informacje o równaniu kwadratowym</h4>
      <p>Postać ogólna: <strong>ax² + bx + c = 0</strong></p>
      <p>Delta: Δ = b² - 4ac</p>
      <p>Jeżeli Δ &gt; 0 mamy 2 rozwiązania</p>
      <p>x₁ = (-b - √Δ) / 2a<br />
        x₂ = (-b + √Δ) / 2a</p>
      <p>Jeżeli Δ = 0 mamy 1 rozwiązanie</p>
      <p>x₁ = -b / 2a</p>
      <p>Jeżeli Δ &lt; 0 nie mamy rozwiązania</p>
      
    </div>
  );
}
