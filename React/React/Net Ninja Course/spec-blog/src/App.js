import './App.css';

function App() {
  const title = 'Yo, mr.White';
  const likes = 420;
  const github = "https://github.com/spec-reki"

  return (
    <div className="App">
      <div className="content">
        <h1>{title}</h1>
        <p>Liked {likes} times</p>

        <p>{20}</p>
        <p>{"Jessie, It's not a wire, it's copper"}</p>
        <p>{[1,2,3,4,5]}</p>
        <p>{ Math.random() * 10}</p>

        <a href={github}>Github</a>
      </div>
    </div>
  );
}

export default App;
