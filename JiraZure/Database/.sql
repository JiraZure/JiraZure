-- ██████╗ ██████╗  ██████╗      ██╗███████╗ ██████╗████████╗    ██╗  ██╗ █████╗ ███╗   ██╗██████╗ ██╗     ██╗███╗   ██╗ ██████╗ 
-- ██╔══██╗██╔══██╗██╔═══██╗     ██║██╔════╝██╔════╝╚══██╔══╝    ██║  ██║██╔══██╗████╗  ██║██╔══██╗██║     ██║████╗  ██║██╔════╝ 
-- ██████╔╝██████╔╝██║   ██║     ██║█████╗  ██║        ██║       ███████║███████║██╔██╗ ██║██║  ██║██║     ██║██╔██╗ ██║██║  ███╗
-- ██╔═══╝ ██╔══██╗██║   ██║██   ██║██╔══╝  ██║        ██║       ██╔══██║██╔══██║██║╚██╗██║██║  ██║██║     ██║██║╚██╗██║██║   ██║
-- ██║     ██║  ██║╚██████╔╝╚█████╔╝███████╗╚██████╗   ██║       ██║  ██║██║  ██║██║ ╚████║██████╔╝███████╗██║██║ ╚████║╚██████╔╝
-- ╚═╝     ╚═╝  ╚═╝ ╚═════╝  ╚════╝ ╚══════╝ ╚═════╝   ╚═╝       ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═════╝ ╚══════╝╚═╝╚═╝  ╚═══╝ ╚═════╝ 
                                                                                                                              
--+-------------------+     +-------------------+     +-------------------+
--| TemplateToProject |     |   Projects        |     |   Systems         |
--|-------------------|     |-------------------|     |-------------------|
--|   ID              |     |   ID              |<--- |   ID              |
--|   TemplateID      |     |   Name            |     |   Name            |
--|   syncTemplateID  |---->|   SystemId        |     |   Description     |
--|   ProjectsID      |     |   Description     |     |   Created         |
--|   Created         |     |   Created         |     |   LastUpdated     |
--|   LastUpdated     |     |   LastUpdated     |     +-------------------+
--+-------------------+     +-------------------+
--           |
--           V
--+------------------+     +---------------------+     +----------------------+
--|  syncTemplate    |     |  syncTemplateTypes  |     | syncTemplateFields   |
--|------------------|     |---------------------|     |----------------------|
--| ID               |<--- | syncTemplateID      |     | ID                   |
--| Name             |     | ID                  |<--- | syncTemplateTypesID  |
--| Created          |     | TYPE                |     | FromFieldName        |
--| LastUpdated      |     | Name                |     | ToFieldName          |
--+------------------+     | Created             |     | DataType             |
--                         | LastUpdated         |     | ConvertRule          |
--                         +---------------------+     | Created              |
--                                                     | LastUpdated          |
--                                                     +----------------------+





--Table Systems with ID, Name, Description, Created, LastUpdated
ID Autoincrement, 
Created on Insert,
LastUpdated on Insert or Update

-- Table Projects with ID, Name, SystemId , Description, Created, LastUpdated
ID Autoincrement 
SystemId Foreign Key
Created on Insert,
LastUpdated on Insert or Update


-- Table TemplateToProject , ID, TemplateID, ProjectsID,  Created, LastUpdated
ID Autoincrement 
TemplateID Foreign Key
syncTemplateID Foreign Key
Created on Insert,
LastUpdated on Insert or Update



-- Table syncTemplate with ID Name Created, LastUpdated
ID Autoincrement 
Created on Insert,
LastUpdated on Insert or Update

-- Table syncTemplateTypes with ID, ID From SyncTemplate, TYPE,  Name created, LastUpdated
ID Autoincrement 
syncTemplateID Foreign Key
Created on Insert,
LastUpdated on Insert or Update

-- Table syncTemplateFields with ID, ID From SyncTemplateTypes, FromFieldName, ToFieldName, DataType, ConverRule, created, LastUpdated
ID Autoincrement 
syncTemplateTypesID Foreign Key
Created on Insert,
LastUpdated on Insert or Update


--███████╗██╗   ██╗███╗   ██╗ ██████╗    ██╗  ██╗ █████╗ ███╗   ██╗██████╗ ██╗     ██╗███╗   ██╗ ██████╗     
--██╔════╝╚██╗ ██╔╝████╗  ██║██╔════╝    ██║  ██║██╔══██╗████╗  ██║██╔══██╗██║     ██║████╗  ██║██╔════╝     
--███████╗ ╚████╔╝ ██╔██╗ ██║██║         ███████║███████║██╔██╗ ██║██║  ██║██║     ██║██╔██╗ ██║██║  ███╗    
--╚════██║  ╚██╔╝  ██║╚██╗██║██║         ██╔══██║██╔══██║██║╚██╗██║██║  ██║██║     ██║██║╚██╗██║██║   ██║    
--███████║   ██║   ██║ ╚████║╚██████╗    ██║  ██║██║  ██║██║ ╚████║██████╔╝███████╗██║██║ ╚████║╚██████╔╝    
--╚══════╝   ╚═╝   ╚═╝  ╚═══╝ ╚═════╝    ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═════╝ ╚══════╝╚═╝╚═╝  ╚═══╝ ╚═════╝     
           

                                                                                    



