<?php
$leJson = json();
echo $leJson;

function json(){
	$Objet = new \stdClass();
	$array =array();
	/*$methode = $_SERVER["REQUEST_METHOD"];
	switch($methode){
		case "GET":
			if(!isset($_GET['id'])){*/
				$pdo = new PDO('mysql:host=localhost;dbname=bddstefaneplagiat','root','');
				$m = $pdo->prepare("SELECT * FROM utilisateur");
				$execute = $m->execute();
				$resultat = $m->fetchAll();
				$m->closeCursor();
				foreach ($resultat as $medecin) {
					$Objet->id = $medecin['id'];
					$Objet->mdp = $medecin['mdp'];
					array_push($array, $Objet);
				}
				$Json = json_encode($array);
				return $Json;

			}
			/*else{
				$pdo = new PDO('mysql:host=localhost;dbname=bddgestionrdv','root','');
				$m = $pdo->prepare("SELECT * FROM medecin WHERE id =".$_GET['id']);
				$execute = $m->execute();
				$resultat = $m->fetch();
				$m->closeCursor();
				$Objet->nom = $resultat['nom'];
				$Objet->prenom = $resultat['prenom'];
				$Objet->adresse = $resultat['adresse'];
				$Objet->email = $resultat['email'];
				$Json = json_encode($Objet);
				return $Json;
			}
			break;
		case "POST":
			if(!($_POST['id'] >= 1)){
				return "veuillez saisir une id.";
				}
			}
			else{
				$pdo = new PDO('mysql:host=localhost;dbname=bddgestionrdv','root','');
				$m = $pdo->prepare("INSERT INTO medecin VALUES (".$_POST['id'].", 1, 'test', 'test', NULL, 'test', 'test', 'test', NULL)");
				$execute->exec($m);
				$m->closeCursor();
				return "Le médecin à bien été ajouté.";
			}
			break;
		case "PUT":
			break;
	}
}*/

/*
$pdo = new PDO('mysql:host=localhost;dbname=bddgestionrdv','root','');
$m = $pdo->prepare("SELECT * FROM medecin");
$execute = $m->execute();
$resultat = $m->fetch();
$m->closeCursor();
$Objet->nom = $resultat['nom'];
$Objet->prenom = $resultat['prenom'];
$Objet->adresse = $resultat['adresse'];
$Objet->email = $resultat['email'];
$Json = json_encode($Objet);
echo $Json;*/

?>