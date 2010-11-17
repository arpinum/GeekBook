Feature: En tant que JB, je souhaite créer un contact

Scenario: création d'un contact
	Given je suis "JB"
	When je crée 1 contact
	Then j'ai 1 contact
