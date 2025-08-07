import React from "react";
import FlightList from "./FlightList";

const GuestPage = () => {
  return (
    <div>
      <h2>Welcome, Guest!</h2>
      <p>You can view the available flights below.</p>
      <FlightList />
      <p><strong>Login to book your tickets.</strong></p>
    </div>
  );
};

export default GuestPage;
