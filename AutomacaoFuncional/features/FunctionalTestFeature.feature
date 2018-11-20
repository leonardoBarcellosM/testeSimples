Feature: C-FunctionalTestFeature
	Use before title fiture separed with "-":
	 'C' for Chrome;
	 'I' for Internet Explorer;
	 'F' for FireFox Mozilla;
	 'E' for Edge;
	 Default: Chrome

@AcessPage
Scenario: Access Page
Given Access to page "http://homologacao.fundacred.org.br/estudante-web/#/"	
Then Page loaded with sucess