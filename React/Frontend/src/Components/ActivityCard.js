import { Container, Grid, Table, TableBody, TableCell, TableContainer, TableHead, TableRow } from '@mui/material';
import React from 'react';

function ActivityCard({ active }) {
  return (
    <Container>
      <TableContainer>
        <Table>
          <TableHead>
            <TableRow>
              <TableCell>DAY NUMBER</TableCell>
              <TableCell>ACTIVITIES</TableCell>
              <TableCell>TIME</TableCell>
              <TableCell>LOCATION</TableCell>
              {/* Add more table headers if needed */}
            </TableRow>
          </TableHead>
          <TableBody>
            {active.map((act) => (
              <TableRow key={act.itineraryId}>
                <TableCell>{act.dayNumber}</TableCell>
                <TableCell>{act.activities}</TableCell>
                <TableCell>{act.time}</TableCell>
                <TableCell>{act.itineraryPlace}</TableCell>
                {/* Add more table cells with corresponding data */}
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
    </Container>
  );
}

export default ActivityCard;




