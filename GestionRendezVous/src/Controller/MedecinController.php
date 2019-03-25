<?php

namespace App\Controller;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\Routing\Annotation\Route;
use App\Entity\Doctrine;
use App\Entity\Medecin;

class MedecinController extends AbstractController
{
    /**
     * @Route("/medecin", name="medecin")
     */
    public function index()
    {
        $repository=$this->getDoctrine()->getRepository(Medecin::class);
		$lesMedecins=$repository->findAll();
		return $this->render('medecin/index.html.twig',[
			'medecins'=>$lesMedecins,
		]);
    }
}


