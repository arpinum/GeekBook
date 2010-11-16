Feature: En tant que JB, je souhaite créer un contact

Scenario: création d'un contact
	Given je suis JB
	When je crée un contact
	Then j'ai un contact
