CREATE TABLE IF NOT EXISTS group_users (
    group_id INT NOT NULL,
    user_id INT NOT NULL,
    PRIMARY KEY(group_id, user_id)
)