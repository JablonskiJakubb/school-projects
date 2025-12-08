export default function Results({ result }) {
  const { delta, x1, x2 } = result; // destrukturyzacja

  return (
    <div className="card p-3">
      <h4>Wyniki obliczeń</h4>

      <p>Δ = {delta}</p>
      
      {x1 === null ? (
        <p className="text-danger">Brak rozwiązań rzeczywistych</p>
      ) : (
        <>
          {delta < 0 && <p>Brak miejsc zerowych (delta &lt; 0)</p>}
          {delta === 0 && <p>Jedno miejsce zerowe: x = {x1}</p>}
          {delta > 0 && <p>Miejsca zerowe: x1 = {x1}, x2 = {x2}</p>}
        </>
      )}
    </div>
  );
}
