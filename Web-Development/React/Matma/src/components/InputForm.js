import { useState } from "react";

export default function InputForm({ onCalculate }) {
  const [values, setValues] = useState({ a: "", b: "", c: "" });
  const [errors, setErrors] = useState({ a: "", b: "", c: "" });

  const handleChange = (e) => {
    setValues({ ...values, [e.target.name]: e.target.value });
  };

  // Walidacja – czy wartość jest liczbą
  const validate = (name, val) => {
  if (val === "" || isNaN(Number(val))) return "Musisz podać liczbę!";
  if (name === "a" && Number(val) === 0) return "a musi być różne od 0 (równanie kwadratowe)";
  return "";
};


  // Obsługa onBlur – ustawiamy komunikat błędu dla danego inputu
  const handleBlur = (e) => {
    const { name, value } = e.target;
    const msg = validate(name, value);
    setErrors({ ...errors, [name]: msg });
  };

  const handleClick = () => {
    // Walidacja wszystkich pól przed obliczeniem
    const e1 = validate("a", values.a);
    const e2 = validate("b", values.b);
    const e3 = validate("c", values.c);

    if (e1 || e2 || e3) {
      setErrors({ a: e1, b: e2, c: e3 });
      return;
    }

    setErrors({ a: "", b: "", c: "" });
    onCalculate(values);
  };

  // Generowanie równania tylko z poprawnych wartości liczbowych
  const getEquation = () => {
    const { a, b, c } = values;
    const parts = [];

    if (a && !errors.a) parts.push(`${a}x²`);
    if (b && !errors.b) {
      const sign = parts.length && Number(b) >= 0 ? "+" : "";
      parts.push(`${sign}${b}x`);
    }
    if (c && !errors.c) {
      const sign = parts.length && Number(c) >= 0 ? "+" : "";
      parts.push(`${sign}${c}`);
    }

    return parts.length ? parts.join(" ") + " = 0" : "";
  };

  // Sprawdzamy, czy jest jakikolwiek błąd do wyświetlenia
  const hasError = errors.a || errors.b || errors.c;

  return (
    <div className="card p-3 mt-3">
      <h4>Wprowadzanie danych</h4>

      {hasError && <p className="text-danger fw-bold">Popraw wartości: {Object.values(errors).filter(e => e).join(", ")}</p>}

      <div className="row g-3">
        <div className="col-md-4">
          <label>a:</label>
          <input
            className={`form-control ${errors.a ? "is-invalid" : ""}`}
            name="a"
            value={values.a}
            onChange={handleChange}
            onBlur={handleBlur}
          />
        </div>

        <div className="col-md-4">
          <label>b:</label>
          <input
            className={`form-control ${errors.b ? "is-invalid" : ""}`}
            name="b"
            value={values.b}
            onChange={handleChange}
            onBlur={handleBlur}
          />
        </div>

        <div className="col-md-4">
          <label>c:</label>
          <input
            className={`form-control ${errors.c ? "is-invalid" : ""}`}
            name="c"
            value={values.c}
            onChange={handleChange}
            onBlur={handleBlur}
          />
        </div>
      </div>

      {/* Równanie dynamiczne tylko z poprawnych wartości */}
      {getEquation() && (
        <p className="mt-3 fw-bold">Równanie: {getEquation()}</p>
      )}

      <button className="btn btn-primary mt-3" onClick={handleClick}>
        Oblicz
      </button>
    </div>
  );
}
