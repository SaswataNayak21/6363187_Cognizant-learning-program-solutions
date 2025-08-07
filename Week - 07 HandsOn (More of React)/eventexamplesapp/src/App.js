import React, { useState } from "react";
import CurrencyConvertor from "./components/CurrencyConvertor";

function App() {
  const [count, setCount] = useState(0);

  const increment = () => {
    setCount(count + 1);
    sayHello();
  };

  const decrement = () => {
    setCount(count - 1);
  };

  const sayHello = () => {
    console.log("Hello! This is a static message.");
  };

  const sayWelcome = (message) => {
    alert(message);
  };

  const handlePress = () => {
    alert("I was clicked");
  };

  return (
    <div style={{ padding: "20px" }}>
      <h1>Event Examples App</h1>

      <div style={{ marginBottom: "20px" }}>
        <h2>Counter: {count}</h2>
        <button onClick={increment}>Increment</button>{" "}
        <button onClick={decrement}>Decrement</button>
      </div>

      <div style={{ marginBottom: "20px" }}>
        <button onClick={() => sayWelcome("Welcome to the event handling demo!")}>
          Say Welcome
        </button>
      </div>

      <div style={{ marginBottom: "20px" }}>
        <button onClick={handlePress}>OnPress</button>
      </div>

      <hr />

      <CurrencyConvertor />
    </div>
  );
}

export default App;
