<?php

namespace App\Repository;

use App\Entity\IdService;
use Doctrine\Bundle\DoctrineBundle\Repository\ServiceEntityRepository;
use Symfony\Bridge\Doctrine\RegistryInterface;

/**
 * @method IdService|null find($id, $lockMode = null, $lockVersion = null)
 * @method IdService|null findOneBy(array $criteria, array $orderBy = null)
 * @method IdService[]    findAll()
 * @method IdService[]    findBy(array $criteria, array $orderBy = null, $limit = null, $offset = null)
 */
class IdServiceRepository extends ServiceEntityRepository
{
    public function __construct(RegistryInterface $registry)
    {
        parent::__construct($registry, IdService::class);
    }

    // /**
    //  * @return IdService[] Returns an array of IdService objects
    //  */
    /*
    public function findByExampleField($value)
    {
        return $this->createQueryBuilder('i')
            ->andWhere('i.exampleField = :val')
            ->setParameter('val', $value)
            ->orderBy('i.id', 'ASC')
            ->setMaxResults(10)
            ->getQuery()
            ->getResult()
        ;
    }
    */

    /*
    public function findOneBySomeField($value): ?IdService
    {
        return $this->createQueryBuilder('i')
            ->andWhere('i.exampleField = :val')
            ->setParameter('val', $value)
            ->getQuery()
            ->getOneOrNullResult()
        ;
    }
    */
}
