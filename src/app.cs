@charset "UTF-8";
.mepic {
  float: center;
  width: 100%;
  max-width: 400px;
  height: auto;
  display: block;
  margin-left: auto;
  margin-right: auto;
  width: 50%;
  border-radius: 50%;
}

.ptag {
  font-family: Andale Mono, monospace;
  font-size: 20px;
}

.mytitle {
  color: #006666;
  font-family: Andale Mono, monospace;
  font-size: 30px;
}

.boxie {
  width: auto;
  border: 5px solid #9dbcbc;
  padding: 50px;
  margin: auto;
  background-color: #e2e8ec;
}

.App {
  width: 100%;
  height: 100%;
}

/*this is  navbar*/
.Navbar {
  background-color: #9dbcbc;
  width: 100%;
  height: 80px;
  font: Arial;
  display: flex;
  margin-bottom: 30px;
}

.Navbar .leftSide {
  flex: 50%;
  text-decoration: none;
  color: #f5f4ea;
  font-size: 40px;
  margin-right: 15px;
  font-family: Andale Mono, monospace;
  flex: 50%;
  display: flex;
  justify-content: left;
  align-items: center;
}

.Navbar .rightSide {
  flex: 50%;
  display: flex;
  justify-content: right;
  align-items: center;
}

.Navbar .rightSide .links {
  max-height: 80px;
}

.Navbar .rightSide .links a {
  text-decoration: none;
  color: #f5f4ea;
  font-size: 25px;
  margin-right: 15px;
  font-family: Andale Mono, monospace;
}

.Navbar .rightSide button {
  display: none;
  margin-right: 20px;
}

.Navbar .rightSide #hide {
  display: flex;
}

@media only screen and (max-width: 850px) {
  .Navbar .rightSide .links a {
    font-size: 20px;
  }
}
@media only screen and (max-width: 750px) {
  .Navbar .rightSide .links a {
    font-size: 15px;
  }
}
@media only screen and (max-width: 750px) {
  .Navbar .rightSide button {
    display: flex;
  }

  .Navbar .rightSide .links {
    display: none;
  }

  .Navbar .rightSide #hide {
    position: absolute;
    right: 0px;
    top: 80px;
    height: 230px;
    max-height: 230px;
    width: 100%;
    background-color: #9dbcbc;
    display: flex;
    flex-direction: column;
    align-items: center;
  }

  .Navbar .rightSide #hide a {
    margin: 10px;
    font-size: 25px;
    font-family: Andale Mono, monospace;
  }
}
/*contact*/
.contacthead {
  font-size: 40px;
  color: #f5f4ea;
  font-family: Andale Mono, monospace;
}

.con {
  display: flex;
  flex-direction: column;
  align-items: center;
  width: 500px;
  margin: 15vh auto;
  padding: 15px;
  border: none;
  box-shadow: 0 0 15px #f5f4ea;
  background-color: #9dbcbc;
}

form {
  display: flex;
  flex-direction: column;
  align-items: center;
  width: 90%;
  background-color: #9dbcbc;
}

input {
  width: 100%;
  margin: 5px 0;
  height: 35px;
  font-size: 17px;
  text-align: center;
  outline: none;
  font-family: Andale Mono, monospace;
  border: none;
  background: #b7b7b7;
}

textarea {
  width: 100%;
  margin: 5px 0;
  font-size: 17px;
  text-align: center;
  outline: none;
  font-family: Andale Mono, monospace;
  border: none;
  background: #b7b7b7;
}

.cbut {
  margin: 10px auto;
  width: 120px;
  background: #f5f4ea;
  color: #9dbcbc;
  cursor: pointer;
  font-family: Andale Mono, monospace;
}

.cbut:hover {
  background: #f5f4ea;
}

@media screen and (max-width: 600px) {
  .con {
    width: 90%;
  }
}
.formtext {
  font-size: 20px;
  color: #f5f4ea;
  font-family: Andale Mono, monospace;
}

.ordermobproject {
  width: 100%;
  max-width: 400px;
  height: auto;
  display: block;
  margin-left: auto;
  margin-right: auto;
  width: 50%;
}

.projectflex {
  display: flex;
  flex-direction: column;
  justify-content: center;
  flex-grow: 1;
  gap: 30px;
}

.ordermobproject {
  display: grid;
  overflow: hidden;
  width: 100%;
  height: 300px;
  box-shadow: 0 0 40px black;
}

.ordermobproject img {
  width: 100%;
  grid-area: 1/1/span 1/span 1;
  transition: 0.3s ease-out;
}

.ordermobproject:hover img {
  transform: scale(1.2, 1.2);
}

.projectsok {
  width: 100%;
  max-width: 400px;
  height: auto;
  display: block;
  margin-left: auto;
  margin-right: auto;
}

.projectsok {
  display: grid;
  overflow: hidden;
  width: 100%;
  height: 300px;
  box-shadow: 0 0 40px black;
}

.projectsok img {
  width: 100%;
  grid-area: 1/1/span 1/span 1;
  transition: 0.3s ease-out;
}

.projectsok:hover img {
  transform: scale(1.2, 1.2);
}

.boxy {
  width: auto;
  border: 5px solid #9dbcbc;
  padding: 50px;
  margin: auto;
  background-color: #e2e8ec;
}

.projname {
  color: #006666;
  font-family: Andale Mono, monospace;
}

.hired {
  font-family: Andale Mono, monospace;
  font-size: 15px;
}

.title {
  font-family: Andale Mono, monospace;
  color: #006666;
  font-size: 40px;
  width: 100%;
  text-align: center;
  border-bottom: 3px solid #9dbcbc;
  line-height: 0.1em;
  margin: 10px 0 20px;
}

.title span {
  background: #fff;
  padding: 0 10px;
}

#hero {
  background: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), url("coffee.jpeg");
  height: 30%;
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
  padding: 150px 30px;
  text-align: center;
  font-size: 36px;
}

#hero .hero-stuff {
  position: relative;
}

.resumebtn {
  margin: 30px 90px;
  text-align: center;
  font-size: 30px;
  color: #01937C;
  border-radius: 5px;
  box-sizing: border-box;
  font-family: ‘Libre Baskerville’, serif;
}

/*# sourceMappingURL=app.cs.map */
