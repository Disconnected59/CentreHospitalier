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
          
        if($this->denyAccessUnlessGranted('IS_AUTHENTICATED_FULLY')!=null)
        {
          $user = $this->getUser();
          $role = $user->getRoles();
        }


        $repository=$this->getDoctrine()->getRepository(Consultation::class);
		$lesConsultations=$repository->findAll();
		return $this->render('consultation/index.html.twig',[
			'consultations'=>$lesConsultations,]);
    }
}
