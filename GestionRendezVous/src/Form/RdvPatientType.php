<?php 
namespace App\Form;
use App\Entity\User;
use App\Entity\Assistant;
use App\Entity\Medecin;
use App\Entity\Consultation;
use Symfony\Component\Form\AbstractType;
use Symfony\Component\Form\FormBuilderInterface;
use Symfony\Component\Form\Extension\Core\Type\SubmitType;
use Symfony\Component\Form\Extension\Core\Type\DateType;
use Symfony\Component\Form\Extension\Core\Type\TextType;
use Symfony\Component\Form\Extension\Core\Type\ChoiceType;
use Symfony\Component\OptionsResolver\OptionsResolver;
use Symfony\Bridge\Doctrine\Form\Type\EntityType;

class RdvPatientType extends AbstractType
{
	public function buildForm(FormBuilderInterface $builder, array $options)
	{

		$builder
			->add('idMedecin',EntityType::class,array('class'=>Medecin::class,'choice_label'=>'nom'))
			->add('date', DateType::class)
			->add('heure', ChoiceType::class, array('choices' =>array('9'=>'9','10'=>'10','11'=>'11','12'=>'12','14'=>'14','15'=>'15','16'=>'16','17'=>'17')))
			->add('save',SubmitType::class,array('label'=>'Valider'))

			->getForm();
			
	}
	public function configureOptions(OptionsResolver $resolver)
	{
		$resolver->setDefaults(array('data_class'=>Consultation::class));
	}



}


?>