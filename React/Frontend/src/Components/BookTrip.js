import React ,{useState} from 'react';

function BookTrip({ handleSubmit ,dateOfTheTrip ,setdateOfTheTrip ,dateofBooking ,setdateofBooking , numberOfPeople , setNumberOfPeople}) {
 
  const [currentDateTime] = useState(new Date().toISOString().slice(0, 16));

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

    <form onSubmit={handleSubmit}  style={{ textAlign: 'center' }}>
      
<div style={{ marginTop: '20px'}}>
        <label htmlFor="tou" style={inputLabelStyle}>Date of Tour:</label>
      <input
      id='tou'
        type="date"
        value={dateOfTheTrip}
        style={inputBoxStyle}
        onChange={(e) => setdateOfTheTrip(e.target.value)}
      />
</div>

<div  >
        <label htmlFor="boo" style={inputLabelStyle}>Date Of Booking:</label>
      <input
      id='boo'
        type="datetime-local"
        value={dateofBooking || currentDateTime}
        style={inputBoxStyle}
        onChange={(e) => setdateofBooking(e.target.value)}
      />
</div>

<div>
        <label htmlFor="num" style={inputLabelStyle}>Number Of People:</label>
       <input
       id='num'
        type="number"
        value={numberOfPeople}
        style={inputBoxStyle}
        onChange={(e) => setNumberOfPeople(parseInt(e.target.value))}
      />
</div>
<div style={{ textAlign: 'center', marginBottom: '20px' , marginTop: '20px'}}>
      <button type="submit" style={{
            backgroundColor: 'green',
            color: 'white',
            border: 'none',
            padding: '10px 20px',
            borderRadius: '5px',
            cursor: 'pointer',
          }}>BOOK YOUR TRIP</button>
          </div>
    </form>

    
  );
}

export default BookTrip;