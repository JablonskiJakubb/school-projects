// Możesz umieścić na górze pliku (poza komponentem)
const graphMap = [
  { condition: (delta) => delta < 0, text: "Parabola nie przecina osi X (brak miejsc zerowych).", img: "/images/no_roots.png" },
  { condition: (delta) => delta === 0, text: "Parabola styka się z osią X (jedno miejsce zerowe).", img: "/images/one_root.png" },
  { condition: (delta) => delta > 0, text: "Parabola przecina oś X w dwóch punktach.", img: "/images/two_roots.png" },
];

export default function Graph({ result }) {
  // Szukamy odpowiednią konfigurację w mapie
  const graph = graphMap.find((g) => g.condition(result.delta));

  return (
    <div className="card p-3 text-center">
      <h4>Interpretacja graficzna</h4>
      {graph?.img && <img src={graph.img} alt="Parabola" style={{ maxWidth: "100%", height: "auto" }} />}
      <p className="mt-2">{graph?.text}</p>
    </div>
  );
}
