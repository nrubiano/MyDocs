﻿CREATE TABLE IF NOT EXISTS roles (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) UNIQUE NOT NULL,    
    created_on TIMESTAMP NOT NULL,
    modified_on TIMESTAMP
)