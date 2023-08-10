import React from 'react';
import {Card} from '@mui/material';
import {CardHeader} from '@mui/material';
import {CardContent} from '@mui/material';
import { IconButton, Typography } from '@mui/material';
import CheckCircleOutlineOutlinedIcon from '@mui/icons-material/CheckCircleOutlineOutlined';

export default function NoteCard({note,handlePackages})
{
    return (
   <div>
<Card elevation={2}>

<CardHeader
action = {
<IconButton onClick={()=>handlePackages(note.packageId,note.packagePrice)}>
<CheckCircleOutlineOutlinedIcon/>
</IconButton>
}
title ={note.packageName}
subheader={note.place}
/>
<CardContent>
    <Typography variant="h1" color="textSecondary">
{note.packagePrice}
    </Typography>
    <Typography variant="h2" color="textSecondary">
{note.duration}
    </Typography>
    <Typography variant="h2" color="textSecondary">
{note.place}
    </Typography>
    <Typography variant="body2" color="textSecondary">
{note.description}
    </Typography>
</CardContent>
</Card>
   </div>


    )
}
