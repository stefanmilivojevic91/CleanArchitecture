# CleanArchitecture

Solution structure:
1.Domain - Core application project. Contains bussines logic implementation.
2.Data - Data providers. Usually database repositories implementations.
3.Presentation - Presenters and view models. Those are mapping utilities which convert use cases responses to appropriate representations for view.
4.Infrastructure - Different utilities.

1.Domain
- Dtos
	Responses from use cases. Domain entities are mapped to them.
- Entities
	Core bussines objects.
- Interfaces
	Policies which are referenced in use cases and implementation in other projects. For example repositories interfaces, or other gateways used to communicate with external services.
- Models
	Use cases input models.
- Services
	Domain services which are shared between use cases.
- Shared
	Utilities shared between use cases. Base specification and use case interfaces.
- Specifications
	Expressions wrappers used for querying data from repositories.
- UseCases
	Application bussines rules. They represent real business use cases and control data flow.
