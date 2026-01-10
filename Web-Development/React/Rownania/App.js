import { useState } from "react";
import Header from "./components/Header";
import Footer from "./components/Footer";
import Info from "./components/Info";
import InputForm from "./components/InputForm";
import Results from "./components/Results";
import Graph from "./components/Graph";
import 'bootstrap/dist/css/bootstrap.min.css';

export default function App() {

  const [result, setResult] = useState(null);

  const calculate = ({ a, b, c }) => {
  const A = parseFloat(a);
  const B = parseFloat(b);
  const C = parseFloat(c);

  // przypadek linia prosta
  if (A === 0) {
    const x = B !== 0 ? -C / B : null; // jeśli B=0, linia pozioma
    setResult({ delta: null, x1: x, x2: null, a: A, b: B, c: C });
    return;
  }

  // parabola
  const delta = B * B - 4 * A * C;

  if (delta < 0) {
    setResult({ delta, x1: null, x2: null, a: A, b: B, c: C });
    return;
  }

  const sqrtDelta = Math.sqrt(delta);
  const x1 = (-B - sqrtDelta) / (2 * A);
  const x2 = (-B + sqrtDelta) / (2 * A);

  setResult({ delta, x1, x2, a: A, b: B, c: C });
};

  return (
    <div className="container mt-3">
      <Header title="Równanie kwadratowe" />

      <Info />

      <InputForm onCalculate={calculate} />

      {result && (
        <div className="row mt-4">
          <div className="col-md-6">
            <Results result={result} />
          </div>
          <div className="col-md-6">
            <Graph result={result} />
          </div>
        </div>
      )}

      <Footer title="Równanie kwadratowe" />
    </div>
  );
}
