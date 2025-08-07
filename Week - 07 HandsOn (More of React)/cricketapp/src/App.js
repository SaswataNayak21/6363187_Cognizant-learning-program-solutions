import { useState } from 'react';
import EvenPlayers from './components/EvenPlayers';
import { IndianPlayers } from './components/IndianPlayers';
import ListOfIndianPlayers from './components/ListOfIndianPlayers';
import OddPlayers from './components/OddPlayers';
import ScoreLess70 from './components/ScoreLess70';
import ListofPlayers from './components/ListOfPlayers';

function App() {
  const [flag, setFlag] = useState(true);

  const players = [
    { name: 'Ishan', score: 95 },
    { name: 'Ashwin', score: 55 },
    { name: 'Virat', score: 45 },
    { name: 'Jadeja', score: 75 },
    { name: 'Rohit', score: 30 },
    { name: 'Gill', score: 78 },
    { name: 'Bumrah', score: 39 },
    { name: 'Surya', score: 40 },
    { name: 'Dhoni', score: 72 },
    { name: 'Shami', score: 33 },
    { name: 'Rishabh', score: 63 },
  ];

  return (
    <div>
      <button onClick={() => setFlag(!flag)}>
        Toggle View (Current: {flag ? 'Players List' : 'Indian Team'})
      </button>

      <hr />

      {flag ? (
        <div>
          <h1>List of Players</h1>
          <ListofPlayers players={players} />

          <hr />

          <h1>List of Players having Scores Less than 70</h1>
          <ScoreLess70 players={players} />
        </div>
      ) : (
        <div>
          <h1>Indian Team</h1>

          <h2>Odd Players</h2>
          <OddPlayers players={IndianPlayers} />

          <h2>Even Players</h2>
          <EvenPlayers players={IndianPlayers} />

          <h2>List of Indian Players Merged:</h2>
          <ListOfIndianPlayers players={IndianPlayers} />
        </div>
      )}
    </div>
  );
}

export default App;
