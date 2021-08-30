import { Route, Switch } from 'react-router-dom';
import { Container } from 'semantic-ui-react';
import CalendarDetails from '../../features/calendar/details/CalendarDetails';
import HomePage from '../../features/home/HomePage';
import NavBar from './NavBar';
import './styles.css';

function App() {
  return (
    <>
    <Route exact path='/' component={HomePage} />
    <Route
      path={'/(.+)'}
      render={() => (
        <>
          <NavBar />
          <Container style={{marginTop: '50px'}}>
            <Switch>
              <Route path='/details' component={CalendarDetails} />
            </Switch>
          </Container>
        </>
      )}
    />
    </>
  )
}

export default App;
