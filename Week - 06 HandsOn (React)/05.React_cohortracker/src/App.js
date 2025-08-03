import CohortDetails from './Components/CohortDetails';

function App() {
  return (
    <div>
      <h1>Cohort Details</h1>
      <CohortDetails
        name="SpringBoot Bootcamp"
        startDate="2025-06-07"
        endDate="2025-07-30"
        status="ongoing"
      />
      <CohortDetails
        name="Java Fundamentals"
        startDate="2025-04-01"
        endDate="2025-05-15"
        status="completed"
      />
      <CohortDetails
        name="Cognizant Training"
        startDate="2025-06-19"
        endDate="2025-07-7"
        status="ongoing"
      />
    </div>
  );
}

export default App;