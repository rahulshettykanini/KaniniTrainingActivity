import React, { useState } from 'react';
import {
  Container,
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
} from '@mui/material';
function AgentPackages({
  id,
  handleSubmitPackage,
  pakplace,
  setpakplace,
  dura,
  setdura,
  pp,
  setpp,
  pname,
  setpname,
  descr,
  setdescr,
  pimage,
  setpimage,
}) {
  const [ac, setac] = useState([]);
  const [bc, setbc] = useState([]);
  const [cc, setcc] = useState([]);

  const [showPackages, setShowPackages] = useState(false);
  const [showBookings, setShowBookings] = useState(false);
  const [showHotels, setShowHotels] = useState(false);

  const AgentPackagess = async () => {
    await fetch('https://localhost:7112/api/Packages/' + id + 'agepac')
      .then((response) => response.json())
      .then((data) => setac(data));
    setShowPackages(true);
    setShowBookings(false);
    setShowHotels(false);
  };

  const AgentBookings = async () => {
    await fetch('https://localhost:7112/api/BookingTrips/' + id + 'agent')
      .then((response) => response.json())
      .then((data) => setbc(data));
    setShowPackages(false);
    setShowBookings(true);
    setShowHotels(false);
  };

  const AgentHotels = async () => {
    await fetch('https://localhost:7112/api/Hotels/' + id + 'agenthotel')
      .then((response) => response.json())
      .then((data) => setcc(data));
    setShowPackages(false);
    setShowBookings(false);
    setShowHotels(true);
  };

  return (
    <div>
     <div style={{ display: 'flex', justifyContent: 'center', marginTop: '20px' }}>
        <div style={{ marginTop: '20px' }}>
          <button
            onClick={AgentPackagess}
            style={{
              backgroundColor: showPackages ? 'green' : 'grey',
              color: 'white',
              border: 'none',
              padding: '10px 20px',
              borderRadius: '5px',
              cursor: 'pointer',
              marginRight: '20px',
            }}
          >
            SEE  PACKAGES
          </button>
        </div>

        <div style={{ marginTop: '20px' }}>
          <button
            onClick={AgentBookings}
            style={{
              backgroundColor: showBookings ? 'green' : 'grey',
              color: 'white',
              border: 'none',
              padding: '10px 20px',
              borderRadius: '5px',
              cursor: 'pointer',
              marginRight: '20px',
            }}
          >
            TOUR BOOKINGS
          </button>
        </div>

        <div style={{ marginTop: '20px' }}>
          <button
            onClick={AgentHotels}
            style={{
              backgroundColor: showHotels ? 'green' : 'grey',
              color: 'white',
              border: 'none',
              padding: '10px 20px',
              borderRadius: '5px',
              cursor: 'pointer',
              marginRight: '20px',
            }}
          >
            SEE HOTELS
          </button>
        </div>
      </div>

      {showPackages && (
        <div>
          <Container>
            <TableContainer>
              <Table>
                <TableHead>
                  <TableRow>
                    <TableCell>PACKAGE ID</TableCell>
                    <TableCell>PACKAGE NAME</TableCell>
                    <TableCell>PACKAGE PLACE</TableCell>
                    <TableCell>PACKAGE DURATION</TableCell>
                    <TableCell>PACKAGE PRICE</TableCell>
                    <TableCell>PACKAGE DESCRIPTION</TableCell>
                    {/* Add more table headers if needed */}
                  </TableRow>
                </TableHead>
                <TableBody>
                  {ac.map((act) => (
                    <TableRow key={act.packageId}>
                      <TableCell>{act.packageId}</TableCell>
                      <TableCell>{act.packageName}</TableCell>
                      <TableCell>{act.place}</TableCell>
                      <TableCell>{act.duration}</TableCell>
                      <TableCell>{act.packagePrice}</TableCell>
                      <TableCell>{act.description}</TableCell>
                      {/* Add more table cells with corresponding data */}
                    </TableRow>
                  ))}
                </TableBody>
              </Table>
            </TableContainer>
          </Container>
        </div>
      )}

      {showBookings && (
        <div>
          <Container>
            <TableContainer>
              <Table>
                <TableHead>
                  <TableRow>
                    <TableCell> NAME</TableCell>
                    <TableCell>EMAIL ID</TableCell>
                    <TableCell>ADDRESS</TableCell>
                    <TableCell>PACKAGE NAME</TableCell>
                    <TableCell>HOTEL NAME</TableCell>
                    <TableCell>TOUR DATE</TableCell>
                    <TableCell>BOOKING DATE</TableCell>
                    <TableCell>NUMBER OF TOURISTS</TableCell>
                    <TableCell>TOTAL AMOUNT</TableCell>
                    {/* Add more table headers if needed */}
                  </TableRow>
                </TableHead>
                <TableBody>
                  {bc.map((bct) => (
                    <TableRow key={bct.name}>
                      <TableCell>{bct.name}</TableCell>
                      <TableCell>{bct.email}</TableCell>
                      <TableCell>{bct.address}</TableCell>
                      <TableCell>{bct.packageName}</TableCell>
                      <TableCell>{bct.hotelname}</TableCell>
                      <TableCell>{bct.dateOfTheTrip}</TableCell>
                      <TableCell>{bct.dateofBooking}</TableCell>
                      <TableCell>{bct.numberOfPeople}</TableCell>
                      <TableCell>{bct.totalAmount}</TableCell>
                      {/* Add more table cells with corresponding data */}
                    </TableRow>
                  ))}
                </TableBody>
              </Table>
            </TableContainer>
          </Container>
        </div>
      )}

      {showHotels && (
        <div>
          <Container>
            <TableContainer>
              <Table>
                <TableHead>
                  <TableRow>
                    <TableCell> HOTEL NAME</TableCell>
                    <TableCell>PACKAGE ID</TableCell>
                    <TableCell>HOTEL RATING</TableCell>
                    <TableCell>HOTEL PRICE</TableCell>
                    {/* Add more table headers if needed */}
                  </TableRow>
                </TableHead>
                <TableBody>
                  {cc.map((cct) => (
                    <TableRow key={cct.hotelid}>
                      <TableCell>{cct.hotelname}</TableCell>
                      <TableCell>{cct.packageId}</TableCell>
                      <TableCell>{cct.hotelRating}</TableCell>
                      <TableCell>{cct.hotelPrice}</TableCell>
                      {/* Add more table cells with corresponding data */}
                    </TableRow>
                  ))}
                </TableBody>
              </Table>
            </TableContainer>
          </Container>
        </div>
      )}
    </div>
  );
}

export default AgentPackages;
