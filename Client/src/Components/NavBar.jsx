import { Link } from 'react-router-dom';

const NavBar = () => {
  const navStyle = {
    display: 'flex',            // Use Flexbox
    alignItems: 'center',      // Vertically center items
    backgroundColor: '#333',  // Background color
    padding: '10px 20px',     // Padding for the navbar
  };

  const linkStyle = {
    display: 'flex',
    color: '#fff',           // Link text color
    textDecoration: 'none',  // Remove underlines
    margin: '0 10px',        // Add space between links
    listStyleType: 'none'
  };

  return (
    <nav style={navStyle}>
      {/* Logo */}
      <div className="logo">
        <img src="/path/to/your-logo.png" alt="Logo" />
      </div>

      {/* Links */}
      <ul className="nav-links" style={linkStyle}>
        <li><Link to="/" style={linkStyle}>Find Lessons</Link></li>
        <li><Link to="/rentals" style={linkStyle}>Rentals</Link></li>
        <li><Link to="/how-it-works" style={linkStyle}>How it Works</Link></li>
        <li><Link to="/teach-with-us" style={linkStyle}>Teach With Us</Link></li>
        <li><Link to="/contact" style={linkStyle}>Contact</Link></li>
        <li><Link to="/sign-in" style={linkStyle}>Sign In</Link></li>
      </ul>
    </nav>
  );
}

export default NavBar;
