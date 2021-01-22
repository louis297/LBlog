import React, { useEffect, useState } from 'react'
import { Button, Col, Container, Form, Row } from 'react-bootstrap'
import { convertToRaw, EditorState } from 'draft-js';

import RichEditor from './RichEditor';
import draftToHtml from 'draftjs-to-html';
import REST from '../../lib/REST';
import { useAuth0, withAuthenticationRequired } from "@auth0/auth0-react";
import Loading from "../Loading";


function AddBlog() {
  const [loading, setLoading] = useState(true)
  const [blogTitle, setBlogTitle] = useState<string>("");
  const [blogContent, setBlogContent] = useState<EditorState>(() => EditorState.createEmpty());
  const [accessToken, setAccessToken] = useState<string>("");
  const [blogTypeSelected, setBlogTypeSelected] = useState<string>("");

  const { getAccessTokenSilently } = useAuth0();
  useEffect(() => {
    async function setupToken(){    
      const token = await getAccessTokenSilently();
      console.log(token)
      // setAccessToken(token);
      REST.get({url:'api/blog/blogtypes',
      headers: {
      Authorization: `Bearer ${token}`,
    }}).then( r => {console.log(r); });
    }
    if(!loading){
      setupToken();
    }
  }, [loading]);

  setLoading(false);

  const [preview, setPreview] = useState<any>()

  const blogTypes = ['Technical', 'Daily Life', 'Music', 'Science', 'Others']
  

  const blogTypesComponent =  <Form.Group controlId="BlogType">
  <Form.Label>Blog Type</Form.Label>
    <Form.Control as="select">
      {blogTypes.map( v => <option key={v}>{v}</option>)}
    </Form.Control>
  </Form.Group>

  const FormSubmit = (event:any) => {
    // VERY important, without persist event will be re-use and set to null in async function
    event.persist();
    event.preventDefault();

    // store JSON.stringify(convertToRaw(blogContent.getCurrentContent())) to DB

    // parse convertFromRaw( JSON.parse( <content from db> )) to <EditorState>

    // use DOMPurify.sanitize(dirty) to clean the draftToHtml(convertToRaw(blogContent.getCurrentContent()))

    console.log(convertToRaw(blogContent.getCurrentContent()))
    console.log(draftToHtml(convertToRaw(blogContent.getCurrentContent())))
    setPreview(draftToHtml(convertToRaw(blogContent.getCurrentContent())))
  }

  return (
    <>
      <Form id="AddBlogForm" onSubmit={FormSubmit}>        
        <Row>
          <Col xs="6" lg={{span:2, offset:1}}>
            {blogTypesComponent}
          </Col>
          <Col xs="12" lg={{span:7, offset:1}}>
            <Form.Group controlId="BlogTitle">
              <Form.Label>Title</Form.Label>
              <Form.Control type="text" placeholder="Blog Title" value={blogTitle} onChange={(e) => setBlogTitle(e.target.value)}/>
            </Form.Group>
          </Col>
        </Row>
        <Row>
          <Col>
            <RichEditor blogContent={blogContent} setBlogContent={setBlogContent}/>
          </Col>
        </Row>
        <Row>
          <Col>
            <Button variant="primary" type="submit">
              Submit
            </Button>
          </Col>
        </Row>
      </Form>

      <Container dangerouslySetInnerHTML={{ __html: preview }}>
      </Container>
    </>
  )
}

export default AddBlog;

// export default withAuthenticationRequired(AddBlog, {
//   onRedirecting: () => <Loading />,
// });