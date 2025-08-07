import React, { useState } from "react";

const CurrencyConvertor = () => {
  const [rupees, setRupees] = useState("");
  const [euro, setEuro] = useState(null);

  const handleSubmit = () => {
    if (isNaN(rupees) || rupees === "") {
      alert("Please enter a valid number");
      return;
    }

    const converted = (parseFloat(rupees) * 0.011).toFixed(2); // Approx conversion
    setEuro(converted);
  };

  return (
    <div>
      <h2>Currency Convertor (INR ➝ Euro)</h2>
      <input
        type="text"
        placeholder="Enter INR"
        value={rupees}
        onChange={(e) => setRupees(e.target.value)}
      />
      <button onClick={handleSubmit}>Convert</button>

      {euro !== null && (
        <p>
          ₹{rupees} = €{euro}
        </p>
      )}
    </div>
  );
};

export default CurrencyConvertor;
