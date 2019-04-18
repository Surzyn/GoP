import React, { Component } from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom'
import Pubs from './views/pubs'
import PubDetails from './views/pubDetails'

class App extends Component {
    render() {
        return (
            <BrowserRouter>
                <Switch>
                    <Route exact path="/" component={Pubs} />
                    <Route path="/pub/:pubId" component={PubDetails} />
                </Switch>
            </BrowserRouter>
        );
    }
}

export default App;
