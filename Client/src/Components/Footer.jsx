import instrumentalImage from '../Assets/Images/instrumentalImage.jpg'

const Footer = () => {
  const footerStyle = {
    borderTop: '1px solid #ccc',  // Top border
    padding: '20px 0',           // Uniform padding for content top and bottom
    backgroundColor: '#f0f0f0',  // Background color
    color: '#555',               // Text color
    fontSize: '14px',            // Font size
    display: 'flex',
    flexDirection: 'column',    // Arrange children vertically
    alignItems: 'center',       // Center children horizontally
    textAlign: 'center',        // Center text within the footer
  };

  const missionContainerStyle = {
    display: 'flex',
    justifyContent: 'space-between',
    alignItems: 'center',
    padding: '20px 20px',  // Uniform padding for Mission Section left and right
    width: '80%'
  };

  const missionLeftStyle = {
    flex: 1,
    margin: '10px',       // Uniform margin for the mission div
  };

  const missionRightStyle = {
    flex: 2,
    display: 'flex',
    justifyContent: 'space-between',
  };

  const subDivStyle = {
    flex: 1,
    textAlign: 'center',
  };

  const copyrightStyle = {
    display: 'flex',
    flexDirection: 'row',    // Arrange children vertically
    alignItems: 'center',       // Center children horizontally
    borderTop: '1px solid #ccc',  // Top border for copyright div
    padding: '20px 20px 0',     // Uniform padding for the copyright div
    marginTop: '20px',           // Uniform margin at the top
    justifyContent: 'space-between', // Add space between divs
    width: '80%'
  };

  return (
    <div style={footerStyle}>
      {/* Mission Section */}
      <div style={missionContainerStyle}>
        <div style={missionLeftStyle}>
            <div style={{ display: 'flex', alignItems: 'center', justifyContent: 'center', marginBottom: '10px' }}>
                <img src={instrumentalImage} alt="Musical Instrument" style={{ height: '55px', width: '55px' }} />
                <h1 style={{ marginLeft: '10px' }}>Instrumental</h1>
            </div>
            <p>Our mission is to provide quality music lessons to learners of all ages.</p>
        </div>
        <div style={missionRightStyle}>
          {/* Sub Div 1 */}
          <div style={subDivStyle}>
            <h4>What we offer</h4>
            <a href="/what-we-offer">Learn More</a>
          </div>
          {/* Sub Div 2 */}
          <div style={subDivStyle}>
            <h4>Who we are</h4>
            <a href="/who-we-are">Learn More</a>
          </div>
          {/* Sub Div 3 */}
          <div style={subDivStyle}>
            <h4>Account</h4>
            <a href="/account">Sign In</a>
          </div>
          {/* Sub Div 4 */}
          <div style={subDivStyle}>
            <h4>Legal</h4>
            <a href="/legal">Terms & Conditions</a>
          </div>
        </div>
      </div>

      {/* Copyright Section */}
      <div style={copyrightStyle}>
        <div style={{ margin: '10px 0' }}>© 2023 Instrumental, Inc. All Rights Reserved</div>
        <div style={{ margin: '10px 0' }}>999-999-9999 | team@instrumental.com</div>
      </div>
    </div>
  );
}

export default Footer;
