CREATE TABLE IF NOT EXISTS document_users (
    document_id INT NOT NULL,
    user_id INT NOT NULL,
    PRIMARY KEY(document_id, user_id)
)