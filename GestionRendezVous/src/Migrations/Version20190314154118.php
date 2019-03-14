<?php declare(strict_types=1);

namespace DoctrineMigrations;

use Doctrine\DBAL\Schema\Schema;
use Doctrine\Migrations\AbstractMigration;

/**
 * Auto-generated Migration: Please modify to your needs!
 */
final class Version20190314154118 extends AbstractMigration
{
    public function up(Schema $schema) : void
    {
        // this up() migration is auto-generated, please modify it to your needs
        $this->abortIf($this->connection->getDatabasePlatform()->getName() !== 'mysql', 'Migration can only be executed safely on \'mysql\'.');

        $this->addSql('ALTER TABLE consultation DROP FOREIGN KEY FK_964685A6CE0312AE');
        $this->addSql('DROP INDEX IDX_964685A6CE0312AE ON consultation');
        $this->addSql('ALTER TABLE consultation ADD id_patient INT NOT NULL, DROP id_patient_id');
    }

    public function down(Schema $schema) : void
    {
        // this down() migration is auto-generated, please modify it to your needs
        $this->abortIf($this->connection->getDatabasePlatform()->getName() !== 'mysql', 'Migration can only be executed safely on \'mysql\'.');

        $this->addSql('ALTER TABLE consultation ADD id_patient_id INT DEFAULT NULL, DROP id_patient');
        $this->addSql('ALTER TABLE consultation ADD CONSTRAINT FK_964685A6CE0312AE FOREIGN KEY (id_patient_id) REFERENCES patient (id)');
        $this->addSql('CREATE INDEX IDX_964685A6CE0312AE ON consultation (id_patient_id)');
    }
}
