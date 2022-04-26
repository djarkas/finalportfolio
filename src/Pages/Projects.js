import React from 'react';



const Projects = () => {
return(
   <>
   
   
   <h1 className = "title"> <span> Projects</span></h1>
   
   <div className = "projectflex">

<div className = "boxy">
   <a  className = "ordermobproject" href="http://theordermob.com/" > <img  src= "images/orderm.jpeg" alt = "Order Mob" 
/>  
</a>
<h2 className = "projname"> HOPEHACKS</h2>
<h3 className = "hired">R2H Apprenticeship</h3>
</div>

<div className = "boxy">
<a className= "projectsok" href="https://avpenny.herokuapp.com/"> <img src= "images/penny.jpeg" alt = "Penny Juice" 
/>  
</a>
<h2 className = "projname"> Website Redesign </h2>
<h3 className = "hired">R2H Apprenticeship</h3>
</div>

<div className = "boxy">
<a className= "projectsok" href="https://drip-ecommerce.herokuapp.com"> <img src= "images/drip.jpeg" alt = "Drip Boutique" 
/>  
</a>
<h2 className = "projname"> eCommerce</h2>
<h3 className = "hired">R2H Apprenticeship</h3>
</div>


<div className = "boxy">
<a   className= "projectsok" href="https://djarkas.github.io/SIJW/"> <img src= "images/sociali.jpeg" alt = "Social Injustice" 
/>  
</a>
<h2 className = "projname"> Social Injustice</h2>
<h3 className = "hired">R2H Apprenticeship</h3>
</div>


<div className = "boxy">
<a   className= "projectsok" href="https://gateway-project-redesign.djarkas.repl.co/"> <img src= "images/prague.jpeg" alt = "Project Redesign" 
/>  
</a>
<h2 className = "projname"> GateWay </h2>
<h3 className = "hired">R2H Apprenticeship</h3>
</div>


</div>

   
   </>
)
}
   

export default Projects;