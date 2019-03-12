<?php

namespace App\Controller;
use App\Entity\Service;
use App\Entity\Medecin;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\Routing\Annotation\Route;

class ServiceController extends AbstractController
{
    /**
     * @Route("/service", name="service")
     */
    public function index()
    {
             $repository=$this->getDoctrine()->getRepository(Service::class);
			 $repository2=$this->getDoctrine()->getRepository(Medecin::class);
		$lesMedecins=$repository2->findAll();
		$lesServices=$repository->findAll();
		return $this->render('service/index.html.twig',[
			'services'=>$lesServices,
			'medecins'=>$lesMedecins,]);
    }
}
