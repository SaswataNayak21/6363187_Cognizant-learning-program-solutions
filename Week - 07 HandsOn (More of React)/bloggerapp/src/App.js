import React, { useState } from "react";
import BookDetails from "./components/BookDetails";
import BlogDetails from "./components/BlogDetails";
import CourseDetails from "./components/CourseDetails";

function App() {
  const [selected, setSelected] = useState("none");

  let element; // For element variable example

  // If-else condition
  if (selected === "book") {
    element = <BookDetails />;
  } else if (selected === "blog") {
    element = <BlogDetails />;
  } else if (selected === "course") {
    element = <CourseDetails />;
  } else {
    element = <p>Please select a category to view details.</p>;
  }

  // Switch-case version
  const renderSwitch = () => {
    switch (selected) {
      case "book":
        return <BookDetails />;
      case "blog":
        return <BlogDetails />;
      case "course":
        return <CourseDetails />;
      default:
        return <p>Use the switch to select a category.</p>;
    }
  };

  return (
    <div style={{ padding: "20px" }}>
      <h1>📚 Blogger App</h1>

      <div style={{ marginBottom: "10px" }}>
        <button onClick={() => setSelected("book")}>Book</button>
        <button onClick={() => setSelected("blog")}>Blog</button>
        <button onClick={() => setSelected("course")}>Course</button>
        <button onClick={() => setSelected("none")}>Reset</button>
      </div>

      <h3>Using If-Else + Element Variable:</h3>
      {element}

      <h3>Using Ternary Operator:</h3>
      {selected === "blog" ? <BlogDetails /> : <p>No blog selected.</p>}

      <h3>Using Logical AND (&&):</h3>
      {selected === "course" && <CourseDetails />}

      <h3>Using Switch Case:</h3>
      {renderSwitch()}
    </div>
  );
}

export default App;
