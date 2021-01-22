import React, { Component } from 'react';
import NavMenu from './NavMenu';
import REST from '../lib/REST'

export default class Layout extends Component {
  static displayName: string = Layout.name;

  render(){
    return (
      <>
        <NavMenu />
        <div className="container">
          {this.props.children}
        </div>
        <REST />
      </>
    );
  }

}
