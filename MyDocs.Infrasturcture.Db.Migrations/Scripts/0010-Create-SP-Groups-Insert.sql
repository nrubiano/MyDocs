CREATE OR REPLACE FUNCTION groups_insert(
   name VARCHAR(100)
)
RETURNS INT
LANGUAGE plpgsql
AS $$
DECLARE
   groupId INT;
BEGIN
    INSERT INTO groups(name, created_on) VALUES (name, CURRENT_TIMESTAMP) RETURNING id INTO groupId;
    RETURN groupId;
END;$$