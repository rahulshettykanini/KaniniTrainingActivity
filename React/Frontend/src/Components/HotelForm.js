import React from 'react';
import Travel from '../Assets/travel1.jpg'
import { AppBar, Toolbar, Typography,IconButton,Button,  Card, CardMedia} from '@mui/material';
function HotelForm({ handleSubmitHotel ,hotelpack ,sethotelpack ,hotname ,sethotname,hotrating , sethotrating, hotpri, sethotpri,hotimg,sethotimg}) {
 
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
    image={Travel}
    alt="Travel destination"
  />
  <Typography variant="h5" align="center" sx={{ padding: '16px' }}>
    Beautiful Travel Destination
  </Typography>
</Card>

    <form onSubmit={handleSubmitHotel}  style={{ textAlign: 'center' }}>

<div style={{ marginTop: '20px'}}>       
<label htmlFor="id">Package Id:</label>
      <input
        type="number"
        id='id'
        value={hotelpack}
        style={inputBoxStyle}
        onChange={(e) => sethotelpack(parseInt(e.target.value))}
      />
      </div>

<div>
<label htmlFor="name">Hotel Name:</label>
      <input
        type="text"
        id='name'
        value={hotname}
        style={inputBoxStyle}
        onChange={(e) => sethotname(e.target.value)}
      />
       </div>

<div>
<label htmlFor="rating">Hotel Rating:</label>
       <input
        type="number"
        id='rating'
        value={hotrating}
        style={inputBoxStyle}
        onChange={(e) => sethotrating(parseInt(e.target.value))}
      />
 </div>

<div>
<label htmlFor="price">Hotel Price:</label>
<input
        type="number"
        id='price'
        value={hotpri}
        style={inputBoxStyle}
        onChange={(e) => sethotpri(parseInt(e.target.value))}
      />
 </div>

<div>
<label htmlFor="image">Hotel Image:</label>
<input
        type="text"
        id='image'
        value={hotimg}
        style={inputBoxStyle}
        onChange={(e) => sethotimg(e.target.value)}
      />
</div>

      <button type="submit" style={{
            backgroundColor: 'green',
            color: 'white',
            border: 'none',
            padding: '10px 20px',
            borderRadius: '5px',
            cursor: 'pointer',
          }}>ADD A HOTEL</button>
    </form>
</div>
    
  );
}

export default HotelForm;