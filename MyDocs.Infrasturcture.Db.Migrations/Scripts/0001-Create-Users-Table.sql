CREATE TABLE IF NOT EXISTS users (
    id SERIAL PRIMARY KEY,
    username VARCHAR(100) UNIQUE NOT NULL,
    name VARCHAR(100) NOT NULL,
    first_name VARCHAR(100) NOT NULL,
    password VARCHAR(500) not null,
    email    VARCHAR(500) not null,
    role_id INT,
    created_on TIMESTAMP NOT NULL
)