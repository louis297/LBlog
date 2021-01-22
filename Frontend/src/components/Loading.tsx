import React from "react";
import { Image } from 'react-bootstrap';

const loadingImg =
  "https://cdn.auth0.com/blog/auth0-react-sample/assets/loading.svg";

export default function Loading(){
  return (
  <div className="spinner">
    <Image src={loadingImg} alt="Loading..." style={{ maxWidth:"100%", maxHeight:"100%" }}/>
  </div>
  );
}

