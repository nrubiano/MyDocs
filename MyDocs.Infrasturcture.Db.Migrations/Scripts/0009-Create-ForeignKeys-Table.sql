DO $$
BEGIN
    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conname = 'users_role_fkey') THEN
        ALTER TABLE users
            ADD CONSTRAINT users_role_fkey
            FOREIGN KEY (role_id) REFERENCES roles(id);
    END IF;

    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conname = 'group_users_group_id_fkey') THEN
        ALTER TABLE group_users
            ADD CONSTRAINT group_users_group_id_fkey
            FOREIGN KEY (group_id) REFERENCES groups(id);
    END IF;

    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conname = 'group_users_user_id_fkey') THEN
        ALTER TABLE group_users
            ADD CONSTRAINT group_users_user_id_fkey
            FOREIGN KEY (user_id) REFERENCES users(id);
    END IF;

    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conname = 'documents_categories_category_id_fkey') THEN
        ALTER TABLE documents
            ADD CONSTRAINT documents_categories_category_id_fkey
            FOREIGN KEY (category_id) REFERENCES categories(id);
    END IF;

    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conname = 'documents_users_owner_id_fkey') THEN
        ALTER TABLE documents
            ADD CONSTRAINT documents_users_owner_id_fkey
            FOREIGN KEY (owner_id) REFERENCES users(id);
    END IF;
    
    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conname = 'document_users_document_id_fkey') THEN
        ALTER TABLE document_users
            ADD CONSTRAINT document_users_document_id_fkey
            FOREIGN KEY (document_id) REFERENCES documents(id);
    END IF;
    
    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conname = 'document_users_user_id_fkey') THEN
        ALTER TABLE document_users
            ADD CONSTRAINT documents_users_user_id_fkey
            FOREIGN KEY (user_id) REFERENCES users(id);
    END IF;

    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conname = 'document_groups_document_id_fkey') THEN
        ALTER TABLE document_groups
            ADD CONSTRAINT document_groups_document_id_fkey
            FOREIGN KEY (document_id) REFERENCES documents(id);
    END IF;
    
    IF NOT EXISTS (SELECT 1 FROM pg_constraint WHERE conname = 'document_groups_group_id_fkey') THEN
        ALTER TABLE document_groups
            ADD CONSTRAINT document_groups_group_id_fkey
            FOREIGN KEY (group_id) REFERENCES groups(id);
    END IF;
    
END;
$$;