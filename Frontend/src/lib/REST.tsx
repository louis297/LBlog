import React, { Component } from 'react'
import BaseURL from './BaseURL'
import Logger from './Logger'
import axios, { AxiosResponse, AxiosRequestConfig } from 'axios'
import { Redirect } from 'react-router-dom';

export default class REST extends Component {

  static async get(config:AxiosRequestConfig){
    config.method = 'GET';
    return this.connect(config)
  }

  static async post(config:AxiosRequestConfig){
    config.method = 'POST';
    return this.connect(config)
  }

  static async put(config:AxiosRequestConfig){
    config.method = 'PUT';
    return this.connect(config)
  }

  static async delete(config:AxiosRequestConfig){
    config.method = 'DELETE';
    return this.connect(config)
  }

  static async connect(config:AxiosRequestConfig){
    config.baseURL = BaseURL.backend;
    config.responseType = config.responseType ? config.responseType : 'json';
    let res:AxiosResponse;    
    let error:any = new Error();
    try {
      res = await axios(config);
      // TODO: check response code here
      if(res.status === 404 || res.status === 500){
        
      } else if (res.status === 403) {
        // jump to login
        error.action = () => <Redirect to='/login' />
        throw `Error occurred with http post`
      }
    } catch (e) {
      Logger.log(e);
      error.action && error.action();
      return error;
    }
    return res;
  }

  render() {
    return (
      <>
        
      </>
    )
  }
}
