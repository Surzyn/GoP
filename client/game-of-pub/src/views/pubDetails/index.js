import React, { Component } from 'react'

import { GetPub } from '../../services/pubService'

export default class PubDetails extends Component {
    constructor(props) {
        super(props);

        this.state = { pub: null };
    }

    componentDidMount() {
        GetPub(this.props.match.params.pubId).then(pubFromService => {
            this.setState({
                pub: pubFromService
            });
        });
    }



    render() {
        if (!this.state.pub) { return "Loading..."; }

        var pub = this.state.pub;
        var comments = pub.comments.map(comment => {
            return (
                <div>
                    <span>{comment.text}</span> <small>{comment.creationDate}</small>
                </div>
            )
        });

        return (
            <div>
                <h3>PubDetails: {pub.name}</h3>
                <img src={pub.images[0].imageUrl} alt="nice photos" />
                <h5>{pub.description}</h5>
                <small>Street: {pub.street}</small>
                <section>
                    {comments}
                </section>
            </div>
        )
    }
}