<?php

namespace App\Entity;

use Doctrine\ORM\Mapping as ORM;

/**
 * @ORM\Entity(repositoryClass="App\Repository\ConsultationRepository")
 */
class Consultation
{
    /**
     * @ORM\Id()
     * @ORM\GeneratedValue()
     * @ORM\Column(type="integer")
     */
    private $id;

    /**
     * @ORM\Column(type="date")
     */
    private $Date;

    /**
     * @ORM\Column(type="string, length=255)
     */
    private $Heure;

    /**
     * @ORM\ManyToOne(targetEntity="App\Entity\Medecin")
     * @ORM\JoinColumn(nullable=false)
     */
    private $idMedecin;

    /**
     * @ORM\ManyToOne(targetEntity="App\Entity\Patient")
     * @ORM\JoinColumn(nullable=false)
     */
    private $idPatient;

    public function getId(): ?int
    {
        return $this->id;
    }

    public function getDate(): ?\DateTimeInterface
    {
        return $this->Date;
    }

    public function setDate(\DateTimeInterface $Date): self
    {
        $this->Date = $Date;

        return $this;
    }

    public function getHeure(): ?\DateTimeInterface
    {
        return $this->Heure;
    }

    public function setHeure(\DateTimeInterface $Heure): self
    {
        $this->Heure = $Heure;

        return $this;
    }

    public function getIdMedecin(): ?Medecin
    {
        return $this->idMedecin;
    }

    public function setIdMedecin(?Medecin $idMedecin): self
    {
        $this->idMedecin = $idMedecin;

        return $this;
    }

    public function getIdPatient(): ?Patient
    {
        return $this->idPatient;
    }

    public function setIdPatient(?Patient $idPatient): self
    {
        $this->idPatient = $idPatient;

        return $this;
    }
}
