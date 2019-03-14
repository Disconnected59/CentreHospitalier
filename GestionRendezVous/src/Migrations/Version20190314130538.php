<?php declare(strict_types=1);

namespace DoctrineMigrations;

use Doctrine\DBAL\Schema\Schema;
use Doctrine\Migrations\AbstractMigration;

/**
 * Auto-generated Migration: Please modify to your needs!
 */
final class Version20190314130538 extends AbstractMigration
{
    public function up(Schema $schema) : void
    {
        // this up() migration is auto-generated, please modify it to your needs
        $this->abortIf($this->connection->getDatabasePlatform()->getName() !== 'mysql', 'Migration can only be executed safely on \'mysql\'.');

        $this->addSql('ALTER TABLE user ADD id_medecin_id INT DEFAULT NULL, ADD id_assistant_id INT DEFAULT NULL');
        $this->addSql('ALTER TABLE user ADD CONSTRAINT FK_8D93D649A1799A53 FOREIGN KEY (id_medecin_id) REFERENCES medecin (id)');
        $this->addSql('ALTER TABLE user ADD CONSTRAINT FK_8D93D649C392F29D FOREIGN KEY (id_assistant_id) REFERENCES assistant (id)');
        $this->addSql('CREATE UNIQUE INDEX UNIQ_8D93D649A1799A53 ON user (id_medecin_id)');
        $this->addSql('CREATE UNIQUE INDEX UNIQ_8D93D649C392F29D ON user (id_assistant_id)');
    }

    public function down(Schema $schema) : void
    {
        // this down() migration is auto-generated, please modify it to your needs
        $this->abortIf($this->connection->getDatabasePlatform()->getName() !== 'mysql', 'Migration can only be executed safely on \'mysql\'.');

        $this->addSql('ALTER TABLE user DROP FOREIGN KEY FK_8D93D649A1799A53');
        $this->addSql('ALTER TABLE user DROP FOREIGN KEY FK_8D93D649C392F29D');
        $this->addSql('DROP INDEX UNIQ_8D93D649A1799A53 ON user');
        $this->addSql('DROP INDEX UNIQ_8D93D649C392F29D ON user');
        $this->addSql('ALTER TABLE user DROP id_medecin_id, DROP id_assistant_id');
    }
}
