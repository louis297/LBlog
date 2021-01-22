import React from "react";
import { useHistory } from "react-router-dom";
import { Auth0Provider } from "@auth0/auth0-react";
import LBlogConfig from "../../config";

const Auth0ProviderWithHistory = ({ children } :any) => {
  const domain = LBlogConfig.AUTH0_DOMAIN;
  const clientId = LBlogConfig.AUTH0_CLIENT_ID;
  const audience = LBlogConfig.AUDIENCE;

  const history = useHistory();

  const onRedirectCallback = (appState:any) => {
    history.push(appState?.returnTo || window.location.pathname);
  };

  return (
    <Auth0Provider
      domain={domain as string}
      clientId={clientId as string}
      redirectUri={window.location.origin}
      onRedirectCallback={onRedirectCallback}
      audience={audience}
    >
      {children}
    </Auth0Provider>
  );
};

export default Auth0ProviderWithHistory;