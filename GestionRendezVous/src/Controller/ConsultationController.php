<?php

namespace App\Controller;
use App\Entity\Consultation;
use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\Routing\Annotation\Route;
use Symfony\Component\Form\Extension\Core\Type\SubmitType;
use Symfony\Component\Form\Extension\Core\Type\DateType;
use Symfony\Component\Form\Extension\Core\Type\TextType;
use Symfony\Component\Form\Extension\Core\Type\ChoiceType;
use Symfony\Component\OptionsResolver\OptionsResolver;
use Symfony\Bridge\Doctrine\Form\Type\EntityType;
use App\Form\RdvPatientType;
use Symfony\Component\HttpFoundation\Request;


class ConsultationController extends AbstractController
{
    /**
     * @Route("/consultation", name="consultation")
     */
    public function index(Request $request)
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
                $em = $this -> getDoctrine() -> getManager();
                $consultation = new Consultation();
                $nomUser=$user->getNom();
                $prenomUser=$user->getPrenom();
                $idUser=$user->getId();

                $lesRdv = $this->getDoctrine()->getRepository('App:Consultation')->findAll();
                $i=0;
                foreach($lesRdv as $unRdv)
                {
                    $leId=$unRdv->getIdPatient();
                    if($leId==$idUser)
                    {
                        $lesRdvAffiches=array();
                        $lesRdvAffiches[0]=$unRdv;
                    }
                    $i++;
                }


                $consultation->setPrenom($prenomUser);
                $consultation->setNom($nomUser);
                $consultation->setIdPatient($idUser);
                $validee=false;
                $consultation->setEstValidee($validee);
                $form = $this -> createForm(RdvPatientType::class,$consultation);
                $form -> handleRequest($request);
                if ($form -> isSubmitted() && $form -> isValid()) 
                {
                    $consultation = $form -> getData();
                    $em = $this -> getDoctrine() -> getManager();
                    $em -> persist($consultation);
                    $em -> flush();
                }
                return $this->render('consultation/consultationPatient.html.twig', ['form'=>$form->createView(),'rdv'=>$lesRdv]);
           

            }
          
        
        $repository=$this->getDoctrine()->getRepository(Consultation::class);
		$lesConsultations=$repository->findAll();
		return $this->render('consultation/index.html.twig',[
			'consultations'=>$lesConsultations,'role'=>$role, 'oui'=>$oui, 'taille'=>$tailleRoles]);
    }


}
