<?php declare(strict_types=1);

namespace DoctrineMigrations;

use Doctrine\DBAL\Schema\Schema;
use Doctrine\Migrations\AbstractMigration;

/**
 * Auto-generated Migration: Please modify to your needs!
 */
final class Version20181113134528 extends AbstractMigration
{
    public function up(Schema $schema) : void
    {
        // this up() migration is auto-generated, please modify it to your needs
        $this->abortIf($this->connection->getDatabasePlatform()->getName() !== 'mysql', 'Migration can only be executed safely on \'mysql\'.');

        $this->addSql('CREATE TABLE consultation (id INT AUTO_INCREMENT NOT NULL, id_medecin_id INT NOT NULL, id_patient_id INT NOT NULL, date DATE NOT NULL, heure TIME NOT NULL, INDEX IDX_964685A6A1799A53 (id_medecin_id), INDEX IDX_964685A6CE0312AE (id_patient_id), PRIMARY KEY(id)) DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci ENGINE = InnoDB');
        $this->addSql('CREATE TABLE medecin (id INT AUTO_INCREMENT NOT NULL, service_id INT NOT NULL, login VARCHAR(30) NOT NULL, motdepasse VARCHAR(20) NOT NULL, email VARCHAR(150) DEFAULT NULL, adresse VARCHAR(50) NOT NULL, nom VARCHAR(30) NOT NULL, prenom VARCHAR(30) NOT NULL, INDEX IDX_1BDA53C6ED5CA9E6 (service_id), PRIMARY KEY(id)) DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci ENGINE = InnoDB');
        $this->addSql('CREATE TABLE patient (id INT AUTO_INCREMENT NOT NULL, login VARCHAR(20) NOT NULL, motdepasse VARCHAR(20) NOT NULL, email VARCHAR(150) DEFAULT NULL, adresse VARCHAR(100) DEFAULT NULL, nom VARCHAR(30) NOT NULL, prenom VARCHAR(30) NOT NULL, PRIMARY KEY(id)) DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci ENGINE = InnoDB');
        $this->addSql('CREATE TABLE service (id INT AUTO_INCREMENT NOT NULL, libelle VARCHAR(30) NOT NULL, PRIMARY KEY(id)) DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci ENGINE = InnoDB');
        $this->addSql('ALTER TABLE consultation ADD CONSTRAINT FK_964685A6A1799A53 FOREIGN KEY (id_medecin_id) REFERENCES medecin (id)');
        $this->addSql('ALTER TABLE consultation ADD CONSTRAINT FK_964685A6CE0312AE FOREIGN KEY (id_patient_id) REFERENCES patient (id)');
        $this->addSql('ALTER TABLE medecin ADD CONSTRAINT FK_1BDA53C6ED5CA9E6 FOREIGN KEY (service_id) REFERENCES service (id)');
    }

    public function down(Schema $schema) : void
    {
        // this down() migration is auto-generated, please modify it to your needs
        $this->abortIf($this->connection->getDatabasePlatform()->getName() !== 'mysql', 'Migration can only be executed safely on \'mysql\'.');

        $this->addSql('ALTER TABLE consultation DROP FOREIGN KEY FK_964685A6A1799A53');
        $this->addSql('ALTER TABLE consultation DROP FOREIGN KEY FK_964685A6CE0312AE');
        $this->addSql('ALTER TABLE medecin DROP FOREIGN KEY FK_1BDA53C6ED5CA9E6');
        $this->addSql('DROP TABLE consultation');
        $this->addSql('DROP TABLE medecin');
        $this->addSql('DROP TABLE patient');
        $this->addSql('DROP TABLE service');
    }
}
