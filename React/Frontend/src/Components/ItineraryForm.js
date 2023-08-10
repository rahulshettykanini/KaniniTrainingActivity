import React from 'react';

import { AppBar, Toolbar, Typography,IconButton,Button,  Card, CardMedia} from '@mui/material';
function ItineraryForm({ handleSubmitItinerary ,packid ,setpackid ,daynum ,setdaynum ,activi , setactivi, time,settime,place,setplace,iterimage,setiterimage}) {
 
  const inputLabelStyle = {
    fontSize: '16px',
    marginBottom: '8px',
  };

  const inputBoxStyle = {
    fontSize: '16px',
    padding: '8px',
    borderRadius: '5px',
    border: '1px solid #ccc',
    marginBottom: '16px',
  };
 
  return ( 


    <div>
    <Card>
  <CardMedia
    component="img"
    height="300"
    image="https://e1.pxfuel.com/desktop-wallpaper/450/991/desktop-wallpaper-leh-ladakh-ladakh.jpg"
    alt="Travel destination"
  />
  <Typography variant="h5" align="center" sx={{ padding: '16px' }}>
    Beautiful Travel Destination
  </Typography>
</Card>

    <form onSubmit={handleSubmitItinerary}  style={{ textAlign: 'center' }}>
    <div style={{ marginTop: '20px'}}>
        <label htmlFor="id">Package Id:</label>
      <input
        type="number"
        id='id'
        value={packid}
        style={inputBoxStyle}
        onChange={(e) => setpackid(parseInt(e.target.value))}
      />
 </div>

 <div>
<label htmlFor="num">Day Number:</label>
      <input
        type="number"
        id='num'
        value={daynum}
        style={inputBoxStyle}
        onChange={(e) => setdaynum(e.target.value)}
      />
 </div>

 <div>
<label htmlFor="activity">Activity:</label>
       <input
        type="text"
        id='activity'
        value={activi}
        style={inputBoxStyle}
        onChange={(e) => setactivi(e.target.value)}
 />
 </div>

<div>
<label htmlFor="time">Time:</label>
       <input
        type="time"
        id='time'
        value={time}
        style={inputBoxStyle}
        onChange={(e) => settime(e.target.value)}
      />
       </div>
      
      <div>
      <label htmlFor="place">Place:</label>
      <input
       type="text"
       id='place'
       value={place}
       style={inputBoxStyle}
       onChange={(e) => setplace(e.target.value)}
     />
 </div>

 <div>
<label htmlFor="image">Image:</label>
       <input
        type="text"      
       id='image'
        value={iterimage}
        style={inputBoxStyle}
        onChange={(e) => setiterimage(e.target.value)}
      />
 </div>

      <button type="submit" style={{
            backgroundColor: 'green',
            color: 'white',
            border: 'none',
            padding: '10px 20px',
            borderRadius: '5px',
            cursor: 'pointer',
          }}>ADD A ITINERARY</button>
    </form>
</div>
    
  );
}

export default ItineraryForm;