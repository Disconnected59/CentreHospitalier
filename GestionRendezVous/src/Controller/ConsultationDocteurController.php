<?php

namespace App\Controller;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\Routing\Annotation\Route;

class ConsultationDocteurController extends AbstractController
{
    /**
     * @Route("/consultation/docteur", name="consultation_docteur")
     */
    public function index()
    {
    	  $this->denyAccessUnlessGranted('IS_AUTHENTICATED_FULLY');
    	  $user = $this->getUser();
    	  
    	  
    	  
        return $this->render('consultation_docteur/index.html.twig', [
            'controller_name' => 'ConsultationDocteurController',
        ]);
    }
}
