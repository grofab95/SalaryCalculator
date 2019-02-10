import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';

class App extends Component {
  componentDidMount() {
    fetch("https://localhost:44379/calculator/value?month=1&workedHours=169")
    .then(response => response.json())
    .then(data => console.log({ data }));
  }
  fetchData() {
    fetch("https://localhost:44379/calculator/value?month=1&workedHours=169")
    .then(data => {    
      console.log(data.json() )
    });
  }
  

  render() {
    return (
      <div className="App">
        <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <p>
            Edit <code>src/App.js</code> and save to reload s.
          </p>
          <a
            className="App-link"
            href="https://reactjs.org"
            target="_blank"
            rel="noopener noreferrer"
          >
          </a>
          <button onClick={this.fetchData}>Click me!</button>
            Learn React
        </header>
      </div>
    );
  }
}

export default App;
