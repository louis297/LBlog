import React from 'react';
import logo from './logo.svg';
import './App.css';
import Layout from './components/Layout';
import { Route, Switch } from 'react-router-dom';
import Blog from './components/blog/Blog';
import AddBlog from './components/blog/AddBlog';
import ProtectedRoute from './components/auth/ProtectedRoute';

function App() {
  return (
    <Layout>
      <Switch>
        <Route exact path='/' component={Blog}></Route>
        <ProtectedRoute path='/addblog' component={AddBlog}></ProtectedRoute>
      </Switch>
    </Layout>
  );
}

export default App;
