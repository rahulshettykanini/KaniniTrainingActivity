import logo from './logo.svg';
import './App.css';
import React, { useEffect, useState } from 'react';
import { BrowserRouter, Routes, Route, Link } from 'react-router-dom';
import Bot from './Components/Bot';
import RegistrationPage from './Components/Register/Register';
import LoginPage from './Components/Login/Login';
import AdminPage from './Components/Admin/Admin';
import { Container, Grid } from '@mui/material';
import NoteCard from './Components/NoteCard';
import HotelCard from './Components/HotelCard';
import ActivityCard from './Components/ActivityCard';
import BookTrip from './Components/BookTrip';
import PackageForm from './Components/PackageForm';
import ItineraryForm from './Components/ItineraryForm';
import HotelForm from './Components/HotelForm';
import axios from 'axios';
import AgentPackages from './Components/AgentPackages';
import neww from './Components/neww';
function App() {
  
const [Id,setId] = useState('');
const [Role,setRole] = useState('');
const [packa,setPackage]=useState('');
const [price,setPrice]=useState('');
const [hotel,setHotel]=useState('');
const [hprice,setHprice]=useState('');
const [dateofBooking, setdateofBooking] = useState('');
const [dateOfTheTrip, setdateOfTheTrip] = useState('');
const [numberOfPeople, setNumberOfPeople] = useState('');
const [pakplace,setpakplace] = useState('');
const [dura,setdura] = useState('');
const [pp,setpp] = useState('');
const [pname,setpname] = useState('');
const [descr,setdescr] = useState('');
const [pimage,setpimage] = useState('');
const [packid,setpackid] = useState('');
const [daynum,setdaynum] = useState('');
const [activi,setactivi] = useState('');
const [time,settime] = useState('');
const [place,setplace] = useState('');
const [iterimage,setiterimage] = useState('');
const [hotelpack,sethotelpack] = useState('');
const [hotname,sethotname] = useState('');
const [hotrating,sethotrating] = useState('');
const [hotpri,sethotpri] = useState('');
const [hotimg,sethotimg] = useState('');
const [selectedValue, setSelectedValue] = useState('');
const [filterplace,setfilterplace] = useState('');
const [pack, setPack] = useState([]);
const [bill, setbill] = useState([]);
const [hotl, setHotl] = useState([]);
const [activity, setActivity] = useState([]);

// const [bookpackage, setbookpackage] = useState({
//   userId: '',
//   dateOfTheTrip: '',
//   dateofBooking: '',
//   numberOfPeople: '',
//   totalAmount: '',
//   packageId: '',
//   hotelId: '',
// });

const handleSubmit = (e) => {
  e.preventDefault();



const bookpackage = {
  userId: Id,
  dateOfTheTrip: dateOfTheTrip,
  dateofBooking: dateofBooking,
  numberOfPeople: numberOfPeople,
  totalAmount: numberOfPeople*(price + hprice),
  packageId: packa,
  hotelId: hotel,
};

axios.post('https://localhost:7112/api/BookingTrips',bookpackage).catch((error) => {
    console.log('Error adding item:', error);
  });
  
fetch('https://localhost:7112/api/BookingTrips/rsbill?user='+Id +'&package='+ packa +'&hotel='+hotel).then(response => response.json()).then(data =>setbill(data))

};

const handleSubmitPackage = (e) => {
  e.preventDefault();

const formpackage = {
  userId: Id,
 place: pakplace,
  duration: dura,
 packagePrice: pp,
  packageName: pname,
  description: descr,
  placeImage: pimage,
};

axios.post('https://localhost:7112/api/Packages',formpackage).catch((error) => {
    console.log('Error adding item:', error);
  });
};


const handleSubmitItinerary = (e) => {
  e.preventDefault();

const formitinerary = {
  packageId: packid,
  dayNumber: daynum,
  activities: activi,
  time:time,
  itineraryPlace:place,
  itineraryImage: iterimage,
};

axios.post('https://localhost:7112/api/ItineraryDetails',formitinerary).catch((error) => {
    console.log('Error adding item:', error);
  });
};


const handleSubmitHotel = (e) => {
  e.preventDefault();

const formhotel = {
  packageId: hotelpack,
 hotelname : hotname,
  hotelRating:hotrating,
  hotelPrice: hotpri,
  hotelsImage: hotimg,
 
};

axios.post('https://localhost:7112/api/Hotels',formhotel).catch((error) => {
    console.log('Error adding item:', error);
  });
};


const filterpackages = () => {

//const [pack, setPack] = useState([]);
const newlist = pack.filter(pa =>pa.packagePrice < selectedValue)
setPack(newlist)
};

const filterplaces = () => {

  //const [pack, setPack] = useState([]);
  const newlist = pack.filter(pa =>pa.place === filterplace)
  setPack(newlist)
  };

useEffect(()=> {
fetch('https://localhost:7112/api/Packages').then(response => response.json()).then(data =>setPack(data))
},[])


const handleSelectChange = (event) => {
  setSelectedValue(parseInt(event.target.value));
};

const handlePackages = (note ,cost) =>
{
  setPackage(note);
  setPrice(cost);
}


const handleHotels = (note ,cost) =>
{
  setHotel(note);
  setHprice(cost);
}


const displayActivity = async () => 
{

 await fetch('https://localhost:7112/api/ItineraryDetails/' + packa + 'activities/').then(response => response.json()).then(data =>setActivity(data))

}



const displayHotels = async () => 
{
  await fetch('https://localhost:7112/api/Hotels/' + packa + 'packhot/').then(response => response.json()).then(data =>setHotl(data))

}



 return (
//     <div className="App">
// <Bot/>
//     </div>
<BrowserRouter>
      <nav>
        <ul>
          <li>
            <Link to="/register">Register</Link>
          </li>
          <li>
            <Link to="/login">Login</Link>
          </li>
          <li>
            <Link to="/admin-approval">Admin Approval</Link>
          </li>
          <li>
    <Link to="/agent">Agent</Link>
  </li>
        </ul>
      </nav>
      <Routes>
        <Route path="/register" element={<RegistrationPage />} />
        <Route path="/login" element={<LoginPage setid ={setId} setRole ={setRole} />} />
        <Route path="/admin-approval" element={<AdminPage />} />
    <Route path="/agent" element={<AgentPackages id={Id}/>} />
      </Routes>
      <div>
        <p>Hello Traveller</p>
        <p>User Id :{Id}</p>
        <p>User Role :{Role}</p>
        <p>Package Id :{packa}</p>
        <p>Package Price :{price}</p>
        <p>Hotel Id :{hotel}</p>
        <p>Hotel Price :{hprice}</p>
        <p>Number  :{numberOfPeople}</p>
      </div>
      
   <div>
       <div>
      <label htmlFor="selectOption">Filter by Price</label>
      <select id="selectOption" value={selectedValue} onChange={handleSelectChange}>
        <option value="">Select an option</option>
        <option value="10000">Less than 10,000</option>
        <option value="20000"> Less than 20,000</option>
        <option value="30000">Less than 30,000</option>
      </select>
    </div>

<div>
  <button onClick={filterpackages}>SEE THE PACKAGES</button>
  </div>
</div>

<div>
  <div>
        <label htmlFor="filterplace">Filter by Place:</label>
      <input
        type="text"
        id='filterplace'
        value={filterplace}
        onChange={(e) => setfilterplace(e.target.value)}
      />
 </div>

 <div>
  <button onClick={filterplaces}>SEE THE PACKAGES</button>
  </div>
</div>

    <Container>
<Grid container spacing={3}>
 {pack.map(pac => (
<Grid item key={pac.packageId} xs={12} md={6} lg={4}>
<NoteCard note={pac} handlePackages={handlePackages}/>
</Grid>
))}
</Grid>
</Container>

<div>

<div>
  <button onClick={displayActivity}>SEE ACTIVITY DETAILS</button>
  </div>

  <div>
<ActivityCard active={activity}  />
</div>

</div>

 
<div className='aaa'>


<div>
<div>
  <button onClick={displayHotels}>SEE HOTEL DETAILS</button>
  </div>

  <Container>
<Grid container spacing={3}>
 {hotl.map(hot => (
<Grid item key={hot.hotelid} xs={12} md={6} lg={4}>
<HotelCard note={hot} handlePackages={handleHotels}/>
</Grid>
))}
</Grid>
</Container>
</div>

<div>

{/* <button>SEE NEW DETAILS</button> */}
<BookTrip handleSubmit={handleSubmit} dateOfTheTrip ={dateOfTheTrip} setdateOfTheTrip ={setdateOfTheTrip} dateofBooking={dateofBooking} setdateofBooking={setdateofBooking}  numberOfPeople={numberOfPeople} setNumberOfPeople={setNumberOfPeople} /> 

</div>

</div>

<div className='aaa'>

<div>

<PackageForm handleSubmitPackage ={handleSubmitPackage} pakplace={pakplace} setpakplace={setpakplace} dura={dura} setdura={setdura} pp={pp} setpp={setpp} pname={pname} setpname={setpname} descr={descr} setdescr={setdescr} pimage={pimage} setpimage={setpimage} /> 

</div>

<div>

<ItineraryForm  handleSubmitItinerary={handleSubmitItinerary} packid={packid} setpackid={setpackid} daynum={daynum} setdaynum={setdaynum} activi={activi} setactivi={setactivi} time={time} settime={settime} place={place} setplace={setplace} iterimage={iterimage} setiterimage={setiterimage} /> 

</div>

<div>

<HotelForm  handleSubmitHotel={handleSubmitHotel} hotelpack={hotelpack} sethotelpack={sethotelpack} hotname={hotname} sethotname={sethotname} hotrating={hotrating} sethotrating={sethotrating} hotpri={hotpri} sethotpri={sethotpri} hotimg={hotimg} sethotimg={sethotimg} /> 

</div>
  </div>


 

    </BrowserRouter>
  );
}

export default App;
