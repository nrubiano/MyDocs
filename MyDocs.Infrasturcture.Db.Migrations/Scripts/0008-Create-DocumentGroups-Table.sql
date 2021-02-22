CREATE TABLE IF NOT EXISTS document_groups (
    document_id INT NOT NULL,
    group_id INT NOT NULL,
    PRIMARY KEY(document_id, group_id)
)