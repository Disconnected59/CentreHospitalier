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
use Symfony\Component\OptionsResolver\OptionsResolver;
use Symfony\Bridge\Doctrine\Form\Type\EntityType;

class RdvPatientType extends AbstractType
{
	public function buildForm(FormBuilderInterface $builder, array $options)
	{
		$builder
			
			->getForm();
			
	
	}
	
	public function configureOptions(OptionsResolver $resolver)
	{
		$resolver->setDefaults(array('data_class'=>Consultation::class));
	}



}


?>