const graphMap = [
  // B
  // C
  {
    condition: ({ a, delta }) => a > 0 && delta < 0,
    text: "Parabola nie przecina osi X (brak miejsc zerowych).",
    img: "/images/parabolaC.png"
  },
  {
    condition: ({ a, delta }) => a < 0 && delta < 0,
    text: "Parabola nie przecina osi X (brak miejsc zerowych).",
    img: "/images/parabolaC_down.png"
  },


  {
    condition: ({ a, delta }) => a > 0 && delta === 0,
    text: "Parabola styka się z osią X (jedno miejsce zerowe). Smutas 😞",
    img: "/images/parabolaB.png"
  },
  {
    condition: ({ a, delta }) => a < 0 && delta === 0,
    text: "Parabola styka się z osią X (jedno miejsce zerowe). Uśmiech 😊",
    img: "/images/parabolaB_down.png"
  },


  {
    condition: ({ a, delta }) => a > 0 && delta > 0,
    text: "Parabola przecina oś X w dwóch punktach. Linia otwarta w górę ",
    img: "/images/parabolaA.png"
  },
  {
    condition: ({ a, delta }) => a < 0 && delta > 0,
    text: "Parabola przecina oś X w dwóch punktach. Linia otwarta w dół ",
    img: "/images/parabolaA_down.png"
  },


  {
    condition: ({ a, b }) => a === 0 && b > 0,
    text: "Linia prosta idzie w górę (rosnąca).",
    img: "/images/lineUp.png"
  },
  {
    condition: ({ a, b }) => a === 0 && b < 0,
    text: "Linia prosta idzie w dół (malejąca).",
    img: "/images/lineDown.png"
  }
];


export default function Graph({ result }) {
  // Szukamy odpowiednią konfigurację w mapie
  // pass the whole result object into the condition functions
  const graph = graphMap.find((g) => g.condition(result));

  return (
    <div className="card p-3 text-center">
      <h4>Interpretacja graficzna</h4>
      {graph?.img && <img src={graph.img} alt="Parabola" style={{ maxWidth: "100%", height: "auto" }} />}
      <p className="mt-2">{graph?.text}</p>
    </div>
  );
}
