import React, {useState} from 'react';
import { useAuth } from '../AuthContext';

const Home = () => {

    const { user } = useAuth();

    return (
        <div className='mt-5'>
            <h1>Home Page</h1>
            {user && <h2>Welcome {user.firstName} {user.lastName}</h2>}
        </div>
    );
};

export default Home;