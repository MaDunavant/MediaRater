﻿
CREATE PROCEDURE usp_updCOMMENT
	@COMMENTID INT,
	@TEXT NVARCHAR(MAX)
AS
BEGIN
	UPDATE COMMENTS
	SET TEXT = @TEXT
	WHERE COMMENTID = @COMMENTID
END
