import React from 'react';
import './App.css';
import OfficeList from './components/OfficeList';

function App() {
  return (
    <div className="App">
      <h1>Office Space Rental Portal</h1>
      <img src="/office.jpg" alt="Office Space" width="400" />
      <OfficeList />
    </div>
  );
}

export default App;
