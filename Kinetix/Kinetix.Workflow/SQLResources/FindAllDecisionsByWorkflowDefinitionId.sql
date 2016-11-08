﻿SELECT 
	WFD.*
FROM 
	WF_DECISION WFD
	JOIN WF_ACTIVITY WFA ON (WFD.WFA_ID = WFA.WFA_ID)
	JOIN WF_ACTIVITY_DEFINITION WAD ON (WFA.WFAD_ID = WAD.WFAD_ID)
WHERE 
	WAD.WFWD_ID = @WFWD_ID;