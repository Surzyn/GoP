import React from 'react'
import { Link } from 'react-router-dom'
import './pub.css'

const IMG_PLACEHOLDER = "https://assets.publishing.service.gov.uk/government/uploads/system/uploads/default_news_organisation_image_data/file/375/s300_Beer_pumps_and_Glasses_graphic__1_.jpg";

const Pub = ({ pub }) => {

    return (
        <Link to={"/pub/" + pub.id} className="pub-card">
            <h4>{pub.name} <span>{pub.rate}/10</span></h4>
            <img src={pub.image.length > 0 ? pub.image[0].imageUrl : IMG_PLACEHOLDER} alt="nice photos" />
            <h5>{pub.description}</h5>
            <small>Street: {pub.street}</small>
        </Link>
    )
}


export default Pub;