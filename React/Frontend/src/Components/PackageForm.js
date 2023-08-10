import React from 'react';

import { AppBar, Toolbar, Typography,IconButton,Button,  Card, CardMedia} from '@mui/material';

function PackageForm({ handleSubmitPackage ,pakplace,setpakplace ,dura,setdura, pp, setpp ,pname,setpname, descr ,setdescr,pimage,setpimage}) {
  
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

    <form onSubmit={handleSubmitPackage}  style={{ textAlign: 'center' }}>

<div style={{ marginTop: '20px'}}>
        <label htmlFor="place">Place:</label>
      <input
        type="text"
        id='place'
        value={pakplace}
        style={inputBoxStyle}
        onChange={(e) => setpakplace(e.target.value)}
      />
 </div>

 <div>
<label htmlFor="duration">Duration:</label>
      <input
        type="number"
        id='duration'
        value={dura}
        style={inputBoxStyle}
        onChange={(e) => setdura(e.target.value)}
      />
 </div>

 <div>
<label htmlFor="price">Package Price:</label>
       <input
        type="number"
        id='price'
        value={pp}
        style={inputBoxStyle}
        onChange={(e) => setpp(parseInt(e.target.value))}
 />
 </div>

<div>
<label htmlFor="name">Package Name:</label>
       <input
        type="text"
        id='name'
        value={pname}
        style={inputBoxStyle}
        onChange={(e) => setpname(e.target.value)}
      />
       </div>
      
      <div>
      <label htmlFor="description">Description:</label>
      <input
       type="text"
       id='description'
       value={descr}
       style={inputBoxStyle}
       onChange={(e) => setdescr(e.target.value)}
     />
 </div>

 <div>
<label htmlFor="image">Package Image:</label>
       <input
        type="text"      
       id='image'
        value={pimage}
        style={inputBoxStyle}
        onChange={(e) => setpimage(e.target.value)}
      />
 </div>

      <button type="submit" style={{
            backgroundColor: 'green',
            color: 'white',
            border: 'none',
            padding: '10px 20px',
            borderRadius: '5px',
            cursor: 'pointer',
          }}>ADD A PACKAGE</button>
    </form>

    </div>
  );
}

export default PackageForm;