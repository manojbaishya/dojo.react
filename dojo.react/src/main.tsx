import React from 'react';
import ReactDOM from 'react-dom/client';
// import App from './App.tsx';
import FluentApp from './FluentApp.tsx';
import './index.css';

ReactDOM.createRoot(document.getElementById('root')!).render(
    <React.StrictMode>
        <FluentApp />
    </React.StrictMode>,
);
