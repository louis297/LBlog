import { EditorState } from 'draft-js'
import { Editor } from 'react-draft-wysiwyg';
import React, { useState } from 'react'

interface IProps {
  blogContent: EditorState
  setBlogContent: (e:EditorState) => void
}

export default function RichEditor(props: IProps) {
  

  return (
    <Editor 
      editorState={props.blogContent}
      wrapperClassName="rich-editor"
      editorClassName="blog-content"
      editorStyle={{ border: "1px solid", paddingLeft: "5px", paddingRight: "5px", minHeight: "300px", maxHeight: "800px", marginBottom: "20px"}}
      onEditorStateChange={ (e:EditorState) => {props.setBlogContent(e)}}
      tabIndex={4}
      placeholder="The message goes here..." />
  )
}
