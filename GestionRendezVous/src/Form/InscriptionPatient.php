<?php 
namespace App\Form;
use App\Entity\User;
use App\Entity\Assistant;
use App\Entity\Medecin;
use Symfony\Component\Form\AbstractType;
use Symfony\Component\Form\FormBuilderInterface;
use Symfony\Component\Form\Extension\Core\Type\SubmitType;
use Symfony\Component\Form\Extension\Core\Type\DateType;
use Symfony\Component\Form\Extension\Core\Type\TextType;
use Symfony\Component\OptionsResolver\OptionsResolver;
use Symfony\Bridge\Doctrine\Form\Type\EntityType;

class InscriptionPatient extends AbstractType
{
	public function buildForm(FormBuilderInterface $builder, array $options)
	{
		$builder
			->add('username',TextType::class)
			->add('password',TextType::class)
			->add('nom',TextType::class)
			->add('prenom',TextType::class)
			->add('save',SubmitType::class,array('label'=>'Enregistrer l\'Indication'))
			->getForm();
			
	
	}
	
	public function configureOptions(OptionsResolver $resolver)
	{
		$resolver->setDefaults(array('data_class'=>Indication::class));
	}



}


?>