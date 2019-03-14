<?php

namespace App\Controller;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\Routing\Annotation\Route;
use Symfony\Component\HttpFoundation\Request;
use App\Form\InscriptionPatient;
use App\Entity\User;

class InscriptionController extends AbstractController
{
    /**
     * @Route("/inscription", name="inscription")
     */
    public function index(Request $request)
    {
        $repository=$this->getDoctrine()->getRepository(User::class);
		$em=$this->getDoctrine()->getManager();
		$user=new User();
		$form= $this->createForm(InscriptionPatient::class, $user);
				   $form->handleRequest($request);
					if($form->isSubmitted() && $form->isValid()) {
						$user = $form->getData();
						$em=$this->getDoctrine()->getManager();
						$em->persist($user);
						$em->flush(); 
			return $this->redirectToRoute('accueil');
		}
						return $this->render('inscription/index.html.twig',[
		'form'=>$form->createView(),]);
    }
}
?>