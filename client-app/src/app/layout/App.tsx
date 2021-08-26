import axios from 'axios';
import React, { useEffect, useState } from 'react';
import { Header, List } from 'semantic-ui-react';
import './App.css';

function App() {
  const [works, setWorks] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/works').then(response => {
      setWorks(response.data);
    });
  }, [])

  return (
    <>
    <Header as='h2' content='Works' />
    <List>
      {works.map((work: any) => (
        <List.Item key={work.id}>
          {work.title}
        </List.Item>
      ))}
    </List>
    </>
  );
}

export default App;
