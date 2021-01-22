import React from "react";
import { useAuth0 } from "@auth0/auth0-react";
import { Button } from "react-bootstrap";

const LogoutButton = () => {
  const { logout } = useAuth0();

  return (
    <Button variant="outline-danger" onClick={() => logout({ returnTo: window.location.origin })} style={{ marginLeft: 20, marginRight: 20}}>
      Log Out
    </Button>
  );
};

export default LogoutButton;