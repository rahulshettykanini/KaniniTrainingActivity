
import React, { useEffect, useState } from 'react';
import NoteCard from './NoteCard';
import { TextField, Button, Box } from '@mui/material';
import { Container, Grid } from '@mui/material';



function Package({pack, selectedValue,handleSelectChange,filterpackages,filterplace, filterplaces,setfilterplace,handlePackages}) {
  
 return ( 
<div>
<div>
          
           <div style={{ textAlign: 'center', marginBottom: '20px' }}>
       
          <label htmlFor="selectOption">Filter by Price</label>
          <select id="selectOption" value={selectedValue} onChange={handleSelectChange}>
            <option value="">Select an option</option>
            <option value="10000">Less than 10,000</option>
            <option value="20000"> Less than 20,000</option>
            <option value="30000">Less than 30,000</option>
          </select>
    <div style={{ textAlign: 'center', marginBottom: '20px' , marginTop: '20px'}}>
      <button variant="contained"  onClick={filterpackages}  style={{
            backgroundColor: 'green',
            color: 'white',
            border: 'none',
            padding: '10px 20px',
            borderRadius: '5px',
            cursor: 'pointer',
          }}>SEE THE PACKAGES</button>
      </div>
    </div>
    </div>
    
    <div style={{ textAlign: 'center', marginBottom: '20px' }}>
     
      <div>
            <label htmlFor="filterplace">Filter by Place:</label>
          <input
            type="text"
            id='filterplace'
            value={filterplace}
            onChange={(e) => setfilterplace(e.target.value)}
          />
     </div>
    
     <div style={{ textAlign: 'center', marginBottom: '20px' , marginTop: '20px'}}>
      <button variant="contained" 
          onClick={filterplaces} style={{
            backgroundColor: 'green',
            color: 'white',
            border: 'none',
            padding: '10px 20px',
            borderRadius: '5px',
            cursor: 'pointer',
          }}>SEE THE PACKAGES</button>
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

</div>

);
}

export default Package;