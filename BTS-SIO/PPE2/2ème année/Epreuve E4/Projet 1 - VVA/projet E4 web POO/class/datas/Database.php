<?php

class Database {

    const DB_HOST = 'mysql:host=localhost;dbname=gatci;charset=utf8';
    const DB_USER = 'root';
    const DB_PASS = 'root';

    private $pdo;

    /**
     * Vérifie si une connexion de type PDO est déclarée pour éviter d'en demander plusieurs à chaque fois que l'on souhaite accéder aux données de la base
     * @return PDO un objet de type PDO représentant une connexion à la base de données
     */
    private function checkConnexion() {
        if($this->pdo === null)
            return $this->getConnexion();
        return $this->pdo;
    }

    /**
     * Démarre une connexion à la base de données grâce à l'objet PDO
     * @return PDO un objet représentant une connexion au format PDO
     */
    public function getConnexion() {
        try {
            $pdo = new PDO(self::DB_HOST, self::DB_USER, self::DB_PASS);
            $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
            $this->pdo = $pdo;
            return $this->pdo;
        } catch (\Exception $e) {
            die ('Erreur de connection : '.$e->getMessage());
        }
    }

    /**
     * Créé et exécute une requête SQL en fonction d'un tableau de paramètres null par défaut
     * @param  string $myRequest une requête SQL
     * @param  array $params    un array de paramètres s'insérant dans la requête SQL
     * @return PDO            un objet de type PDO représentant un résultat de requête préparée ou exécutée
     */
    protected function createQuery($myRequest, $params = null) {
        if($params) {
            $result = $this->checkConnexion()->prepare($myRequest);
            $result->setFetchMode(PDO::FETCH_CLASS, static::class);
            $result->execute($params);
            return $result;
        }
        $result = $this->checkConnexion()->query($myRequest);
        $result->setFetchMode(PDO::FETCH_CLASS, static::class);
        return $result;
    }
}
