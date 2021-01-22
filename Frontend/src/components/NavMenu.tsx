import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import {LinkContainer} from 'react-router-bootstrap'
import './NavMenu.scss';
import { Container, Nav, Navbar, NavDropdown } from 'react-bootstrap';
import LoginNav from './auth/LoginNav';
// import { LoginMenu } from './login/LoginMenu';

interface IProps {
}

interface IState {
  collapsed: boolean;
}

export default class NavMenu extends Component<IProps, IState> {
  static displayName = NavMenu.name;

  constructor(props: IProps) {
    super(props);
    this.toggleNavbar = this.toggleNavbar.bind(this);
    this.state = {
      collapsed: true
    };
  }

  toggleNavbar() {
    this.setState( {
      collapsed: !this.state.collapsed
    });
  }
  render() {
    return (
      <header>
        <Navbar bg="light" expand="lg">
          <Container>
            <LinkContainer to='/'>            
              <Navbar.Brand>LBlog</Navbar.Brand>
            </LinkContainer>
            <Navbar.Toggle aria-controls="basic-navbar-nav" />
            <Navbar.Collapse id="basic-navbar-nav">
              <Nav className="mr-auto">
                <LinkContainer to='/'> 
                  <Nav.Link>Home</Nav.Link>
                </LinkContainer>
                <Nav.Link href="#link">My blogs</Nav.Link>
                <NavDropdown title="Actions" id="basic-nav-dropdown">
                  <LinkContainer to='/addblog'> 
                    <NavDropdown.Item>Write new blog</NavDropdown.Item>
                  </LinkContainer>
                  <NavDropdown.Item href="#action/3.2">Another action</NavDropdown.Item>
                  <NavDropdown.Item href="#action/3.3">Something</NavDropdown.Item>
                  <NavDropdown.Divider />
                  <NavDropdown.Item href="#action/3.4">Separated link</NavDropdown.Item>
                </NavDropdown>
                {/* <Nav.Item> */}
                  
                {/* </Nav.Item> */}
              </Nav>
              <Nav>
                <LoginNav />
              </Nav>
            </Navbar.Collapse>
          </Container>
        </Navbar>

      </header>
    )
  }
}
