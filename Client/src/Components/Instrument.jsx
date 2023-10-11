import { useState,useEffect } from 'react'
import axios from 'axios';

function InstrumentComponent() {

  const [instrumentModel, setInstrumentModel] = useState({})

  async function fetchData()
  {
    const response = await axios.get('api/instrument/one');
    setInstrumentModel(response.data);

    console.log(response.data);
  }

  useEffect(() => {

    fetchData();


  //   fetch('/api/instrument/one')
  //     .then(response => console.log(response))
  //     .then(data => {
  //       setInstrumentModel(data);
  //     })
  //     .catch(error => {
  //       console.error('Error fetching data:', error)
  //     });

    }, []);
  
  return (
      <div>
        <h1>First Instrument in Database</h1>
        <h1>Instrument: {instrumentModel.instrumentName}</h1>
        <h1>Category: {instrumentModel.category}</h1>
      </div>
    )
}

export default InstrumentComponent


