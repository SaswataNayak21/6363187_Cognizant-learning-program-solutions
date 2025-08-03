import CalculateScore from './Components/CalculateScore';

function App() {
  return (
    <div>
      <CalculateScore 
        Name="Saswata Kumar Nayak" 
        School="KIIT International School" 
        total={453} 
        goal={5} 
      />
    </div>
  );
}

export default App;