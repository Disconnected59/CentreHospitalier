<?php

namespace App\Controller;
use App\Entity\Consultation;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\Routing\Annotation\Route;

class ConsultationController extends AbstractController
{
    /**
     * @Route("/consultation", name="consultation")
     */
    public function index()
    {   
          $user = $this->getUser();
          $role = $user->getRoles();

          $tailleRoles=sizeof($role);
            $oui = "non";
            $textRole="ROLE_USER";
            if($tailleRoles==2)
            {
                $textRole = $role[1];
            }
            if($textRole == "ROLE_MEDECIN")
            {
                $oui = "oui";
                return $this->render('consultation/consultationMedecin.html.twig');
            }
            else if($textRole == "ROLE_ASSISTANT")
            {
                return $this->render('consultation/consultationAssistant.html.twig');
            }
            else
            {
                $oui = "peut etre";
                return $this->render('consultation/consultationPatient.html.twig');
            }
          
        
        $repository=$this->getDoctrine()->getRepository(Consultation::class);
		$lesConsultations=$repository->findAll();
		return $this->render('consultation/index.html.twig',[
			'consultations'=>$lesConsultations,'role'=>$role, 'oui'=>$oui, 'taille'=>$tailleRoles]);
    }
}
