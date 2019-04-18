import React, { Component } from 'react'
import './pubs.css'

import { GetAllPubs } from '../../services/pubService'
import Pub from '../../components/pub'


export default class Pubs extends Component {
    constructor(props) {
        super(props);

        this.state = {
            pubs: []
        };
    }

    componentDidMount() {
        GetAllPubs().then(pubsFromService => {
            this.setState({
                pubs: pubsFromService
            })
        });
    }

    render() {
        if (this.state.pubs.length === 0) { return "Loading..."; }

        var allPubs = this.state.pubs.map(pub => {
            return <Pub key={"pub-key-" + pub.id} pub={pub} />
        });

        return (
            <article>
                <h3>Pubs:</h3>
                <div className="pubs-container">
                    {allPubs}
                </div>
            </article>
        )
    }
}
