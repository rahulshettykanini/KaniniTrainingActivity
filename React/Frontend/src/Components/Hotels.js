import React from 'react';
import HotelCard from './HotelCard';
import { Container, Grid } from '@mui/material';
function Hotels({ displayHotels,hotl,handleHotels,cond}) {
  return ( 
<div>
<div style={{ textAlign: 'center', marginBottom: '20px' , marginTop: '20px'}}>
      <button onClick={displayHotels}  style={{
            backgroundColor: 'green',
            color: 'white',
            border: 'none',
            padding: '10px 20px',
            borderRadius: '5px',
            cursor: 'pointer',
          }}>SEE HOTEL DETAILS</button>
      </div>
      if ({cond} == 1) {
<Container>
    <Grid container spacing={3}>
     {hotl.map(hot => (
    <Grid item key={hot.hotelid} xs={12} md={6} lg={4}>
    <HotelCard note={hot} handlePackages={handleHotels}/>
    </Grid>
    ))}
    </Grid>
    </Container>
}
</div>

);
}

export default Hotels;