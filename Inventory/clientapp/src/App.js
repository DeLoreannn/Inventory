import { useState } from "react";

export default function App() {
const [devices, setDevices] = useState([]);

function getDevices() {
  const url = "https://localhost:5001/api/device";

  fetch(url, {
    method: 'GET'
  })
  .then(response => response.json())
  .then(devices =>
    setDevices(devices))
  .catch((error) => {
    alert(error);
  })
}

  return (
    <div className="container">
      <div className="row min-vh-100">
        <div className="col d-flex flex-column justify-content-center align-items-center">
          <h1>Inventory</h1>
          <div className="mt-5">
            <button onClick={getDevices} className="btn btn-dark btn-lg w-100">Get devices from server</button>
          </div>
          {renderDevicesTable(devices)}
        </div>
      </div>
    </div>
  );
}

function renderDevicesTable(devices) {
  function useDevice(id) {
    const url = "https://localhost:5001/api/device/usedevice/" + id;
  
    fetch(url, {
      method: 'PUT'
    })
    .catch((error) => {
      alert(error);
    })
  }

  return (
    <div className="table-responsive mt-5">
      <table className="table table-bordered border-dark">
        <thead>
          <tr>
            <th scope="col">Device id</th>
            <th scope="col">Name</th>
            <th scope="col">Price</th>
            <th scope="col">Release date</th>
            <th scope="col">Expiration date</th>
            <th scope="col">Use</th>
          </tr>
        </thead>
        <tbody>
          {devices.map((d) => (
            <tr key={d.id}>
              <th scope="row">{d.id}</th>
              <td>{d.name}</td>
              <td>{d.price}</td>
              <td>{d.releaseDate}</td>
              <td>{d.expirationDate}</td>
              <td>
                <button onClick={useDevice(d.id)} className="btn btn-dark btn-lg mx-3 my-3">Use</button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}