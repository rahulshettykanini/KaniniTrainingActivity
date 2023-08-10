
import React, { useEffect, useState } from 'react';
import { Container, Grid } from '@mui/material';
// import NoteCard from './Components/NoteCard';
// import HotelCard from './Components/HotelCard';
// import ActivityCard from './Components/ActivityCard';
import NoteCard from './NoteCard';
import HotelCard from './HotelCard';
import ActivityCard from './ActivityCard';

function Traveller({ selectedValue , handleSelectChange ,filterpackages,filterplaces ,hotl, setPack,pack,filterplace, setfilterplace,
    handlePackages , displayActivity,activity,displayHotels, handleHotels}) {
     
   
    
     return (
    <div>
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
    
      
    
    <div>
    
    <div>
      <button onClick={displayActivity}>SEE ACTIVITY DETAILS</button>
      </div>
    
      <div>
    <ActivityCard active={activity}  />
    </div>
    
    </div>
    
     
    /* <div className='aaa'>
    
    
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
    </div> 
    </div>
    
    );
    }
    export default Traveller;
    