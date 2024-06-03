const express = require('express');
const socketIO = require('socket.io');
const http = require('http');

const PORT = process.env.PORT || 3000;
const INDEX = '/index.html';

const server = express()
  .use((req, res) => res.sendFile(INDEX, { root: __dirname }))
  .listen(PORT, () => console.log(`Listening on ${PORT}`));

const io = socketIO(server);

io.on('connection', (socket) => {
  console.log('Client connected');
  socket.on('disconnect', () => console.log('Client disconnected'));
  socket.on('chat message', (msg) => {
    console.log('Message: ' + msg);
    // Here we would include the connection to the .NET Core API server for message handling
  });
});

console.log('Node.js chat client server running on port:', PORT);
