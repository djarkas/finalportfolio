import React, {useState} from 'react';
import '../App.css';



function Navbar() {
const[showLinks, setShowLinks] = useState(false);

    return(
        <div className = "Navbar">
            
             <div className = "leftSide">
             <header>Dina Jarkas </header>
             </div>
             <div className = "rightSide">
               
                 <nav className = "links" id={showLinks ? "hide" : ""}>
                 <a href= "/Home" >Profile</a>
                 <a href = "/Projects" >Projects</a>
                 <a href = "/Contact" >Contact</a>
                 <a href = "/Resume" >Resume</a>
                 </nav>
                <button onClick={()=> setShowLinks (!showLinks)}> <img src = "images/dots.png"/></button>
             </div>

        </div>
    )
}

export default Navbar



