import React from "react";
import FlightList from "./FlightList";

const UserPage = () => {
  const handleBook = () => {
    alert("Ticket booked successfully!");
  };

  return (
    <div>
      <h2>Welcome, User!</h2>
      <p>You can view and book flights below:</p>
      <FlightList />
      <button onClick={handleBook}>Book Ticket</button>
    </div>
  );
};

export default UserPage;
