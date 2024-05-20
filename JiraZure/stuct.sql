	MyApiProject
	├── Controllers
	│   ├── Webhook1Controller.cs
	│   └── Webhook2Controller.cs
	├── Services
	│   ├── Interfaces
	│   │   ├── IWebhook1Service.cs
	│   │   └── IWebhook2Service.cs
	│   ├── Implementations
	│   │   ├── Webhook1Service.cs
	│   │   └── Webhook2Service.cs
	├── Models
	│   ├── Webhook1Model.cs
	│   └── Webhook2Model.cs
	├── Clients
	│   └── ExternalApiClient.cs
	├── Data
	│   ├── ApplicationDbContext.cs
	│   └── Repositories
	│       ├── Interfaces
	│       │   ├── IWebhook1Repository.cs
	│       │   └── IWebhook2Repository.cs
	│       ├── Implementations
	│       │   ├── Webhook1Repository.cs
	│       │   └── Webhook2Repository.cs
	├── Program.cs
	└── Startup.cs



	--	├── DTOs
--	│   ├── Webhook1Dto.cs
--	│   └── Webhook2Dto.cs