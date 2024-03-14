import logo from './BowlingLeague.png';

function Header(props: any) {
  return (
    <div>
      <header className="row header navbar navbar-dark bg-danger">
        <div className="col-4">
          <img src={logo} className="logo" alt="logo" />
        </div>
        <div className="col subtitle">
          <h1 className="text-light">{props.title}</h1>
        </div>
      </header>
      <br />
    </div>
  );
}

export default Header;
