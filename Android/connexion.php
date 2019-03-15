<?php
function connexion(){
    try{
        $PDO = new PDO('mysql:host=localhost;dbname=bddgestionrdv', 'root', '');
    }
    catch (PDOException $e){
     echo'Connexion échouée : '.$e->getMessage();
    }
    return $PDO;
}

function afficherConsultations(){
	$pdo = connexion();
	$aujourdhui=date("Y-m-d");
	$m = $pdo->prepare("Select consultation.nom AS 'nomPatient', consultation.prenom AS 'prenomPatient', date, heure, medecin.nom AS 'nomMedecin', medecin.prenom AS 'prenomMedecin' FROM consultation join medecin on medecin.id=consultation.id_medecin_id where date>='".$aujourdhui."'");
	$execute = $m->execute();
	$consultations = $m->fetchAll();
	$m->closeCursor();
	$consultationsJson = json_encode($consultations);
	return $consultationsJson;
}


	




	
$methode=$_SERVER["REQUEST_METHOD"];
switch($methode){
		case "GET":
			echo afficherConsultations();
		 }
		 break;

		case "POST":
		 if(isset($_POST['id'])){
			 try{
				 $pdo= connexion();
				 $m = $pdo->prepare("Insert into consultation values('".$_POST['id']."', '".$_POST['id_medecin_id']."', '".$_POST['date']."', '".$_POST['heure']."', '".$_POST['est_validee']."', '".$_POST['nom']."', '".$_POST['prenom']."', '".$_POST['id_patient']."')");
				 $execute->exec($m);
				 $m->closeCursor();
				 echo "Vous avez complété votre demande de rendez-vous avec succès."
			 }
			 catch(Exception $e)
			 {
				 
			 }

		 }
		 break;

		case "PUT":
			
		break;

		case "DELETE":
			if(isset($_POST['id'])){
				try{
					$pdo = connexion();
					$m = $pdo->prepare("DELETE FROM consultation WHERE id='".$_POST['id']."'");
					$execute->exec($m);
					$m->closeCursor();
					echo "Le rendez-vous a  été annulé."
				}
				catch(Exception $e){

				}

			}
		break;
	}
    
?>
