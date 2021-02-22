CREATE TABLE IF NOT EXISTS documents (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,  
    description VARCHAR(1000) NOT NULL,
    category_id INT NOT NULL,
    storage_path VARCHAR(1000) NOT NULL,
    owner_id INT NOT NULL,
    created_on TIMESTAMP NOT NULL
)