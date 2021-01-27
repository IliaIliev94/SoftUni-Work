ALTER TABLE Users ADD CONSTRAINT Check_PasswordIsLessThanFive CHECK(LEN([Password]) >= 5)
