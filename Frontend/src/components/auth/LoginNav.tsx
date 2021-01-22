import React from 'react'
import { useAuth0 } from "@auth0/auth0-react";
import LogoutButton from './LogoutButton';
import LoginButton from './LoginButton';
import { Image } from 'react-bootstrap';
import Loading from '../Loading';

export default function LoginNav() {

  const { user, isAuthenticated, isLoading } = useAuth0();

  if (isLoading) {
    return <div style={{ width:30 }}>
      <Loading />
    </div>;
  }

  console.log(user)

  return isAuthenticated ? (
      <div>
        <Image roundedCircle src={user.picture} alt={user.name} style={{ width: 30, marginRight: 20, marginLeft: 20 }}/>
        <span>{user.nickname}</span>
        <LogoutButton />
      </div>
    ) : (
      <>
        <LoginButton />
      </>
    )
  ;
}
