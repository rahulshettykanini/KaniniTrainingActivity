
import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import AppBar from '@mui/material/AppBar';
import Toolbar from '@mui/material/Toolbar';
import Typography from '@mui/material/Typography';
import Button from '@mui/material/Button';
import { styled } from '@mui/system';

const CustomAppBar = styled(AppBar)({
  backgroundColor: 'transparent',
  boxShadow: 'none',
  color: 'black',
  position: 'absolute',
  top: 0,
  zIndex: 2,
});

const Title = styled(Typography)({
  flexGrow: 1,
});

const Navbar = ({ decodedToken ,Id,Role}) => {
  const [navItems, setNavItems] = useState([]);

  useEffect(() => {
    // Define navigation items based on user role from decodedToken
    let itemsToShow = [];

    if (Role === 'user') {
      itemsToShow = [
        { label: 'Home', path: '/home' },
        { label: 'FeedBack', path: '/feedback-form' },
        { label: 'Gallery', path: '/image-gallary' },
        { label: 'Hotel', path: '/hotel-list' },
      ];
    } else if (Role === 'agent') {
      itemsToShow = [
        { label: 'Home', path: '/home' },
        { label: 'AddPackage', path: '/adding-package' },
        { label: 'PostHotel', path: '/hotel-post' },
      ];
    } else if (Role === 'admin') {
      itemsToShow = [
        { label: 'AdminApproval', path: '/admin-approval' },
        { label: 'AdminImageGallery', path: '/admin-image-gallary' },
      ];
    }

    setNavItems(itemsToShow);
  }, [decodedToken]);

  return (
    <CustomAppBar position="static">
      <Toolbar>
        <Title variant="h6" component="div">
          My App
        </Title>
        {navItems.map((item) => (
          <Button
            key={item.label}
            component={Link}
            to={item.path}
            color="inherit"
          >
            {item.label}
          </Button>
        ))}
        <Button component={Link} to="/logout" color="inherit">
          Log Out
        </Button>
      </Toolbar>
    </CustomAppBar>
  );
};

export default Navbar;