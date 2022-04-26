import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import "./App.css";
import Home from "./Pages/Home";
import Navbar from "./Components/Navbar";
import Contact from "./Pages/Contact";
import Projects from "./Pages/Projects";
import Resume from "./Pages/Resume";




function App() {
  return (
    <Router>
      <div className = "App">
     <Navbar />

      <Routes>
      <Route path="/" element={<Home />} />
        
      <Route path="/Home" element={<Home />} />

      <Route path="/Contact" element={<Contact />} />

      <Route path="/Projects" element={<Projects />} />

      <Route path="/Resume" element={<Resume />} />
        
        
      </Routes>
      </div>
     
    </Router>
  );
}
export default App;