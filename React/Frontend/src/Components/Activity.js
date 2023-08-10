import React from 'react';
import ActivityCard from './ActivityCard';
function Activity({displayActivity ,activity }) {
  return ( 
<div>
<div style={{ textAlign: 'center', marginBottom: '20px' , marginTop: '20px'}}>
    
      <button onClick={displayActivity}    style={{
            backgroundColor: 'green',
            color: 'white',
            border: 'none',
            padding: '10px 20px',
            borderRadius: '5px',
            cursor: 'pointer',
          }}>SEE ACTIVITY DETAILS</button>
      </div>
<div>
    <ActivityCard active={activity}  />
    </div>

    </div>



);
}

export default Activity;