import React from 'react';
import './App.css';
import Header from './Header';
import BowlerData from './Bowler/BowlerData';
// import bowlingData from

// const BowlingLeague = bowlingData;

function App() {
  return (
    <div className="App">
      <Header title="Bowler's Website" />
      <BowlerData />
    </div>
  );
}

export default App;
