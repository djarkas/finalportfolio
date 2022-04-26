import React, { useState } from "react";
import Axios from "axios";

const Contact = () => {
    const [fName, setfName] = useState("");
    const [lName, setlName] = useState("");
    const [email, setemail] = useState("");
    const [message, setmessage] = useState("");
  
    const submitForm = (e) => {
    
      Axios.post("http://localhost:3001/api/insert", {
        firstName: fName,
        lastName: lName,
        email: email,
        message: message,
      }).then(() => {
        console.log("succesful insert");
      });
    };

    

  return (

    
      <section className="con">
      <h1 className = "contacthead">Contact Me</h1>

      <form>
    
      <div>
        <label className = "formtext" htmlFor="fName">First Name:</label>
        <input placeholder=" Your First Name" type="text" id="fName" required />
      </div>
      <div>
        <label className = "formtext" htmlFor="lName">Last Name:</label>
        <input  placeholder=" Your Last Name" type="text" id="lName" required />
      </div>
      <div>
        <label className = "formtext" htmlFor="email">Email:</label>
        <input placeholder="Email" type="email" id="Your Email" required />
      </div>
      <div>
        <label className = "formtext" htmlFor="message">Message:</label>
        <textarea placeholder="Leave me a message here" id="message" required />
      </div>
      <button class = "cbut" type="submit" onclick="submitForm()">Submit</button>
    
     
    </form>
    
    
    </section>
  );
};

export default Contact;