import React from 'react';
import {Card} from '@mui/material';
import {CardHeader} from '@mui/material';
import {CardContent} from '@mui/material';
import { IconButton, Typography } from '@mui/material';
import CheckCircleOutlineOutlinedIcon from '@mui/icons-material/CheckCircleOutlineOutlined';

export default function HotelCard({note,handlePackages})
{
    return (
   <div>
<Card elevation={2}>

<CardHeader
action = {
<IconButton onClick={()=>handlePackages(note.hotelid,note.hotelPrice)}>
<CheckCircleOutlineOutlinedIcon/>
</IconButton>
}
title ={note.hotelname}
/>
<CardContent>
    <Typography variant="h1" color="textSecondary">
{note.hotelPrice}
    </Typography>
    <Typography variant="h2" color="textSecondary">
{note.hotelRating}
    </Typography>
    <Typography variant="h2" color="textSecondary">
{note.hotelsImage}
    </Typography>
</CardContent>
</Card>
   </div>


    )
}
