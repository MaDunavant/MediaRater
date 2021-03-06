﻿
CREATE PROCEDURE usp_updMEDIA
	@MEDIAID INT,
	@TITLE NVARCHAR(60),
	@MEDIATYPEID INT,
	@YEARRELEASED INT,
	@DESCRIPTION NVARCHAR(MAX),
	@IMAGEURL VARCHAR(200)
AS
BEGIN
	UPDATE MEDIA
	SET TITLE = @TITLE
		,MEDIATYPEID = @MEDIATYPEID
		,YEARRELEASED = @YEARRELEASED
		,DESCRIPTION = @DESCRIPTION
		,IMAGEURL = @IMAGEURL
	WHERE ID = @MEDIAID
END
