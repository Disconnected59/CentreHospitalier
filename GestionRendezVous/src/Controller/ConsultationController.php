<?php

namespace App\Controller;
use App\Entity\Consultation;
use App\Entity\User;
use App\Entity\Assistant;
use App\Entity\Service;
use App\Entity\Medecin;
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
          $aujourdhui = date("Y/m/d");

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
                $lesRdvs = $this->getDOctrine()->getRepository('App:Consultation')->findAll();
                $lesRdvsAffiches=array();
                $i=0;
                foreach($lesRdvs as $unRdv)
                {
                    $idUser = $user->getIdMedecin()->getId();
                    if($idUser == $unRdv->getIdMedecin()->getId())
                    {
                        $lesRdvsAffiches[$i]=$unRdv;

                    }
                    $i++;


                }

                return $this->render('consultation/consultationMedecin.html.twig',['rdvs'=>$lesRdvsAffiches]);
            }
            else if($textRole == "ROLE_ASSISTANT")
            {
                $serviceUser=$user->getIdAssistant()->getIdService();
                $repository=$this->getDoctrine()->getRepository(Consultation::class);
                $lesConsults=$repository->findAll();
                return $this->render('consultation/consultationAssistant.html.twig',['consultation'=>$lesConsults,'assistant'=>$serviceUser]);
            }
            else
            {



                $oui = "peut etre";
                $em = $this -> getDoctrine() -> getManager();
                $consultation = new Consultation();
                $nomUser=$user->getPatient()->getNom();
                $prenomUser=$user->getPatient()->getPrenom();
                $idPatientUser=$user->getPatient()->getId();
                $lesRdv = $this->getDoctrine()->getRepository('App:Consultation')->findAll();
                $i=0;
                $lesRdvAffiches=array();
                foreach($lesRdv as $unRdv)
                {
                    $leId=$unRdv->getPatient()->getId();
                    if($leId==$idPatientUser)
                    {
                        
                        $lesRdvAffiches[$i]=$unRdv;
                    }
                    $i++;
                }


                $consultation->setPrenom($prenomUser);
                $consultation->setNom($nomUser);
                $consultation->setPatient($user->getPatient());
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
                return $this->render('consultation/consultationPatient.html.twig', ['form'=>$form->createView(),'rdvs'=>$lesRdvAffiches,'idUser'=>$idPatientUser]);
           

            }
          
        
        $repository=$this->getDoctrine()->getRepository(Consultation::class);
		$lesConsultations=$repository->findAll();
		return $this->render('consultation/index.html.twig',[
			'consultations'=>$lesConsultations,'role'=>$role, 'oui'=>$oui, 'taille'=>$tailleRoles]);
    }


     /**
    *@route("/Consultation/supprimer/{id}", name="supprimer")
    */
    public function supprimerConsultation($id, Request $request)
    {
    $repository=$this->getDoctrine()->getRepository(Consultation::class);
    $em=$this->getDoctrine()->getManager();
    $uneConsultation = $repository->find($id);    
    $em->remove($uneConsultation);
    $em->flush();
    return $this->redirectToRoute('consultation');

    
    }


    /**
    *@route("/Consultation/accepter/{id}", name="accepter")
    */
    public function accepterConsultation($id, Request $request){
        $repository=$this->getDoctrine()->getRepository(Consultation::class);
        $em=$this->getDoctrine()->getManager();
        $uneConsultation = $repository->find($id);
        $uneConsultation->setEstValidee("1");
        $em -> flush();
        return $this->redirectToRoute('consultation');
    }


         /**
    *@route("/Consultation/supprimerConsult/{id}", name="supprimerConsult")
    */
    public function supprimerConsultService($id, Request $request)
    {
    $repository=$this->getDoctrine()->getRepository(Consultation::class);
    $em=$this->getDoctrine()->getManager();
    $uneConsultation = $repository->find($id);    
    $em->remove($uneConsultation);
    $em->flush();
    return $this->redirectToRoute('consultation');

    
    }
}
