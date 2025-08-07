import React from "react";

const flights = [
  { id: 1, from: "Delhi", to: "Mumbai", time: "10:00 AM" },
  { id: 2, from: "Chennai", to: "Kolkata", time: "1:30 PM" },
  { id: 3, from: "Bangalore", to: "Pune", time: "6:45 PM" },
];

const FlightList = () => {
  return (
    <div>
      <h3>Available Flights</h3>
      <ul>
        {flights.map((flight) => (
          <li key={flight.id}>
            {flight.from} to {flight.to} - {flight.time}
          </li>
        ))}
      </ul>
    </div>
  );
};

export default FlightList;
