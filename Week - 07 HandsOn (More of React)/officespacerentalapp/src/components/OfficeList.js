import React from 'react';


const OfficeList = () => {
  const offices = [
    {
      name: 'Skyline Tower',
      rent: 75000,
      address: 'MG Road, Bangalore',
    },
    {
      name: 'TechPark View',
      rent: 55000,
      address: 'Whitefield, Bangalore',
    },
    {
      name: 'Corporate Nest',
      rent: 63000,
      address: 'Indiranagar, Bangalore',
    },
  ];

  return (
    <div>
      <h2>Available Office Spaces</h2>
      <ul>
        {offices.map((office, index) => (
          <li key={index}>
            <h3>{office.name}</h3>
            <p>Address: {office.address}</p>
            <p style={{ color: office.rent > 60000 ? 'green' : 'red' }}>
              Rent: ₹{office.rent}
            </p>
            <hr />
          </li>
        ))}
      </ul>
    </div>
  );
};

export default OfficeList;
