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
          if($tailleRoles=1)
          {
                //return $this->render('accueil');
          }
          else if($tailleRoles>1)
          {
            $textRole = $role[1];
            if($textRole = "ROLE_MEDECIN")
            {

                //return $this->render('accueil');
            }
            else if($textRole = "ROLE_ASSISTANT")
            {
                //return $this->render('accueil');
            }
          }
      /* $repository=$this->getDoctrine()->getRepository(Consultation::class);
		$lesConsultations=$repository->findAll();
		return $this->render('consultation/index.html.twig',[
			'consultations'=>$lesConsultations,'user'=>$user]);*/
    }
}
