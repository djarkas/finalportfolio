import React from 'react';
import Pdf from '../JARKAS_DINA_RESUMEPORTFOLIO.pdf';




const Resume = () => {
return(
   <>
   
   
   <section id="hero">
		<div className="hero-stuff">
			
        <div className = "App">
        <a href = {Pdf} target = "_blank" type = "button" class = "resumetarget"> Click to View My Resume</a>
        </div>
        
		</div>
	</section>

   
   
   
   
   </>
)
}
   

export default Resume;