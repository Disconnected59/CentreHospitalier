<?php

namespace App\Controller;
use App\Entity\Service;

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
		$lesServices=$repository->findAll();
		return $this->render('service/index.html.twig',[
			'services'=>$lesServices,]);
    }
}
