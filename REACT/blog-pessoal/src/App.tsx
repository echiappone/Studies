import React from 'react';
import { BrowserRouter as Router, Route, Routes} from 'react-router-dom';
import Navbar from './components/estaticos/navbar/Navbar';
import Footer from './components/estaticos/footer/Footer';
import Home from "./paginas/home/Home"
import Login from './paginas/login/Login';
import './App.css';

function App() {
  return(
    <Router>
      <Navbar />
      <div style={{ minHeight: '100vh' }}>

        {/*Antigo Switch*/}
        <Routes>
          
          <Route path="/" element={<Login />} />
          <Route path="/login" element={<Login />} />
          <Route path="/home" element={<Home />} />
          <Route path="/postagens" element={<Home />} />

        </Routes>
      </div>
      <Footer />
    </Router>
  );
}

export default App;